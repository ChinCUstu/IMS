using IMS.CoreBusiness;

namespace IMS.UseCases;

public interface IViewEquipmentsByNameUseCase
{
    Task<List<Equipment>> ExecuteAsync(string name = "");
}