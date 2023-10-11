using IMS.CoreBusiness;
using IMS.Plugins.EFCore;

namespace IMS.UseCases.Suppliers;

public class AddSupplierUseCase : IAddSupplierUseCase
{
    private readonly ISupplierRepository supplierRepository;

    public AddSupplierUseCase(ISupplierRepository supplierRepository)
    {
        this.supplierRepository = supplierRepository;
    }

    public async Task ExecuteAsync(Supplier supplier)
    {
        if (supplier == null) return;

        await supplierRepository.AddSupplierAsync(supplier);
    }
}