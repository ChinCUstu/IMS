using IMS.CoreBusiness;

namespace IMS.UseCases;

public interface IViewSuppliersByNameUseCase
{
    Task<List<Supplier>> ExecuteAsync(string name = "");
}