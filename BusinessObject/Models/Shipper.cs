using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Shipper
    {
        public Shipper()
        {
            Accounts = new HashSet<Account>();
            FeedBacks = new HashSet<FeedBack>();
            Orders = new HashSet<Order>();
        }

        public int ShipperId { get; set; }
        public string? FullName { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public DateTime? Dob { get; set; }
        public string? Avatar { get; set; }
        public int? OrderId { get; set; }
        public int? StatusId { get; set; }
        public int? CustomerId { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<FeedBack> FeedBacks { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
