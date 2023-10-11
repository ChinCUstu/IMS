using IMS.CoreBusiness;

namespace IMS.UseCases;

public interface IEditEquipmentUseCase
{
    Task ExecuteAsync(Equipment equipment);
}