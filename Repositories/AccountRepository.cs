using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public void AddAccount(Account account)
        {
            AccountDAO.AddAccount(account);
        }

        public void DeleteAccount(int id)
        {
            AccountDAO.DeleteAccount(id);
        }

        public List<Account> GetAccount()
        {
            return AccountDAO.GetAccount();
        }

        public Account GetAccountById(int id)
        {
            return AccountDAO.GetAccountById(id);
        }

        public List<Account> GetAccountEmployee()
        {
            return AccountDAO.GetAccountEmployee();
        }

        public int GetTotalAccount()
        {
            return AccountDAO.GetTotalAccount();
        }

        public void UpdateAccount(int id, Account account)
        {
             AccountDAO.UpdateAccount(id, account);
        }
    }
}
