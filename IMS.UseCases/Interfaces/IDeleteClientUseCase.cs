namespace IMS.UseCases.Clients;

public interface IDeleteClientUseCase
{
    Task ExecuteAsync(int clientId);
}