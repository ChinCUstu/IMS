namespace IMS.CoreBusiness;

public class Sale
{
    public int SaleId { get; set; }
    public string ClientName { get; set; }

    // public int ProductId { get; set; }
    // public Product Product { get; set; }
    public DateTime SalesDate { get; set; }
    public double AmountPaid { get; set; }
    public List<ProductTransaction> ProductTransactions { get; set; }
}