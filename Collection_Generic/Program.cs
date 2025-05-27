/*
 * Ứng dụng Generic để quản lý nhân viên, thực hiện các thao tác CRUD
 * C - Create
 * R - Read
 * U - Update
 * D - Delete
 */

//Câu 1: Tạo 5 nhân viên, 4 fulltime, 1 parttime
using System.Text;
using OOP2;

List<Employee> employees = new List<Employee>();
FulltimeEmployee fe1 = new FulltimeEmployee()
{
    Id = 1,
    Name = "Name1",
    IdCard = "123",
    Birthday = new DateTime(1950, 12, 2)
};
employees.Add(fe1);
FulltimeEmployee fe2 = new FulltimeEmployee()
{
    Id = 2,
    Name = "Name2",
    IdCard = "456",
    Birthday = new DateTime(1980, 12, 2)
};
employees.Add(fe2);
FulltimeEmployee fe3 = new FulltimeEmployee()
{
    Id = 3,
    Name = "Name3",
    IdCard = "789",
    Birthday = new DateTime(1930, 12, 2)
};
employees.Add(fe3);
FulltimeEmployee fe4 = new FulltimeEmployee()
{
    Id = 4,
    Name = "Name4",
    IdCard = "212",
    Birthday = new DateTime(1923, 12, 2)
};
employees.Add(fe4);

ParttimeEmployee pe1 = new ParttimeEmployee()
{
    Id = 5,
    Name = "Name5",
    IdCard = "323",
    Birthday = new DateTime(2000, 12, 2)
};
employees.Add(pe1);

//Câu 2: Xuất toàn bộ thông tin nhân sự (R)
Console.OutputEncoding =  Encoding.UTF8;
//Cách 1: Dùng Expression body (Lambda Expression)
employees.ForEach(e => Console.WriteLine(e));
//Cách 2: Dùng for thông thường
Console.WriteLine("Dùng for thông thường: ");
foreach (var e in employees)
{
    Console.WriteLine(e);
}

//Câu 3: Sắp xếp nhân viên theo năm sinh giảm dần (R)
for (int i = 0; i < employees.Count; i++)
{
    for (int j = i+1; j < employees.Count; j++)
    {
        Employee ei = employees[i];
        Employee ej = employees[j];
        if (ei.Birthday < ej.Birthday)
        {
            employees[i] = ej;
            employees[j] = ei;
        }
    }
}
Console.WriteLine("Employees sau khi sắp xếp năm sinh giảm dần:");
employees.ForEach((e) => Console.WriteLine(e));

//Câu 4: Cập nhật thông tin nhân viên: Tên, IdCard, Birthday (U)
Console.WriteLine("=====Cập nhật thông tin nhân viên=====");
fe3.UpdateInfo("Nguyễn New Name", "999999", new DateTime(1995, 5, 5));
Console.WriteLine("Đã cập nhật nhân viên:");
Console.WriteLine(fe3);

//Câu 5: Xoá nhân viên (D)
Console.WriteLine("=====Xoá thông tin nhân viên=====");
employees.Remove(fe2);
Console.WriteLine("Employees sau khi xoá:");
employees.ForEach((e) => Console.WriteLine(e));