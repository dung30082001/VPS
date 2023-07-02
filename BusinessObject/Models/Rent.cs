using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Rent
    {
        public int BuyId { get; set; }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual Order Order { get; set; } = null!;
    }
}
