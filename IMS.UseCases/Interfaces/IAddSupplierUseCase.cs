using IMS.CoreBusiness;

namespace IMS.UseCases.Suppliers;

public interface IAddSupplierUseCase
{
    Task ExecuteAsync(Supplier supplier);
}