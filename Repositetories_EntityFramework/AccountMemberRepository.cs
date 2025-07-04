using BusinessObjects_EntityFramework;
using DataAccessLayer_EntityFramework;

namespace Repositories_EntityFramework
{
    public class AccountMemberRepository : IAccountMemberRepository
    {
        AccountMemberDAO accountMemberDAO = new AccountMemberDAO();
        public AccountMember Login(string email, string password)
        {
            return accountMemberDAO.Login(email, password);
        }
    }
}