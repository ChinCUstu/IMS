using IMS.CoreBusiness;

namespace IMS.UseCases;

public interface IViewEquipmentByIdUseCase
{
    Task<Equipment> ExecuteAsync(int equipmentId);
}