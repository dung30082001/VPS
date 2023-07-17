using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Hstatus
    {
        public Hstatus()
        {
            Admins = new HashSet<Admin>();
            Consultants = new HashSet<Consultant>();
            Customers = new HashSet<Customer>();
            Managers = new HashSet<Manager>();
            Sales = new HashSet<Sale>();
            Shippers = new HashSet<Shipper>();
            Suppliers = new HashSet<Supplier>();
            Technicals = new HashSet<Technical>();
        }

        public int StatusId { get; set; }
        public int? StatusNum { get; set; }
        public string? StatusValue { get; set; }

        public virtual ICollection<Admin> Admins { get; set; }
        public virtual ICollection<Consultant> Consultants { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Manager> Managers { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
        public virtual ICollection<Shipper> Shippers { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
        public virtual ICollection<Technical> Technicals { get; set; }
    }
}
