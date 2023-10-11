using IMS.CoreBusiness;
using IMS.Plugins.EFCore;
namespace IMS.UseCases.Clients;

public class ViewClientByNameUseCase : IViewClientByNameUseCase
{
    private readonly IClientRepository clientRepository;

    public ViewClientByNameUseCase(IClientRepository clientRepository)
    {
        this.clientRepository = clientRepository;
    }

    public async Task<List<Client>> ExecuteAsync(string name = "")
    {
        return await this.clientRepository.GetClientByNameAsync(name);
    }
}