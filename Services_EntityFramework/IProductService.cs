using BusinessObjects_EntityFramework;

namespace Services_EntityFramework
{
    public interface IProductService
    {
        public List<Product> GetProducts();
        public List<Product> GetProductsByCategory(int cateid);
    }
}
