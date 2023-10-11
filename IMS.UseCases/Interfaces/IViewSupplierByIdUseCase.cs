using IMS.CoreBusiness;

namespace IMS.UseCases;

public interface IViewSupplierByIdUseCase
{
    Task<Supplier> ExecuteAsync(int supplierId);
}