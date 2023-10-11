namespace IMS.CoreBusiness;

public class Client
{
    public int ClientId { get; set; }
    public string ClientName { get; set; }
    public string ContactInfo { get; set; }
    public string PhoneNumber { get; set; }
    public string PreferredPaymentMethod { get; set; }
    public List<Sale> Sales { get; set; }
    public Client()
    {
        Sales = new List<Sale>();
    }
}