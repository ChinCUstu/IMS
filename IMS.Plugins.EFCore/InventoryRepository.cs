﻿using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;
using Microsoft.EntityFrameworkCore;

namespace IMS.Plugins.EFCore
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly IMSContext db;

        public InventoryRepository(IMSContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<Inventory>> GetInventoriesByName(string name)
        {
            return await this.db.Inventories.Where(x => x.InventoryName.ToLower().IndexOf(name.ToLower()) >= 0)
                .ToListAsync();
        }

        public async Task AddInventoryAsync(Inventory inventory)
        {
            if (db.Inventories.Any(x => x.InventoryName.ToLower() == inventory.InventoryName.ToLower())) return;

            db.Inventories.Add(inventory);
            await db.SaveChangesAsync();
        }

        public async Task UpdateInventoryAsync(Inventory inventory)
        {
            if (db.Inventories.Any(x => x.InventoryId != inventory.InventoryId &&
                                        x.InventoryName.ToLower() == inventory.InventoryName.ToLower())) return;


            var inv = await this.db.Inventories.FindAsync(inventory.InventoryId);
            if (inv != null)
            {
                inv.InventoryName = inventory.InventoryName;
                inv.Price = inventory.Price;
                inv.Quantity = inventory.Quantity;

                await db.SaveChangesAsync();
            }
        }

        public async Task<Inventory?> GetInventoryByIdAsync(int inventoryId)
        {
            return await this.db.Inventories.FindAsync(inventoryId);
        }
    }
}