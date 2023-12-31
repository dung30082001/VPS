﻿using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICustomerRepository
    {
        List<Customer> GetCustomer();

        List<Customer> Get8Customer();

        Customer GetCustomerById(int id);

        int GetTotalCustomer();

        void UpdateCustomer(int id, Customer cus);

        void AddCustomert(Customer cus);

        void DeleteCustomer(int id);
    }
}
