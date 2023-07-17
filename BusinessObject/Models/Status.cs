using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Status
    {
        public Status()
        {
            Orders = new HashSet<Order>();
        }

        public int StatusId { get; set; }
        public int? StatusNum { get; set; }
        public string? StatusValue { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
