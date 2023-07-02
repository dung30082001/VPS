using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ISupplierProductRepository
    {
        List<SupplierProduct> GetSupplierProduct();

        SupplierProduct GetSupplierProductbyId(int id);

        void UpdateSupplierProduct(int id, SupplierProduct supplierProduct);

        void AddSupplierProduct(SupplierProduct supplierProduct);

        void DeleteSupplierProduct(int id);
    }
}
