using BusinessObjects_EntityFramework;
using Repositories_EntityFramework;

namespace Services_EntityFramework
{
    public class ProductService : IProductService
    {
        IProductRepository repository;
        public ProductService()
        {
            repository = new ProductRepository();
        }

        public bool DeleteProduct(int productId)
        {
            return repository.DeleteProduct(productId);
        }

        public List<Product> GetProducts()
        {
            return repository.GetProducts();
        }

        public List<Product> GetProductsByCategory(int cateid)
        {
            return repository.GetProductsByCategory(cateid);
        }

        public bool SaveProduct(Product product)
        {
            return repository.SaveProduct(product);
        }

        public bool UpdateProduct(Product product)
        {
            return repository.UpdateProduct(product);
        }
    }
}