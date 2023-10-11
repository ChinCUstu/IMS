namespace IMS.WebApp.ViewModels
{
    public class SellViewModel
    {
        // [Required]
        // [Range(minimum: 1, maximum: int.MaxValue, ErrorMessage = "Quantity has to be greater than 1.")]
        // public int QuantityToSell { get; set; }
        //
        // [Required]
        // [Range(minimum: 0, maximum: int.MaxValue, ErrorMessage = "Price has to be greater than 0.")]
        // public double ProductPrice { get; set; }

        public string ClientName { get; set; }
        public List<ProductItem> ProductItems { get; init; }
    }
}