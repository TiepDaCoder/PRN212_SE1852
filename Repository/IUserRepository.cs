using BusinessObjects;
namespace Repository
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
    }
}
