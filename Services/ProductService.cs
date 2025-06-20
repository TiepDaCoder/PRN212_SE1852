using BusinessObjects;
using Repository;

namespace Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository iProductRepository;
        public ProductService()
        {
            iProductRepository = new ProductRepository();
        }
        public List<Product> GetAllProducts()
        {
            return iProductRepository.GetAllProducts();
        }

        public void InitializeDataset()
        {
            iProductRepository.InitializeDataset();
        }

        public bool SaveProduct(Product p)
        {
            return iProductRepository.SaveProduct(p);
        }
    }
}
