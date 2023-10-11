using IMS.CoreBusiness;

namespace IMS.Plugins.EFCore;

public interface IClientRepository
{
    Task AddClientAsync(Client client);
    Task<List<Client>> GetClientByNameAsync(string name);
    Task<Client> GetClientByIdAsync(int clientId);
    Task UpdateClientAsync(Client client);
    Task DeleteClientAsync(int clientId);
}