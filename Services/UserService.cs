using BusinessObjects;
using Repository;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository iUserRepository;
        public UserService()
        {
            iUserRepository = new UserRepository();
        }
        public List<User> GetAllUsers()
        {
            return iUserRepository.GetAllUsers();
        }
    }
}
