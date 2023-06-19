using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Contract
    {
        public int ContractId { get; set; }
        public int? TechnicalId { get; set; }
        public int? SupplierId { get; set; }
        public string? Content { get; set; }

        public virtual Supplier? Supplier { get; set; }
        public virtual Technical? Technical { get; set; }
    }
}
