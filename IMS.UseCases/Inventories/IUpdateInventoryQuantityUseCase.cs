namespace IMS.UseCases;

public interface IUpdateInventoryQuantityUseCase
{
    Task ExecuteAsync(int inventoryId, int newQuantity);
}