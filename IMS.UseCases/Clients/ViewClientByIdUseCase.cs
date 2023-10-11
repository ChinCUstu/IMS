using IMS.CoreBusiness;
using IMS.Plugins.EFCore;

namespace IMS.UseCases.Clients;

public class ViewClientByIdUseCase : IViewClientByIdUseCase
{
    private readonly IClientRepository clientRepository;

    public ViewClientByIdUseCase(IClientRepository clientRepository)
    {
        this.clientRepository = clientRepository;
    }

    public async Task<Client> ExecuteAsync(int clientId)
    {
        return await clientRepository.GetClientByIdAsync(clientId);
    }
}