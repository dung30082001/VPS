
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AccountDAO
    {
        public static List<Account> GetAccount()
        {
            var listProducts = new List<Account>();
            try
            {
                using (var context = new VPSContext())
                {
                    listProducts = context.Accounts.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listProducts;
        }
    }
}
