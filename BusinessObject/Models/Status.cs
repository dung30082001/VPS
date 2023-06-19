using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Status
    {
        public Status()
        {
            Blogs = new HashSet<Blog>();
            Customers = new HashSet<Customer>();
            Messages = new HashSet<Message>();
            Sales = new HashSet<Sale>();
            Suppliers = new HashSet<Supplier>();
            Technicals = new HashSet<Technical>();
        }

        public int StatusId { get; set; }
        public string? StatusName { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
        public virtual ICollection<Technical> Technicals { get; set; }
    }
}
