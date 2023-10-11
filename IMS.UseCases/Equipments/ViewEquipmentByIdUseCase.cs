using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases;

public class ViewEquipmentByIdUseCase : IViewEquipmentByIdUseCase
{
    private readonly IEquipmentRepository equipmentRepository;


    public ViewEquipmentByIdUseCase(IEquipmentRepository equipmentRepository)
    {
        this.equipmentRepository = equipmentRepository;
    }

    public async Task<Equipment> ExecuteAsync(int equipmentId)
    {
        return await this.equipmentRepository.GetEquipmentByIdAsync(equipmentId);
    }
}