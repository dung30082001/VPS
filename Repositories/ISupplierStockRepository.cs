using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ISupplierStockRepository
    {
        List<SupplierStock> GetSupplierStock();

        SupplierStock GetSupplierStockbyId(int id);

        void UpdateSupplierStaock(int id, SupplierStock supplierStock);

        void AddSupplierStock(SupplierStock supplierStock);

        void DeleteSupplierStock(int id);
    }
}
