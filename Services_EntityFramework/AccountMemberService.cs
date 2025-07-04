using BusinessObjects_EntityFramework;
using Repositories_EntityFramework;

namespace Services_EntityFramework
{
    public class AccountMemberService : IAccountMemberService
    {
        IAccountMemberRepository accountMemberRepository;
        public AccountMemberService()
        {
            accountMemberRepository = new AccountMemberRepository();
        }
        public AccountMember Login(string email, string password)
        {
            return accountMemberRepository.Login(email, password);
        }
    }
}
