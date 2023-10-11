using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases;

public class AddEquipmentUseCase : IAddEquipmentUseCase
{
    private readonly IEquipmentRepository productEquipment;

    public AddEquipmentUseCase(IEquipmentRepository productEquipment)
    {
        this.productEquipment = productEquipment;
    }

    public async Task ExecuteAsync(Equipment equipment)
    {
        if (equipment == null) return;

        await productEquipment.AddEquipmentAsync(equipment);
    }
}