﻿using IMS.CoreBusiness;
using IMS.UseCases.Interfaces;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases.Activities
{
    public class PurchaseInventoryUseCase : IPurchaseInventoryUseCase
    {
        private readonly IInventoryTransactionRepository _inventoryTransactionRepository;
        private readonly IInventoryRepository _inventoryRepository;

        public PurchaseInventoryUseCase(
            IInventoryTransactionRepository inventoryTransactionRepository,
            IInventoryRepository inventoryRepository)
        {
            _inventoryTransactionRepository = inventoryTransactionRepository;
            _inventoryRepository = inventoryRepository;
        }

        public async Task ExecuteAsync(int purchaseId, string poNumber, Inventory inventory, int quantity, string doneBy)
        {
            await _inventoryTransactionRepository.PurchaseAsync(purchaseId, poNumber, inventory, quantity, inventory.Price, doneBy);

            //we also need to increase the quantity
            inventory.Quantity += quantity;
            await _inventoryRepository.UpdateInventoryAsync(inventory);
        }
    }
}
