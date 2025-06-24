using BusinessObjects;

namespace Repository
{
    public interface IProductRepository
    {
        public List<Product> GetAllProducts();
        public void InitializeDataset();
        public bool SaveProduct(Product p);
        public bool UpdateProduct(Product p);
        public bool DeleteProduct(Product p);
    }
}
