
using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
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
        public static List<Account> GetAccountEmployee()
        {
            var listProducts = new List<Account>();
            try
            {
                using (var context = new VPSContext())
                {
                    listProducts = context.Accounts.Where(x => x.RoleId != 4).Include(y => y.Role).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listProducts;
        }
        public static Account GetAccountById(int id)
        {
            var account = new Account();
            try
            {
                using (var context = new VPSContext())
                {
                    account = context.Accounts.Find(id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return account;
        }
        public static int GetTotalAccount()
        {
            int finalAccount;
            var listA = new List<Account>();
            try
            {
                using (var context = new VPSContext())
                {
                    listA = context.Accounts.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finalAccount = listA.Count;
            return finalAccount;
        }
        public static void UpdateAccount(int id, Account account)
        {
            Account current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Accounts.Find(id);
                    current.UserName = account.UserName;
                    current.Password = account.Password;
                    current.Email = account.Email;
                    current.Avatar = account.Avatar;
                    current.Status = account.Status;
                    current.Profile = account.Profile;
                    current.RoleId = account.RoleId;
                    current.BloggerId = account.BloggerId;
                    current.ConsultantId = account.ConsultantId;
                    current.CustomerId = account.CustomerId;
                    current.ManagerId = account.ManagerId;
                    current.SupplierId = account.SupplierId;
                    current.TechnicalId = account.TechnicalId;
                    current.AdminId = account.AdminId;
                    current.SaleId = account.SaleId;
                    current.ShipperId = account.ShipperId;
                    current.CreatedDate = account.CreatedDate;
                    context.Accounts.Update(current);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void AddAccount(Account account)
        {
            Account current;
            try
            {
                using (var context = new VPSContext())
                {
                    context.Accounts.Add(account);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void DeleteAccount(int id)
        {
            Account current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Accounts.Find(id);
                    context.Accounts.Remove(current);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
