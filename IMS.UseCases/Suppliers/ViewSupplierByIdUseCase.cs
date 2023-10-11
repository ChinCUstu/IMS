using IMS.CoreBusiness;
using IMS.Plugins.EFCore;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases;

public class ViewSupplierByIdUseCase : IViewSupplierByIdUseCase
{
    private readonly ISupplierRepository supplierRepository;


    public ViewSupplierByIdUseCase(ISupplierRepository supplierRepository)
    {
        this.supplierRepository = supplierRepository;
    }

    public async Task<Supplier> ExecuteAsync(int supplierId)
    {
        return await this.supplierRepository.GetSupplierByIdAsync(supplierId);
    }
}