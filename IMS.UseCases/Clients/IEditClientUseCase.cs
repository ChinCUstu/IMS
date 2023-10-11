using IMS.CoreBusiness;

namespace IMS.UseCases.Clients;

public interface IEditClientUseCase
{
    Task ExecuteAsync(Client client);
}