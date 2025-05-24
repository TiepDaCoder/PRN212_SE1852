using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Employee
    {
        #region Nhóm các thuộc tính của employee
        private int id;
        private string name;
        private string email;
        private string phone;
        #endregion
        #region Nhóm các constructor của employee
        public Employee()
        {

        }
        public Employee( int id, string name, string email, string phone)
        {
            this.id = id;
            this.name = name;
            //hoặc gọi setter cho property
            Email = email;
            Phone = phone;
        }
        #endregion
        #region Nhóm các properties của employee
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        #endregion
        #region Nhóm các phương thức của employee
        public void PrintInfor()
        {
            Console.WriteLine($"{id}\t{name}\t{email}\t{phone}");
        }

        public override string ToString()
        {
            string msg = $"{id}\t{name}\t{email}\t{phone}";
            return msg;
        }
        #endregion
    }
}
