using IMS.CoreBusiness;
using Microsoft.EntityFrameworkCore;

namespace IMS.Plugins.EFCore;

public class SupplierRepository : ISupplierRepository
{
    private readonly IMSContext db;

    public SupplierRepository(IMSContext db)
    {
        this.db = db;
    }

    public async Task AddSupplierAsync(Supplier supplier)
    {
        if (db.Suppliers.Any(x => x.Name.ToLower() == supplier.Name.ToLower())) return;

        db.Suppliers.Add(supplier);

        await db.SaveChangesAsync();
    }

    public async Task<List<Supplier>> GetSuppliersByNameAsync(string name)
    {
        return await db.Suppliers.Where(x => x.Name.ToLower().Contains(name.ToLower())).ToListAsync();
    }


    public async Task<Supplier> GetSupplierByIdAsync(int supplierId)
    {
        return await db.Suppliers.Include(x => x.Purchases).FirstOrDefaultAsync(x => x.SupplierId == supplierId);
    }

    public async Task UpdateSupplierAsync(Supplier supplier)
    {
        var supp = await db.Suppliers.FindAsync(supplier.SupplierId);
        if (supp != null)
        {
            supp.Name = supplier.Name;
            supp.ContactInfo = supplier.ContactInfo;

            await db.SaveChangesAsync();
        }
    }

    public async Task DeleteSupplierAsync(int supplierId)
    {
        var supplier = await db.Suppliers.FindAsync(supplierId);
        if (supplier != null)
        {
            db.Suppliers.Remove(supplier);
            await db.SaveChangesAsync();
        }
    }
}