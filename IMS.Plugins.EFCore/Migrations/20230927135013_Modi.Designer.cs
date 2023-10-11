﻿// <auto-generated />
using System;
using IMS.Plugins.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IMS.Plugins.EFCore.Migrations
{
    [DbContext(typeof(IMSContext))]
    [Migration("20230927135013_Modi")]
    partial class Modi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("IMS.CoreBusiness.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientId"), 1L, 1);

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreferredPaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            ClientId = 1,
                            ClientName = "John Doe",
                            ContactInfo = "1234 Park St, Douala",
                            PhoneNumber = "+237 612345678",
                            PreferredPaymentMethod = "Credit Card"
                        },
                        new
                        {
                            ClientId = 2,
                            ClientName = "Jane Smith",
                            ContactInfo = "5678 Garden Ave, Yaoundé",
                            PhoneNumber = "+237 623456789",
                            PreferredPaymentMethod = "Mobile Money"
                        },
                        new
                        {
                            ClientId = 3,
                            ClientName = "Robert Johnson",
                            ContactInfo = "9012 Park St, Bamenda",
                            PhoneNumber = "+237 634567890",
                            PreferredPaymentMethod = "Bank Transfer"
                        },
                        new
                        {
                            ClientId = 4,
                            ClientName = "Emily",
                            ContactInfo = "0123 City Hall, Buea",
                            PhoneNumber = "+237 645678901",
                            PreferredPaymentMethod = "Cash on Delivery"
                        },
                        new
                        {
                            ClientId = 5,
                            ClientName = "Michael Miller",
                            ContactInfo = "2390 Park St, Bafoussam",
                            PhoneNumber = "+237 656789012",
                            PreferredPaymentMethod = "PayPal"
                        });
                });

            modelBuilder.Entity("IMS.CoreBusiness.Equipment", b =>
                {
                    b.Property<int>("EquipmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EquipmentId"), 1L, 1);

                    b.Property<string>("EquipmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Marque")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerialNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EquipmentId");

                    b.ToTable("Equipments");

                    b.HasData(
                        new
                        {
                            EquipmentId = 1,
                            EquipmentName = "Presse Hydraulique à Injection",
                            IsActive = true,
                            Marque = "ELECTRONICA",
                            Model = "OP01000287",
                            SerialNo = "3117"
                        },
                        new
                        {
                            EquipmentId = 2,
                            EquipmentName = "Broyeuse",
                            IsActive = true,
                            Marque = "WENSUI",
                            Model = "WSGP-500",
                            SerialNo = "G112508"
                        },
                        new
                        {
                            EquipmentId = 3,
                            EquipmentName = "Excavator X1",
                            IsActive = true,
                            Marque = "Caterpillar",
                            Model = "336F",
                            SerialNo = "CAT336FC5EY00123"
                        },
                        new
                        {
                            EquipmentId = 4,
                            EquipmentName = "Bulldozer D5",
                            IsActive = true,
                            Marque = "Komatsu",
                            Model = "D85EX-18",
                            SerialNo = "KMT0D070J02012345"
                        },
                        new
                        {
                            EquipmentId = 5,
                            EquipmentName = "Wheel Loader",
                            IsActive = true,
                            Marque = "Volvo",
                            Model = "L220H",
                            SerialNo = "VCE0L220P00345678"
                        });
                });

            modelBuilder.Entity("IMS.CoreBusiness.Inventory", b =>
                {
                    b.Property<int>("InventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InventoryId"), 1L, 1);

                    b.Property<string>("InventoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("InventoryId");

                    b.ToTable("Inventories");

                    b.HasData(
                        new
                        {
                            InventoryId = 1,
                            InventoryName = "Gas Engine",
                            Price = 1000.0,
                            Quantity = 1
                        },
                        new
                        {
                            InventoryId = 2,
                            InventoryName = "Body",
                            Price = 400.0,
                            Quantity = 1
                        },
                        new
                        {
                            InventoryId = 3,
                            InventoryName = "Wheel",
                            Price = 100.0,
                            Quantity = 4
                        },
                        new
                        {
                            InventoryId = 4,
                            InventoryName = "Seat",
                            Price = 50.0,
                            Quantity = 5
                        },
                        new
                        {
                            InventoryId = 5,
                            InventoryName = "Electric Engine",
                            Price = 8000.0,
                            Quantity = 2
                        },
                        new
                        {
                            InventoryId = 6,
                            InventoryName = "Battery",
                            Price = 400.0,
                            Quantity = 5
                        });
                });

            modelBuilder.Entity("IMS.CoreBusiness.InventoryTransaction", b =>
                {
                    b.Property<int>("InventoryTransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InventoryTransactionId"), 1L, 1);

                    b.Property<int>("ActivityType")
                        .HasColumnType("int");

                    b.Property<string>("DoneBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InventoryId")
                        .HasColumnType("int");

                    b.Property<string>("PONumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductionNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PurchaseId")
                        .HasColumnType("int");

                    b.Property<int>("QuantityAfter")
                        .HasColumnType("int");

                    b.Property<int>("QuantityBefore")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.Property<double?>("UnitPrice")
                        .HasColumnType("float");

                    b.HasKey("InventoryTransactionId");

                    b.HasIndex("InventoryId");

                    b.HasIndex("PurchaseId");

                    b.ToTable("InventoryTransactions");
                });

            modelBuilder.Entity("IMS.CoreBusiness.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<bool>("Bought")
                        .HasColumnType("bit");

                    b.Property<bool>("CanBeProduced")
                        .HasColumnType("bit");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("Material")
                        .HasColumnType("bit");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("SellingPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Sold")
                        .HasColumnType("bit");

                    b.Property<int?>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Bought = false,
                            CanBeProduced = false,
                            IsActive = true,
                            Material = false,
                            Price = 20000.0,
                            ProductName = "Gas Car",
                            Quantity = 1,
                            SellingPrice = 0m,
                            Sold = false
                        },
                        new
                        {
                            ProductId = 2,
                            Bought = false,
                            CanBeProduced = false,
                            IsActive = true,
                            Material = false,
                            Price = 15000.0,
                            ProductName = "Electric Car",
                            Quantity = 1,
                            SellingPrice = 0m,
                            Sold = false
                        });
                });

            modelBuilder.Entity("IMS.CoreBusiness.ProductEquipment", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "EquipmentId");

                    b.HasIndex("EquipmentId");

                    b.ToTable("ProductEquipment");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            EquipmentId = 1
                        },
                        new
                        {
                            ProductId = 1,
                            EquipmentId = 2
                        },
                        new
                        {
                            ProductId = 1,
                            EquipmentId = 4
                        },
                        new
                        {
                            ProductId = 1,
                            EquipmentId = 5
                        },
                        new
                        {
                            ProductId = 2,
                            EquipmentId = 1
                        },
                        new
                        {
                            ProductId = 2,
                            EquipmentId = 2
                        },
                        new
                        {
                            ProductId = 2,
                            EquipmentId = 4
                        });
                });

            modelBuilder.Entity("IMS.CoreBusiness.ProductInventory", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("InventoryId")
                        .HasColumnType("int");

                    b.Property<int>("InventoryQuantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "InventoryId");

                    b.HasIndex("InventoryId");

                    b.ToTable("ProductInventory");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            InventoryId = 1,
                            InventoryQuantity = 1
                        },
                        new
                        {
                            ProductId = 1,
                            InventoryId = 2,
                            InventoryQuantity = 1
                        },
                        new
                        {
                            ProductId = 1,
                            InventoryId = 3,
                            InventoryQuantity = 4
                        },
                        new
                        {
                            ProductId = 1,
                            InventoryId = 4,
                            InventoryQuantity = 5
                        },
                        new
                        {
                            ProductId = 2,
                            InventoryId = 5,
                            InventoryQuantity = 1
                        },
                        new
                        {
                            ProductId = 2,
                            InventoryId = 2,
                            InventoryQuantity = 1
                        },
                        new
                        {
                            ProductId = 2,
                            InventoryId = 3,
                            InventoryQuantity = 4
                        },
                        new
                        {
                            ProductId = 2,
                            InventoryId = 4,
                            InventoryQuantity = 5
                        },
                        new
                        {
                            ProductId = 2,
                            InventoryId = 6,
                            InventoryQuantity = 1
                        });
                });

            modelBuilder.Entity("IMS.CoreBusiness.ProductTransaction", b =>
                {
                    b.Property<int>("ProductTransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductTransactionId"), 1L, 1);

                    b.Property<int>("ActivityType")
                        .HasColumnType("int");

                    b.Property<string>("DoneBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ProductionNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuantityAfter")
                        .HasColumnType("int");

                    b.Property<int>("QuantityBefore")
                        .HasColumnType("int");

                    b.Property<int>("SaleId")
                        .HasColumnType("int");

                    b.Property<string>("SalesOrderNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.Property<double?>("UnitPrice")
                        .HasColumnType("float");

                    b.HasKey("ProductTransactionId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SaleId");

                    b.ToTable("ProductTransactions");
                });

            modelBuilder.Entity("IMS.CoreBusiness.Purchase", b =>
                {
                    b.Property<int>("PurchaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PurchaseId"), 1L, 1);

                    b.Property<double>("AmountPaid")
                        .HasColumnType("float");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PurchaseId");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("IMS.CoreBusiness.Sale", b =>
                {
                    b.Property<int>("SaleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaleId"), 1L, 1);

                    b.Property<double>("AmountPaid")
                        .HasColumnType("float");

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SalesDate")
                        .HasColumnType("datetime2");

                    b.HasKey("SaleId");

                    b.HasIndex("ClientId");

                    b.ToTable("Sales");

                    b.HasData(
                        new
                        {
                            SaleId = 1,
                            AmountPaid = 20000.0,
                            ClientName = "John Doe",
                            SalesDate = new DateTime(2023, 9, 27, 14, 50, 12, 958, DateTimeKind.Local).AddTicks(3839)
                        },
                        new
                        {
                            SaleId = 2,
                            AmountPaid = 15000.0,
                            ClientName = "Emily",
                            SalesDate = new DateTime(2023, 9, 27, 14, 50, 12, 958, DateTimeKind.Local).AddTicks(3856)
                        });
                });

            modelBuilder.Entity("IMS.CoreBusiness.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupplierId"), 1L, 1);

                    b.Property<string>("ContactInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SupplierId");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new
                        {
                            SupplierId = 1,
                            ContactInfo = "123 Main St, Anytown",
                            Name = "Acme Corp"
                        },
                        new
                        {
                            SupplierId = 2,
                            ContactInfo = "456 Elm St, Othertown",
                            Name = "Globex Inc"
                        });
                });

            modelBuilder.Entity("IMS.CoreBusiness.InventoryTransaction", b =>
                {
                    b.HasOne("IMS.CoreBusiness.Inventory", "Inventory")
                        .WithMany()
                        .HasForeignKey("InventoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IMS.CoreBusiness.Purchase", "Purchase")
                        .WithMany("InventoryTransactions")
                        .HasForeignKey("PurchaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inventory");

                    b.Navigation("Purchase");
                });

            modelBuilder.Entity("IMS.CoreBusiness.Product", b =>
                {
                    b.HasOne("IMS.CoreBusiness.Supplier", null)
                        .WithMany("Purchases")
                        .HasForeignKey("SupplierId");
                });

            modelBuilder.Entity("IMS.CoreBusiness.ProductEquipment", b =>
                {
                    b.HasOne("IMS.CoreBusiness.Equipment", "Equipment")
                        .WithMany("ProductEquipments")
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IMS.CoreBusiness.Product", "Product")
                        .WithMany("ProductEquipments")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipment");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("IMS.CoreBusiness.ProductInventory", b =>
                {
                    b.HasOne("IMS.CoreBusiness.Inventory", "Inventory")
                        .WithMany("ProductInventories")
                        .HasForeignKey("InventoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IMS.CoreBusiness.Product", "Product")
                        .WithMany("ProductInventories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inventory");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("IMS.CoreBusiness.ProductTransaction", b =>
                {
                    b.HasOne("IMS.CoreBusiness.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IMS.CoreBusiness.Sale", "Sales")
                        .WithMany("ProductTransactions")
                        .HasForeignKey("SaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Sales");
                });

            modelBuilder.Entity("IMS.CoreBusiness.Sale", b =>
                {
                    b.HasOne("IMS.CoreBusiness.Client", null)
                        .WithMany("Sales")
                        .HasForeignKey("ClientId");
                });

            modelBuilder.Entity("IMS.CoreBusiness.Client", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("IMS.CoreBusiness.Equipment", b =>
                {
                    b.Navigation("ProductEquipments");
                });

            modelBuilder.Entity("IMS.CoreBusiness.Inventory", b =>
                {
                    b.Navigation("ProductInventories");
                });

            modelBuilder.Entity("IMS.CoreBusiness.Product", b =>
                {
                    b.Navigation("ProductEquipments");

                    b.Navigation("ProductInventories");
                });

            modelBuilder.Entity("IMS.CoreBusiness.Purchase", b =>
                {
                    b.Navigation("InventoryTransactions");
                });

            modelBuilder.Entity("IMS.CoreBusiness.Sale", b =>
                {
                    b.Navigation("ProductTransactions");
                });

            modelBuilder.Entity("IMS.CoreBusiness.Supplier", b =>
                {
                    b.Navigation("Purchases");
                });
#pragma warning restore 612, 618
        }
    }
}