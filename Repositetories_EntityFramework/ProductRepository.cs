using BusinessObjects_EntityFramework;
using DataAccessLayer_EntityFramework;

namespace Repositories_EntityFramework
{
    public class ProductRepository : IProductRepository
    {
        ProductDAO productDAO = new ProductDAO();

        public bool DeleteProduct(int productId)
        {
            return productDAO.DeleteProduct(productId);
        }

        public List<Product> GetProducts()
        {
            return productDAO.GetProducts();
        }

        public List<Product> GetProductsByCategory(int cateid)
        {
            return productDAO.GetProductsByCategory(cateid);
        }

        public bool SaveProduct(Product product)
        {
            return productDAO.SaveProduct(product);
        }

        public bool UpdateProduct(Product product)
        {
            return productDAO.UpdateProduct(product);
        }
    }
}