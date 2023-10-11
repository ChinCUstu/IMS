namespace IMS.CoreBusiness;

public class ProductEquipment
{
    public int ProductId { get; set; }
    public Product? Product { get; set; }
    
    public int EquipmentId { get; set; }
    
    public Equipment? Equipment { get; set; }
    
}