using System.ComponentModel.DataAnnotations;

namespace IMS.WebApp.ViewModels;

public class ProductItem
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }

    [Range(0, int.MaxValue, ErrorMessage = "Quantity must be greater or equal to {0}")]
    public int Quantity { get; set; }

    public double price { get; set; }

    [Range(minimum: 1, maximum: int.MaxValue, ErrorMessage = "Quantity has to be greater than 1.")]
    public int QuantityToSell { get; set; }
}