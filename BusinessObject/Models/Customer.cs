﻿using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Accounts = new HashSet<Account>();
            Comments = new HashSet<Comment>();
            FeedBacks = new HashSet<FeedBack>();
            Messages = new HashSet<Message>();
            Orders = new HashSet<Order>();
            Rents = new HashSet<Rent>();
        }

        public int CustomerId { get; set; }
        public string? FullName { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public int? Balance { get; set; }
        public DateTime? Dob { get; set; }
        public int? StatusId { get; set; }
        public string? Avatar { get; set; }
        public bool? IsValid { get; set; }
        public int? Voucher { get; set; }

        public virtual Hstatus? Status { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<FeedBack> FeedBacks { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Rent> Rents { get; set; }
    }
}
