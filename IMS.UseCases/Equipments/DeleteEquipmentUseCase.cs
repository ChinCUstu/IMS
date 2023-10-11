using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases;

public class DeleteEquipmentUseCase : IDeleteEquipmentUseCase
{
    private readonly IEquipmentRepository equipmentRepository;

    public DeleteEquipmentUseCase(IEquipmentRepository equipmentRepository)
    {
        this.equipmentRepository = equipmentRepository;
    }

    public async Task ExecuteAsync(int equipmentId)
    {
        await this.equipmentRepository.DeleteEquipmentAsync(equipmentId);
    }
}