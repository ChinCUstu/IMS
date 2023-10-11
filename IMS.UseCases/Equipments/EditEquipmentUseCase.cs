using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases;

public class EditEquipmentUseCase : IEditEquipmentUseCase
{
    private readonly IEquipmentRepository equipmentRepository;

    public EditEquipmentUseCase(IEquipmentRepository equipmentRepository)
    {
        this.equipmentRepository = equipmentRepository;
    }

    public async Task ExecuteAsync(Equipment equipment)
    {
        await this.equipmentRepository.UpdateEquipmentAsync(equipment);
    }
}