using IMS.CoreBusiness;
using IMS.UseCases.Interfaces;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases.Activities
{
    public class SellProductUseCase : ISellProductUseCase
    {
        private readonly IProductTransactionRepository _productTransactionRepository;
        private readonly IProductRepository _productRepository;

        public SellProductUseCase(
            IProductTransactionRepository productTransactionRepository,
            IProductRepository productRepository
        )
        {
            _productTransactionRepository = productTransactionRepository;
            _productRepository = productRepository;
        }

        public async Task ExecuteAsync(int salesId, string salesOrderNumber, Product product, int quantity,
            string doneBy)
        {
            await _productTransactionRepository.SellProductAsync(salesId, salesOrderNumber, product, quantity,
                product.Price, doneBy);

            product.Quantity -= quantity;
            await _productRepository.UpdateProductAsync(product);
        }
    }
}