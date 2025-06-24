namespace TreeViewWpfApp.models
{
    public class SampleDataset
    {
        public static Dictionary<int, Category> GenerateDataset()
        {
            Dictionary<int, Category> categories = new Dictionary<int, Category>();
            Category c1 = new Category { Id = 1, Name = "Electronics" };
            Category c2 = new Category { Id = 2, Name = "Books" };
            Category c3 = new Category { Id = 3, Name = "Clothing" };

            categories.Add(c1.Id, c1);
            categories.Add(c2.Id, c2);
            categories.Add(c3.Id, c3);

            Product p1 = new Product { Id = 1, Name = "Laptop", Quantity = 10, Price = 999.99 };
            Product p2 = new Product { Id = 2, Name = "Smartphone", Quantity = 20, Price = 499.99 };
            Product p3 = new Product { Id = 3, Name = "TV", Quantity = 50, Price = 19.99 };
            Product p4 = new Product { Id = 4, Name = "Speaker", Quantity = 100, Price = 9.99 };
            Product p5 = new Product { Id = 5, Name = "Fan", Quantity = 200, Price = 19.99 };
            c1.Products.Add(p1.Id, p1);
            c1.Products.Add(p2.Id, p2);
            c1.Products.Add(p3.Id, p3);
            c1.Products.Add(p4.Id, p4);
            c1.Products.Add(p5.Id, p5);

            Product p6 = new Product { Id = 6, Name = "Book1", Quantity = 100, Price = 19.99 };
            Product p7 = new Product { Id = 7, Name = "Book2", Quantity = 200, Price = 29.99 };
            Product p8 = new Product { Id = 8, Name = "Book3", Quantity = 300, Price = 39.99 };
            Product p9 = new Product { Id = 9, Name = "Book4", Quantity = 400, Price = 49.99 };
            Product p10 = new Product { Id = 10, Name = "Book5", Quantity = 100, Price = 19.99 };
            c2.Products.Add(p6.Id, p6);
            c2.Products.Add(p7.Id, p7);
            c2.Products.Add(p8.Id, p8);
            c2.Products.Add(p9.Id, p9);
            c2.Products.Add(p10.Id, p10);

            Product p11 = new Product { Id = 11, Name = "Shirt", Quantity = 100, Price = 19.99 };
            Product p12 = new Product { Id = 12, Name = "Pants", Quantity = 200, Price = 29.99 };
            Product p13 = new Product { Id = 13, Name = "Jacket", Quantity = 300, Price = 39.99 };
            Product p14 = new Product { Id = 14, Name = "Shoes", Quantity = 400, Price = 49.99 };
            Product p15 = new Product { Id = 15, Name = "Hat", Quantity = 100, Price = 19.99 };
            c3.Products.Add(p11.Id, p11);
            c3.Products.Add(p12.Id, p12);
            c3.Products.Add(p13.Id, p13);
            c3.Products.Add(p14.Id, p14);
            c3.Products.Add(p15.Id, p15);

            return categories;
        }
    }
}
