using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.Plugins.EFCore;

public class CreateSalesRep : ICreateSalesRep
{
    private readonly IMSContext _db;

    public CreateSalesRep(IMSContext db)
    {
        _db = db;
    }

    public async Task<int> ExecuteAsync(Sale newSales)
    {
        _db.Sales.Add(newSales);
        await _db.SaveChangesAsync();
        return newSales.SaleId;
    }
}