using IMS.CoreBusiness;
using IMS.Plugins.EFCore;

namespace IMS.UseCases.Clients;

public class EditClientUseCase : IEditClientUseCase
{
    private readonly IClientRepository clientRepository;

    public EditClientUseCase(IClientRepository clientRepository)
    {
        this.clientRepository = clientRepository;
    }

    public async Task ExecuteAsync(Client client)
    {
        await clientRepository.UpdateClientAsync(client);
    }
}