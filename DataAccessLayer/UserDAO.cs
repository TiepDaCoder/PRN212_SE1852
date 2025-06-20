using BusinessObjects;
namespace DataAccessLayer
{
    public class UserDAO
    {
        static List<User> users = new List<User>();
        public void InitializeDataset()
        {
            users.Add(new User() { Name = "Tèo", Phone = "0123456789", Email = "teo@gmail.com" });
            users.Add(new User() { Name = "Tý", Phone = "0322314567", Email = "ty@gmail.com" });
            users.Add(new User() { Name = "Bin", Phone = "032156657", Email = "bin@gmail.com" });
            users.Add(new User() { Name = "Bo", Phone = "0675894356", Email = "bo@gmail.com" });
            users.Add(new User() { Name = "Bẹo", Phone = "0753853632", Email = "beo@gmail.com" });
        }
        public List<User> GetAllUsers()
        {
            return users;
        }
    }
}
