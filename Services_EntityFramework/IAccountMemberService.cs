using BusinessObjects_EntityFramework;

namespace Services_EntityFramework
{
    public interface IAccountMemberService
    {
        public AccountMember Login(string email, string password);
    }
}
