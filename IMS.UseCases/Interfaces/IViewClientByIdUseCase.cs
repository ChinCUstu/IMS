using IMS.CoreBusiness;

namespace IMS.UseCases.Clients;

public interface IViewClientByIdUseCase
{
    Task<Client> ExecuteAsync(int clientId);
}