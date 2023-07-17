using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Pstatus
    {
        public Pstatus()
        {
            Products = new HashSet<Product>();
            SupplierProducts = new HashSet<SupplierProduct>();
        }

        public int StatusId { get; set; }
        public int? StatusNum { get; set; }
        public string? StatusValue { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<SupplierProduct> SupplierProducts { get; set; }
    }
}
