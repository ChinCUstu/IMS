using IMS.Plugins.EFCore;

namespace IMS.UseCases.Clients;

public class DeleteClientUseCase : IDeleteClientUseCase
{
    private readonly IClientRepository clientRepository;

    public DeleteClientUseCase(IClientRepository clientRepository)
    {
        this.clientRepository = clientRepository;
    }

    public async Task ExecuteAsync(int clientId)
    {
        await this.clientRepository.DeleteClientAsync(clientId);
    }
}