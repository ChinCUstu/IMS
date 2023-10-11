using IMS.CoreBusiness;

namespace IMS.UseCases;

public interface IEditSupplierUseCase
{
    Task ExecuteAsync(Supplier supplier);
}