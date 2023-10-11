namespace IMS.WebApp.ViewModels
{
    public class PurchaseViewModel
    {
        // [Required]
        // [Range(minimum: 1, maximum: int.MaxValue, ErrorMessage = "Quantity has to be greater than 1.")]
        // public int QuantityToPurchase { get; set; }

        // public Product SelectedProduct { get; set; }
        public string SupplierName { get; set; }
        public List<InventoryItem> InventoryItems { get; set; }
    }
}