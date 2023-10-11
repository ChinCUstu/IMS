using IMS.CoreBusiness;
using Microsoft.EntityFrameworkCore;

namespace IMS.Plugins.EFCore
{
    public class IMSContext : DbContext
    {
        public IMSContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<InventoryTransaction> InventoryTransactions { get; set; }
        public DbSet<ProductTransaction> ProductTransactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //build relationships
            modelBuilder.Entity<ProductInventory>()
                .HasKey(pi => new { pi.ProductId, pi.InventoryId });
            modelBuilder.Entity<ProductEquipment>()
                .HasKey(pe => new { pe.ProductId, pe.EquipmentId });
            modelBuilder.Entity<ProductInventory>()
                .HasOne(pi => pi.Product)
                .WithMany(p => p.ProductInventories)
                .HasForeignKey(pi => pi.ProductId);
            modelBuilder.Entity<ProductInventory>()
                .HasOne(pi => pi.Inventory)
                .WithMany(i => i.ProductInventories)
                .HasForeignKey(pi => pi.InventoryId);
            modelBuilder.Entity<ProductEquipment>()
                .HasOne(pe => pe.Product)
                .WithMany(p => p.ProductEquipments)
                .HasForeignKey(pe => pe.ProductId);
            modelBuilder.Entity<ProductEquipment>()
                .HasOne(pe => pe.Equipment)
                .WithMany(e => e.ProductEquipments)
                .HasForeignKey(pe => pe.EquipmentId);
            modelBuilder.Entity<Supplier>().HasMany(s => s.Purchases).WithOne();
            modelBuilder.Entity<Sale>().HasMany(p => p.ProductTransactions).WithOne(pt => pt.Sales).HasForeignKey(pt => pt.SaleId);
            modelBuilder.Entity<Purchase>().HasMany(p => p.InventoryTransactions).WithOne(pt => pt.Purchase).HasForeignKey(pt => pt.PurchaseId);
            //seeding data
            modelBuilder.Entity<Inventory>().HasData(
                new Inventory { InventoryId = 1, InventoryName = "Gas Engine", Price = 1000, Quantity = 1 },
                new Inventory { InventoryId = 2, InventoryName = "Body", Price = 400, Quantity = 1 },
                new Inventory { InventoryId = 3, InventoryName = "Wheel", Quantity = 4, Price = 100 },
                new Inventory { InventoryId = 4, InventoryName = "Seat", Price = 50, Quantity = 5 },
                new Inventory { InventoryId = 5, InventoryName = "Electric Engine", Price = 8000, Quantity = 2 },
                new Inventory { InventoryId = 6, InventoryName = "Battery", Price = 400, Quantity = 5 }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, ProductName = "Gas Car", Price = 20000, Quantity = 1 },
                new Product { ProductId = 2, ProductName = "Electric Car", Price = 15000, Quantity = 1 }
            );
            modelBuilder.Entity<Equipment>().HasData(
                new Equipment
                {
                    EquipmentId = 1, EquipmentName = "Presse Hydraulique à Injection", Marque = "ELECTRONICA",
                    Model = "OP01000287", SerialNo = "3117"
                },
                new Equipment
                {
                    EquipmentId = 2, EquipmentName = "Broyeuse", Marque = "WENSUI", Model = "WSGP-500",
                    SerialNo = "G112508"
                },
                new Equipment
                {
                    EquipmentId = 3, EquipmentName = "Excavator X1", Marque = "Caterpillar", Model = "336F",
                    SerialNo = "CAT336FC5EY00123"
                },
                new Equipment
                {
                    EquipmentId = 4, EquipmentName = "Bulldozer D5", Marque = "Komatsu", Model = "D85EX-18",
                    SerialNo = "KMT0D070J02012345"
                },
                new Equipment
                {
                    EquipmentId = 5, EquipmentName = "Wheel Loader", Marque = "Volvo", Model = "L220H",
                    SerialNo = "VCE0L220P00345678"
                });
            modelBuilder.Entity<Supplier>().HasData(
                new Supplier { SupplierId = 1, Name = "Acme Corp", ContactInfo = "123 Main St, Anytown" },
                new Supplier { SupplierId = 2, Name = "Globex Inc", ContactInfo = "456 Elm St, Othertown" });
            modelBuilder.Entity<Client>().HasData(
                new Client
                {
                    ClientId = 1, ClientName = "John Doe", PhoneNumber = "+237 612345678",
                    PreferredPaymentMethod = "Credit Card", ContactInfo = "1234 Park St, Douala"
                },
                new Client
                {
                    ClientId = 2, ClientName = "Jane Smith", PhoneNumber = "+237 623456789",
                    PreferredPaymentMethod = "Mobile Money",
                    ContactInfo = "5678 Garden Ave, Yaoundé"
                },
                new Client
                {
                    ClientId = 3, ClientName = "Robert Johnson", PhoneNumber = "+237 634567890",
                    PreferredPaymentMethod = "Bank Transfer",
                    ContactInfo = "9012 Park St, Bamenda"
                },
                new Client
                {
                    ClientId = 4, ClientName = "Emily", PhoneNumber = "+237 645678901",
                    PreferredPaymentMethod = "Cash on Delivery",
                    ContactInfo = "0123 City Hall, Buea"
                },
                new Client
                {
                    ClientId = 5, ClientName = "Michael Miller", PhoneNumber = "+237 656789012",
                    PreferredPaymentMethod = "PayPal",
                    ContactInfo = "2390 Park St, Bafoussam"
                }
            );
            modelBuilder.Entity<Sale>().HasData(
                new Sale
                    { SaleId = 1, ClientName = "John Doe", SalesDate = DateTime.Now, AmountPaid = 20000 },
                new Sale
                    { SaleId = 2, ClientName = "Emily", SalesDate = DateTime.Now, AmountPaid = 15000 });
            modelBuilder.Entity<ProductInventory>().HasData(
                new ProductInventory { ProductId = 1, InventoryId = 1, InventoryQuantity = 1 }, // engine
                new ProductInventory { ProductId = 1, InventoryId = 2, InventoryQuantity = 1 }, // body
                new ProductInventory { ProductId = 1, InventoryId = 3, InventoryQuantity = 4 }, //4 wheels
                new ProductInventory { ProductId = 1, InventoryId = 4, InventoryQuantity = 5 } //5 seats
            );
            modelBuilder.Entity<ProductInventory>().HasData(
                new ProductInventory { ProductId = 2, InventoryId = 5, InventoryQuantity = 1 }, // engine
                new ProductInventory { ProductId = 2, InventoryId = 2, InventoryQuantity = 1 }, // body
                new ProductInventory { ProductId = 2, InventoryId = 3, InventoryQuantity = 4 }, //4 wheels
                new ProductInventory { ProductId = 2, InventoryId = 4, InventoryQuantity = 5 }, //5 seats
                new ProductInventory { ProductId = 2, InventoryId = 6, InventoryQuantity = 1 } // battery
            );
            modelBuilder.Entity<ProductEquipment>().HasData(
                new ProductEquipment { ProductId = 1, EquipmentId = 1 },
                new ProductEquipment { ProductId = 1, EquipmentId = 2 },
                new ProductEquipment { ProductId = 1, EquipmentId = 4 },
                new ProductEquipment { ProductId = 1, EquipmentId = 5 });
            modelBuilder.Entity<ProductEquipment>().HasData(
                new ProductEquipment { ProductId = 2, EquipmentId = 1 },
                new ProductEquipment { ProductId = 2, EquipmentId = 2 },
                new ProductEquipment { ProductId = 2, EquipmentId = 4 }); 
        }
    }
}