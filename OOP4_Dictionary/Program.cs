using System.Text;
using OOP4_Dictionary;
Console.OutputEncoding = Encoding.UTF8;

Category laptop = new Category();
laptop.Id = 1;
laptop.Name = "Danh muc Laptop";

Product dell1 = new Product()
{
    Id = 1,
    Name = "Dell1",
    Quantity = 8,
    Price = 10000000
};
Product dell2 = new Product()
{
    Id = 2,
    Name = "dell2",
    Quantity = 20,
    Price = 15000000
};
Product HP1 = new Product()
{
    Id = 3,
    Name = "HP1",
    Quantity = 10,
    Price = 8000000
};
Product HP2 = new Product()
{
    Id = 4,
    Name = "HP2",
    Quantity = 15,
    Price = 8000000
};
laptop.AddProduct(dell1);
laptop.AddProduct(dell2);
laptop.AddProduct(HP1);
laptop.AddProduct(HP2);

Console.WriteLine("Danh sách sản phẩm của danh mục laptop");
laptop.PrintAllProduct();

Console.WriteLine("Mời bạn nhập vào mã sản phẩm muốn tìm:");
int pId = int.Parse(Console.ReadLine());
Product p = laptop.GetProduct(pId);
if (p == null)
{
    Console.WriteLine("Không tìm thấy sản phẩm có mã = " + pId);
}
else
{
    Console.WriteLine("Đã tìm thấy sản phẩm có mã = " + pId);
    Console.WriteLine(p);
}

Console.WriteLine("Danh sách chưa sắp xếp:");
laptop.PrintAllProduct();
Dictionary<int, Product> sortedProducts = laptop.ComplexSort();
Console.WriteLine("Danh sách sau khi sắp xếp:");
foreach (KeyValuePair<int, Product> item in sortedProducts)
{
    Product x = item.Value;
    Console.WriteLine(x);
}

Product px = new Product();
px.Id = 1;
px.Name = "MAC BOOK 1000";
px.Quantity = 80;
px.Price = 500;
laptop.EditProduct(px);
Console.WriteLine("---Danh sách sản phẩm sau khi sửa---");
laptop.PrintAllProduct();

int pId_Remove = 1;
laptop.RemoveProduct(pId_Remove);
Console.WriteLine("---Danh sách sản phẩm sau khi xoá---");
laptop.PrintAllProduct();