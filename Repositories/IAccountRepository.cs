using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IAccountRepository
    {
        List<Account> GetAccount();

        List<Account> GetAccountEmployee();

        Account GetAccountById(int id);

        int GetTotalAccount();

        void UpdateAccount(int id, Account account);

        void AddAccount(Account account);

        void DeleteAccount(int id);
    }
}
