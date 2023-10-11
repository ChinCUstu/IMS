using IMS.CoreBusiness;
using IMS.Plugins.EFCore;

namespace IMS.UseCases.Clients;

public class AddClientUseCase : IAddClientUseCase
{
    private readonly IClientRepository clientRepository;

    public AddClientUseCase(IClientRepository clientRepository)
    {
        this.clientRepository = clientRepository;
    }

    public async Task ExecuteAsync(Client client)
    {
        if (client == null) return;

        await clientRepository.AddClientAsync(client);
    }
}