using IMS.CoreBusiness;

namespace IMS.UseCases.Clients;

public interface IAddClientUseCase
{
    Task ExecuteAsync(Client client);
}