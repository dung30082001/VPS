using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class SupplierProductRepository : ISupplierProductRepository
    {
        public void AddSupplierProduct(SupplierProduct supplierProduct)
        {
            SupplierProductDAO.AddSupplierProduct(supplierProduct);
        }

        public void DeleteSupplierProduct(int id)
        {
            SupplierProductDAO.DeleteSupplierProduct(id);
        }

        public List<SupplierProduct> GetSupplierProduct()
        {
            return SupplierProductDAO.GetSupplierProduct();
        }

        public SupplierProduct GetSupplierProductbyId(int id)
        {
            return SupplierProductDAO.GetSupplierProductById(id);
        }

        public void UpdateSupplierProduct(int id, SupplierProduct supplierProduct)
        {
            SupplierProductDAO.UpdateSupplierProduct(id, supplierProduct);
        }
    }
}
