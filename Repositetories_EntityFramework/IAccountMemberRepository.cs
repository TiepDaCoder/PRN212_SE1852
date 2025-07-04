using BusinessObjects_EntityFramework;

namespace Repositories_EntityFramework
{
    public interface IAccountMemberRepository
    {
        public AccountMember Login(string email, string password);
    }
}