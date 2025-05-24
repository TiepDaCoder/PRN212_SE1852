using System.Text;
using OOP;

Category c1=new Category();
c1.Id = 1;
c1.Name = "Nước mắm";
Console.OutputEncoding=Encoding.UTF8;
c1.PrintInfor();

Employee emp1 = new Employee();
/*emp1._id = 1;
emp1._name = "Tèo";*/
//Để thay đổi giá trị của thuộc tính
//Tự gọi set cho các property
emp1.Id = 1;
emp1.Name = "Tèo";
emp1.Phone = "113";
emp1.Email = "teo@gmail.com";

//Để lấy giá trị của thuộc tính
//Tự gọi get cho các property
Console.WriteLine($"Employee ID={emp1.Id}");
Console.WriteLine($"Employee Name={emp1.Name}");
Console.WriteLine($"Employee Phone={emp1.Phone}");
Console.WriteLine($"Employee Email={emp1.Email}");
//Gọi hàm
emp1.PrintInfor();

//Ngoài ra mọi lớp đối tượng có hàm toString() giống Java
//để tự động triệu gọi hàm này khi đối tượng được xuất ra màn hình
Console.WriteLine("-----------------------------------------------");
Console.WriteLine(emp1);

//Vừa tạo đối tượng vừa khởi tạo giá trị cho thuộc tính
Employee employee2 = new Employee(2,"Tý","ty@yahoo.com","0909943586");
employee2.PrintInfor();
//Hoặc
Employee employee3 = new Employee()
{
    Id = 3,
    Name = "Tôn",
    Email = "ton@gmail.com",
    Phone = "12345678"
};
Console.WriteLine(employee3);