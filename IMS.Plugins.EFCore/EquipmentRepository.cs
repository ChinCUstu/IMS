using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;
using Microsoft.EntityFrameworkCore;

namespace IMS.Plugins.EFCore;

public class EquipmentRepository : IEquipmentRepository
{
    private readonly IMSContext db;

    public EquipmentRepository(IMSContext db)
    {
        this.db = db;
    }

    public async Task AddEquipmentAsync(Equipment equipment)
    {
        if (db.Equipments.Any(x => x.EquipmentName.ToLower() == equipment.EquipmentName.ToLower())) return;

        db.Equipments.Add(equipment);

        await db.SaveChangesAsync();
    }

    public async Task<List<Equipment>> GetEquipmentsByNameAsync(string name)
    {
        return await db.Equipments.Where(x => (x.EquipmentName.ToLower().IndexOf(name.ToLower()) >= 0 ||
                                               string.IsNullOrWhiteSpace(name)) &&
                                              x.IsActive == true).ToListAsync();
    }

    public async Task<Equipment> GetEquipmentByIdAsync(int equipmentId)
    {
        return await db.Equipments.Include(x => x.ProductEquipments)
            .ThenInclude(x => x.Product)
            .FirstOrDefaultAsync(x => x.EquipmentId == equipmentId);
    }

    public async Task UpdateEquipmentAsync(Equipment equipment)
    {
        if (db.Equipments.Any(x => x.EquipmentName.ToLower() == equipment.EquipmentName.ToLower())) return;
        var equip = await db.Equipments.FindAsync(equipment.EquipmentId);
        if (equip != null)
        {
            equip.EquipmentName = equipment.EquipmentName;
            equip.SerialNo = equipment.SerialNo;
            equip.Model = equipment.Model;
            equip.Marque = equipment.Marque;
            equip.ProductEquipments = equipment.ProductEquipments;

            await db.SaveChangesAsync();
        }
    }

    public async Task DeleteEquipmentAsync(int equipmentId)
    {
        var equipment = await db.Equipments.FindAsync(equipmentId);
        if (equipment != null)
        {
            equipment.IsActive = false;
            await db.SaveChangesAsync();
        }
    }
}