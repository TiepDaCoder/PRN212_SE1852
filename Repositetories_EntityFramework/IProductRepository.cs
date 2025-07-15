using BusinessObjects_EntityFramework;

namespace Repositories_EntityFramework
{
    public interface IProductRepository
    {
        public List<Product> GetProducts();
        public List<Product> GetProductsByCategory(int cateid);
        public bool SaveProduct(Product product);
        public bool UpdateProduct(Product product);
        public bool DeleteProduct(int productId);
    }
}