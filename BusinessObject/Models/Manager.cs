using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Manager
    {
        public Manager()
        {
            Accounts = new HashSet<Account>();
        }

        public int ManagerId { get; set; }
        public string? FullName { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public DateTime? Dob { get; set; }
        public int? StatusId { get; set; }
        public string? Avatar { get; set; }
        public int? SaleId { get; set; }

        public virtual Hstatus? Status { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
