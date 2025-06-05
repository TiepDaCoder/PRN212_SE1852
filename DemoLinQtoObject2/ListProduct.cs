namespace DemoLinQtoObject2
{
    public class ListProduct
    {
        List<Product> products;
        public ListProduct()
        {
            products = new List<Product>();
        }
        public void gen_sample_products()
        {
            products.Add(new Product() { Id = 1, Name = "P1", Price = 10, Quantity = 100 });
            products.Add(new Product() { Id = 2, Name = "P2", Price = 20, Quantity = 300 });
            products.Add(new Product() { Id = 3, Name = "P3", Price = 260, Quantity = 200 });
            products.Add(new Product() { Id = 4, Name = "P4", Price = 7, Quantity = 150 });
            products.Add(new Product() { Id = 5, Name = "P5", Price = 20, Quantity = 80 });
            products.Add(new Product() { Id = 6, Name = "P6", Price = 280, Quantity = 60 });
            products.Add(new Product() { Id = 7, Name = "P7", Price = 25, Quantity = 40 });
            products.Add(new Product() { Id = 8, Name = "P8", Price = 98, Quantity = 50 });
            products.Add(new Product() { Id = 9, Name = "P9", Price = 87, Quantity = 30 });
            products.Add(new Product() { Id = 10, Name = "P10", Price = 100, Quantity = 10 });
        }
        public void PrintProducts()
        {
            products.ForEach(p => Console.WriteLine(p));
        }
        public void FilterProductsByPrice(double price1, double price2)
        {
            var results = products.Where(p => p.Price >= price1 && p.Price <= price2).ToList();
            results.ToList().ForEach(p => Console.WriteLine(p));
        }
        public void FilterProductsByPriceDesc(double price1, double price2)
        {
            var results = from p in products where p.Price >= price1 && p.Price <= price2 orderby p.Price descending select p;
            results.ToList().ForEach(p => Console.WriteLine(p));
        }
        public void FilterProductsByQuantity(int q1, int q2)
        {
            var results = from p in products where p.Quantity >= q1 && p.Quantity <= q2 select new { p.Id, p.Name };
            foreach (var item in results) Console.WriteLine(item.Id + "\t" + item.Name);
        }
    }
}
