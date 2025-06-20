using BusinessObjects;

namespace Services
{
    public interface IProductService
    {
        public List<Product> GetAllProducts();
        public void InitializeDataset();
        public bool SaveProduct(Product p);
    }
}
