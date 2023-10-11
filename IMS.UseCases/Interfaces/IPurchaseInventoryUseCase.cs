using IMS.CoreBusiness;

namespace IMS.UseCases.Interfaces
{
    public interface IPurchaseInventoryUseCase
    {
        Task ExecuteAsync(int purchaseId, string poNumber, Inventory inventory, int quantity, string doneBy);
    }
}