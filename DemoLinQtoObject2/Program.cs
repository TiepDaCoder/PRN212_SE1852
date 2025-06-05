using System.Text;
using DemoLinQtoObject2;

Console.OutputEncoding = Encoding.UTF8;
ListProduct lp = new ListProduct();
//Giả lập dữ liệu
lp.gen_sample_products();
Console.WriteLine("Danh sách Products: ");
lp.PrintProducts();
Console.WriteLine("Danh sách các sản phẩm có giá trị từ 80 tới 100: ");
lp.FilterProductsByPrice(80, 100);
Console.WriteLine("Danh sách các sản phẩm có giá trị từ 200 tới 300 và sắp xếp: ");
lp.FilterProductsByPriceDesc(200, 300);