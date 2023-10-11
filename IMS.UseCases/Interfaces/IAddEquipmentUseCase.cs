using IMS.CoreBusiness;

namespace IMS.UseCases;

public interface IAddEquipmentUseCase
{
    Task ExecuteAsync(Equipment equipment);
}