using IMS.Plugins.EFCore;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases;

public class DeleteSupplierUseCase : IDeleteSupplierUseCase
{
    private readonly ISupplierRepository supplierRepository;

    public DeleteSupplierUseCase(ISupplierRepository supplierRepository)
    {
        this.supplierRepository = supplierRepository;
    }

    public async Task ExecuteAsync(int supplierId)
    {
        await this.supplierRepository.DeleteSupplierAsync(supplierId);
    }
}