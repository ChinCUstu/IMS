using IMS.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.PluginInterfaces
{
    public interface IEquipmentRepository
    {
        Task AddEquipmentAsync(Equipment equipment);
        Task<List<Equipment>> GetEquipmentsByNameAsync(string name);
        Task<Equipment> GetEquipmentByIdAsync(int equipmentId);
        Task UpdateEquipmentAsync(Equipment equipment);
        Task DeleteEquipmentAsync(int equipmentId);
    }
}