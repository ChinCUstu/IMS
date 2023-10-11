using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases.Inventories;

public class UpdateInventoryQuantityUseCase : IUpdateInventoryQuantityUseCase
{
    private readonly IInventoryRepository _inventoryRepository;

    public UpdateInventoryQuantityUseCase(IInventoryRepository inventoryRepository)
    {
        _inventoryRepository = inventoryRepository;
    }

    public async Task ExecuteAsync(int inventoryId, int newQuantity)
    {
        var inventory = await _inventoryRepository.GetInventoryByIdAsync(inventoryId);
        if (inventory == null)
        {
            throw new InvalidOperationException("Inventory not found");
        }

        inventory.Quantity = newQuantity;

        await _inventoryRepository.UpdateInventoryAsync(inventory);
    }
}