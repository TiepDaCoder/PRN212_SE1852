using BusinessObjects_EntityFramework;
using DataAccessLayer_EntityFramework;

namespace Repositories_EntityFramework
{
    public class ProductRepository : IProductRepository
    {
        ProductDAO productDAO = new ProductDAO();
        public List<Product> GetProducts()
        {
            return productDAO.GetProducts();
        }

        public List<Product> GetProductsByCategory(int cateid)
        {
            return productDAO.GetProductsByCategory(cateid);
        }
    }
}
