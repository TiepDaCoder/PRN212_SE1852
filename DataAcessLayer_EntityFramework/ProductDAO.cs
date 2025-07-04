using BusinessObjects_EntityFramework;

namespace DataAccessLayer_EntityFramework
{
    public class ProductDAO
    {
        MyStoreContext context = new MyStoreContext();
        public List<Product> GetProducts()
        {
            return context.Products.ToList();
        }
        public List<Product> GetProductsByCategory(int cateid)
        {
            return context.Products
                          .Where(p => p.CategoryId == cateid)
                          .ToList();
        }
    }
}