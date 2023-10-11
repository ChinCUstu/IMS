namespace IMS.UseCases;

public interface IDeleteSupplierUseCase
{
    Task ExecuteAsync(int supplierId);
}