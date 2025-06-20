using BusinessObjects;
using DataAccessLayer;

namespace Repository
{
    public class ProductRepository : IProductRepository
    {
        ProductDAO productDAO = new ProductDAO();
        public List<Product> GetAllProducts()
        {
            return productDAO.GetAllProducts();
        }

        public void InitializeDataset()
        {
            productDAO.InitializeDataset();
        }

        public bool SaveProduct(Product p)
        {
            return productDAO.SaveProduct(p);
        }
    }
}
