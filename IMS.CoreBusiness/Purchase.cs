namespace IMS.CoreBusiness
{
    public class Purchase
    {
        public int PurchaseId {get;set;}
        public string SupplierName { get; set;}
        public DateTime PurchaseDate { get; set; }

        public double AmountPaid { get; set; }

        public List<InventoryTransaction> InventoryTransactions { get; set; }   
    }
}
