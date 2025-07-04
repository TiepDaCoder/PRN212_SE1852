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
        public List<Product> GetProducts()
        {
            return repository.GetProducts();
        }

        public List<Product> GetProductsByCategory(int cateid)
        {
            return repository.GetProductsByCategory(cateid);
        }
    }
}