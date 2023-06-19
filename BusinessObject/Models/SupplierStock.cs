using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class SupplierStock
    {
        public int StockId { get; set; }
        public int? ProductId { get; set; }
        public int? SupplierId { get; set; }
        public int? CategoryId { get; set; }

        public virtual SupplierProduct? Product { get; set; }
    }
}
