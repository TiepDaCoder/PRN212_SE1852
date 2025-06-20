using BusinessObjects;
using DataAccessLayer;

namespace Repository
{
    public class UserRepository : IUserRepository
    {
        public List<User> GetAllUsers()
        {
            UserDAO userDAO = new UserDAO();
            userDAO.InitializeDataset();
            return userDAO.GetAllUsers();
        }
    }
}
