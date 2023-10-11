using IMS.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases
{
    public class ViewEquipmentsByNameUseCase : IViewEquipmentsByNameUseCase
    {
        private readonly IEquipmentRepository equipmentRepository;

        public ViewEquipmentsByNameUseCase(IEquipmentRepository equipmentRepository)
        {
            this.equipmentRepository = equipmentRepository;
        }

        public async Task<List<Equipment>> ExecuteAsync(string name = "")
        {
            return await this.equipmentRepository.GetEquipmentsByNameAsync(name);
        }
    }
}