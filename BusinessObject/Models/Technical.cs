﻿using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Technical
    {
        public Technical()
        {
            Accounts = new HashSet<Account>();
            Contracts = new HashSet<Contract>();
            Stocks = new HashSet<Stock>();
        }

        public int TechnicalId { get; set; }
        public string? FullName { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public DateTime? Dob { get; set; }
        public string? Avatar { get; set; }
        public int? StatusId { get; set; }

        public virtual Status? Status { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
