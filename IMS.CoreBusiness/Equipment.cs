using System.ComponentModel.DataAnnotations;

namespace IMS.CoreBusiness
{
    public class Equipment
    {
        public int EquipmentId { get; set; }
        [Required] public string? EquipmentName { get; set; }
        public string Marque { get; set; }
        public string Model { get; set; }

        [Required] public string? SerialNo { get; set; }
        public bool IsActive { get; set; } = true;

        public List<ProductEquipment>? ProductEquipments { get; set; }
    }
}