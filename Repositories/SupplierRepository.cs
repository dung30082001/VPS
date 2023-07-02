using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        public void AddSupplier(Supplier supplier)
        {
            SupplierDAO.AddSupplier(supplier);
        }

        public void DeleteSupplier(int id)
        {
            SupplierDAO.DeleteSupplier(id);
        }

        public List<Supplier> GetSupplier()
        {
            return SupplierDAO.GetSupplier();
        }

        public Supplier GetSupplierbyId(int id)
        {
            return SupplierDAO.GetSupplierById(id);
        }

        public void UpdateSupplier(int id, Supplier supplier)
        {
            SupplierDAO.UpdateSupplier(id, supplier);
        }
    }
}
