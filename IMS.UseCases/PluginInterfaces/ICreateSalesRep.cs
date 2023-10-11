using IMS.CoreBusiness;

namespace IMS.UseCases.PluginInterfaces;

public interface ICreateSalesRep
{
    Task<int> ExecuteAsync(Sale newSales);
}