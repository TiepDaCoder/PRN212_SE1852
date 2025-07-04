using BusinessObjects_EntityFramework;

namespace Repositories_EntityFramework
{
    public interface IProductRepository
    {
        public List<Product> GetProducts();
        public List<Product> GetProductsByCategory(int cateid);
    }
}