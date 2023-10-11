using IMS.CoreBusiness;
using IMS.Plugins.EFCore;

namespace IMS.UseCases;

public class EditSupplierUseCase : IEditSupplierUseCase
{
    private readonly ISupplierRepository supplierRepository;

    public EditSupplierUseCase(ISupplierRepository supplierRepository)
    {
        this.supplierRepository = supplierRepository;
    }

    public async Task ExecuteAsync(Supplier supplier)
    {
        await supplierRepository.UpdateSupplierAsync(supplier);
    }
}