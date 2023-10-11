namespace IMS.UseCases;

public interface IDeleteEquipmentUseCase
{
    Task ExecuteAsync(int equipmentId);
}