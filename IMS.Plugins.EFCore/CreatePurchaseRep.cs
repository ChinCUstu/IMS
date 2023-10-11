using IMS.CoreBusiness;

namespace IMS.Plugins.EFCore;

public class CreatePurchaseRep : ICreatePurchaseRep
{
    private readonly IMSContext _db;

    public CreatePurchaseRep(IMSContext db)
    {
        _db = db;
    }

    public async Task<int> ExecuteAsync(Purchase newPurchase)
    {
        _db.Purchases.Add(newPurchase);
        await _db.SaveChangesAsync();
        return newPurchase.PurchaseId;
    }
}