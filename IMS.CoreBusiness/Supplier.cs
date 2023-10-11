namespace IMS.CoreBusiness;

public class Supplier
{
    public int SupplierId { get; set; }
    public string? Name { get; set; }
    public string? ContactInfo { get; set; }
    
    public List<Product> Purchases { get; set; }

    public Supplier() { 
    Purchases = new List<Product>();
    }

}