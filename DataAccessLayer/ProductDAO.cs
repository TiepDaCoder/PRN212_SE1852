using BusinessObjects;
namespace DataAccessLayer
{
    public class ProductDAO
    {
        static List<Product> products = new List<Product>();
        public void InitializeDataset()
        {
            products.Add(new Product() { Id = 1, Name = "Lamborghini", Quantity = 10, Price = 100.0 });
            products.Add(new Product() { Id = 2, Name = "Nissan", Quantity = 20, Price = 200.0 });
            products.Add(new Product() { Id = 3, Name = "Ferrari", Quantity = 30, Price = 300.0 });
            products.Add(new Product() { Id = 4, Name = "Porsche", Quantity = 40, Price = 400.0 });
            products.Add(new Product() { Id = 5, Name = "Tesla", Quantity = 50, Price = 500.0 });
        }
        public List<Product> GetAllProducts()
        {
            return products;
        }
        public bool SaveProduct(Product p)
        {
            Product old = products.FirstOrDefault(x => x.Id == p.Id);
            if (old != null)
            {
                return false;
            }
            products.Add(p);
            return true;
        }
    }
}
