using IMS.CoreBusiness;

namespace IMS.Plugins.EFCore;

public interface ICreatePurchaseRep
{
    Task<int> ExecuteAsync(Purchase newPurchase);
}