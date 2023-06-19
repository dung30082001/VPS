using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class SupplierProduct
    {
        public SupplierProduct()
        {
            Stocks = new HashSet<Stock>();
            SupplierStocks = new HashSet<SupplierStock>();
        }

        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? Description { get; set; }
        public int? CategoryId { get; set; }
        public string? Image { get; set; }
        public string? Brand { get; set; }
        public int? StatusId { get; set; }
        public int? UnitInStock { get; set; }
        public double? UnitPrice { get; set; }
        public int? NumberOfUse { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
        public virtual ICollection<SupplierStock> SupplierStocks { get; set; }
    }
}
