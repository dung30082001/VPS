using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ISupplierRepository
    {
        List<Supplier> GetSupplier();

        Supplier GetSupplierbyId(int id);

        void UpdateSupplier(int id, Supplier supplier);

        void AddSupplier(Supplier supplier);

        void DeleteSupplier(int id);
    }
}
