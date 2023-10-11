using System.ComponentModel.DataAnnotations;

namespace IMS.CoreBusiness
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        
        [Required]
        public string? InventoryName { get; set; } 

        [Range(0, int.MaxValue, ErrorMessage = "la quantité doit être supérieure ou égale à 0")]
        public int Quantity { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "le prix doit être supérieure ou égale à 0")]
        public double Price { get; set; }

        public List<ProductInventory>? ProductInventories { get; set; }
    }
}