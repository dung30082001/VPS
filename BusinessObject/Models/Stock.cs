using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Stock
    {
        public int StockId { get; set; }
        public int? ProductId { get; set; }
        public int? TechnicalId { get; set; }
        public int? SupplierId { get; set; }
        public int? CategoryId { get; set; }

        public virtual SupplierProduct? Product { get; set; }
        public virtual Supplier? Supplier { get; set; }
        public virtual Technical? Technical { get; set; }
    }
}
