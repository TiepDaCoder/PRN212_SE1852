using System.Text;
using LucyDemoLINQ2SQL;

Console.OutputEncoding = Encoding.UTF8;
string connectionString = "server=LAPTOP-K7C91U87\\MSSQLSERVER02;database=Lucy_SalesData;uid=sa;pwd=12345";
Lucy_SalesDataDataContext context = new Lucy_SalesDataDataContext(connectionString);
//Câu 1: Xuất danh sách khách hàng có mua hàng
var ds1 = from c in context.Customers where c.Orders.Count() > 0 select c;
Console.WriteLine("Danh sách khách hàng có mua hàng:");
foreach (var c in ds1)
{
    Console.WriteLine(c.CustomerID + "\t" + c.ContactName);
}
//Câu 2: Lọc ra 3 khách hàng mua hàng nhiều nhất cho Công ty
//Từ đó để ra chính sách nâng khách hàng VIP
var ds2 = (from c in context.Customers
           let soLuongDonHang = c.Orders.Count()
           orderby soLuongDonHang descending
           select new
           {
               CustomerID = c.CustomerID,
               ContactName = c.ContactName,
               SoLuongDonHang = soLuongDonHang
           }).Take(3);

Console.WriteLine("\nTop 3 khách hàng mua hàng nhiều nhất:");
foreach (var c in ds2)
{
    Console.WriteLine($"{c.CustomerID}\t{c.ContactName}\tSố đơn: {c.SoLuongDonHang}");
}
Console.WriteLine("Mẫu");
var ds3 = (from c in context.Customers
           join o in context.Orders on c.CustomerID equals o.CustomerID
           join od in context.Order_Details on o.OrderID equals od.OrderID
           group od by new { c.CustomerID, c.ContactName } into g
           select new
           {
               CustomerID = g.Key.CustomerID,
               ContactName = g.Key.ContactName,
               TotalAmount = g.Sum(x => x.UnitPrice * x.Quantity)
           }).OrderByDescending(x => x.TotalAmount)
             .Take(3);

foreach (var item in ds3)
{
    Console.WriteLine(item.CustomerID + "\t" + item.ContactName + "\t" + item.TotalAmount);
}