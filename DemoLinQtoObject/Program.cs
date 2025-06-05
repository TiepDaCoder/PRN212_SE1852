using System.Text;

Console.OutputEncoding = Encoding.UTF8;

/*
 * Dùng LINQ2OBJECT để xuất các số chẵn trong danh sách
 */

int[] arr = { 100, 35, 12, 50, 1, 42, 15, 7 };
//Cách 1: Dùng Method Syntax (Extention method)
var even_list = arr.Where(x => x % 2 == 0);
Console.WriteLine("Danh sách các số chẵn theo Method Syntax: ");
foreach (var x in even_list) Console.Write(x + "\t");

//Cách 2: DÙng Query Syntax (cú pháp tương tự SQL)
var even_list2 = from x in arr where x % 2 == 0 select x;
Console.WriteLine("\nDanh sách các số chẵn theo Query Syntax:");
foreach (var x in even_list2) Console.Write(x + "\t");

//Sắp xếp mảng tăng dần và giảm dần dùng Method và Query syntax
//Dùng method:
var list_asc = arr.OrderBy(x => x);
var list_desc2 = arr.OrderByDescending(x => x);
//Dùng query:
var list_asc2 = from x in arr orderby x select x;
var list_desc = from x in arr orderby x descending select x;

//Tính tổng danh sách:
Console.WriteLine("Tổng = " + arr.Sum());
Console.WriteLine("Đếm số chẵn = " + arr.Where(x => x % 2 == 0).Count());