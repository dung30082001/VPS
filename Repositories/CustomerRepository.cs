using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public void AddCustomert(Customer cus)
        {
            CustomerDAO.AddCus(cus);
        }

        public void DeleteCustomer(int id)
        {
            CustomerDAO.DeleteCus(id);
        }

        public List<Customer> GetCustomer()
        {
            return CustomerDAO.GetCustomer();
        }

        public Customer GetCustomerById(int id)
        {
           return CustomerDAO.GetCustomerById(id);
        }

        public int GetTotalCustomer()
        {
            return CustomerDAO.GetTotalCus();
        }

        public void UpdateCustomer(int id, Customer cus)
        {
            CustomerDAO.UpdateCus(id, cus);
        }
    }
}
