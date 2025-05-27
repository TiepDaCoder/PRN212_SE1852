using OOP2;
using OOP2_Reuse_as_library;

FulltimeEmployee e1 = new FulltimeEmployee();
e1.Id = 1;
e1.Name = "Tiep";
e1.Birthday = new DateTime(2005, 12, 13);
Console.WriteLine(e1);
Console.WriteLine("AGE====> "+e1.TinhTuoi());