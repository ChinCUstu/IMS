using IMS.CoreBusiness;
using Microsoft.EntityFrameworkCore;

namespace IMS.Plugins.EFCore;

public class ClientRepository : IClientRepository
{
    private readonly IMSContext db;

    public ClientRepository(IMSContext db)
    {
        this.db = db;
    }

    public async Task AddClientAsync(Client client)
    {
        if (db.Clients.Any(x => x.ClientName.ToLower() == client.ClientName.ToLower())) return;

        db.Clients.Add(client);

        await db.SaveChangesAsync();
    }

    public async Task<List<Client>> GetClientByNameAsync(string name)
    {
        return await db.Clients.Where(x => x.ClientName.ToLower().Contains(name.ToLower())).ToListAsync();
    }

    public async Task<Client> GetClientByIdAsync(int clientId)
    {
        return await db.Clients.Include(x => x.Sales).FirstOrDefaultAsync(x => x.ClientId == clientId);
    }

    public async Task UpdateClientAsync(Client client)
    {
        var clt = await db.Clients.FindAsync(client.ClientId);
        if (clt != null)
        {
            clt.ClientName = client.ClientName;
            clt.ContactInfo = client.ContactInfo;
            clt.PhoneNumber = client.PhoneNumber;
            clt.PreferredPaymentMethod = client.PreferredPaymentMethod;

            await db.SaveChangesAsync();
        }
    }

    public async Task DeleteClientAsync(int clientId)
    {
        var client = await db.Clients.FindAsync(clientId);
        if (client != null)
        {
            db.Clients.Remove(client);
            await db.SaveChangesAsync();
        }
    }
}