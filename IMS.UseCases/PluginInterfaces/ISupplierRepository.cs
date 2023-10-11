using IMS.CoreBusiness;

namespace IMS.Plugins.EFCore;

public interface ISupplierRepository
{
    Task AddSupplierAsync(Supplier supplier);
    Task<List<Supplier>> GetSuppliersByNameAsync(string name);
    Task<Supplier> GetSupplierByIdAsync(int supplierId);
    Task UpdateSupplierAsync(Supplier supplier);
    Task DeleteSupplierAsync(int supplierId);
}