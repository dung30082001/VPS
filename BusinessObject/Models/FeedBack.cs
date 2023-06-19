using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class FeedBack
    {
        public int FeedbackId { get; set; }
        public int? CustomerId { get; set; }
        public int? ShipperId { get; set; }
        public int? ConsultantId { get; set; }
        public int? OrderId { get; set; }
        public string? Content { get; set; }

        public virtual Consultant? Consultant { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual Order? Order { get; set; }
        public virtual Shipper? Shipper { get; set; }
    }
}
