using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
            SupplierProducts = new HashSet<SupplierProduct>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<SupplierProduct> SupplierProducts { get; set; }
    }
}
