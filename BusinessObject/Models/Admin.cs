using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Admin
    {
        public Admin()
        {
            Accounts = new HashSet<Account>();
        }

        public int AdminId { get; set; }
        public string? FullName { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public DateTime? Dob { get; set; }
        public int? StatusId { get; set; }

        public virtual Hstatus? Status { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
