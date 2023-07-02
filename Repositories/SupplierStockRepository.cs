using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class SupplierStockRepository : ISupplierStockRepository
    {
        public void AddSupplierStock(SupplierStock supplierStock)
        {
            SupplierStockDAO.AddSupplierStock(supplierStock);
        }

        public void DeleteSupplierStock(int id)
        {
            SupplierStockDAO.DeleteSupplierStock(id);
        }

        public List<SupplierStock> GetSupplierStock()
        {
            return SupplierStockDAO.GetSupplierStock();
        }

        public SupplierStock GetSupplierStockbyId(int id)
        {
            return SupplierStockDAO.GetSupplierStockById(id);
        }

        public void UpdateSupplierStaock(int id, SupplierStock supplierStock)
        {
            SupplierStockDAO.UpdateSupplierStock(id, supplierStock);
        }
    }
}
