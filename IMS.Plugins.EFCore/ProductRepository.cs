﻿using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;
using Microsoft.EntityFrameworkCore;


namespace IMS.Plugins.EFCore
{
    public class ProductRepository : IProductRepository
    {
        private readonly IMSContext db;

        public ProductRepository(IMSContext db)
        {
            this.db = db;
        }

        public async Task AddProductAsync(Product product)
        {
            if (db.Products.Any(x => x.ProductName.ToLower() == product.ProductName.ToLower())) return;
            db.Products.Add(product);
            await db.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(int productId)
        {
            var product = await db.Products.FindAsync(productId);
            if (product != null)
            {
                db.Products.Remove(product);
                await db.SaveChangesAsync();
            }
        }


        public async Task<Product> GetProductByIdAsync(int productId)
        {
            return await db.Products.Include(x => x.ProductInventories)
                .ThenInclude(x => x.Inventory)
                .FirstOrDefaultAsync(x => x.ProductId == productId);
        }

        public async Task<List<Product>> GetProductsByNameAsync(string name)
        {
            return await db.Products.Where(x =>
                x.ProductName.ToLower().IndexOf(name.ToLower()) >= 0 ||
                string.IsNullOrWhiteSpace(name) && x.IsActive == true && x.Sold == true).ToListAsync();
        }

        public async Task UpdateProductAsync(Product product)
        {
            var prod = await db.Products.FindAsync(product.ProductId);
            if (prod != null)
            {
                prod.ProductName = product.ProductName;
                prod.Price = product.Price;
                prod.Quantity = product.Quantity;
                prod.ProductInventories = product.ProductInventories;

                await db.SaveChangesAsync();
            }
        }
    }
}