using IMS.CoreBusiness;

namespace IMS.UseCases.Clients;

public interface IViewClientByNameUseCase
{
    Task<List<Client>> ExecuteAsync(string name = "");
}