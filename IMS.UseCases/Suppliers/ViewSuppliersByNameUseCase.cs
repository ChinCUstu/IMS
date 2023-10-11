using IMS.CoreBusiness;
using IMS.Plugins.EFCore;

namespace IMS.UseCases
{
    public class ViewSuppliersByNameUseCase : IViewSuppliersByNameUseCase
    {
        private readonly ISupplierRepository supplierRepository;

        public ViewSuppliersByNameUseCase(ISupplierRepository supplierRepository)
        {
            this.supplierRepository = supplierRepository;
        }

        public async Task<List<Supplier>> ExecuteAsync(string name = "")
        {
            return await this.supplierRepository.GetSuppliersByNameAsync(name);
        }
    }
}