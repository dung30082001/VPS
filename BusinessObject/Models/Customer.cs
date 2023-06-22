using System;
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
        }

        public int CustomerId { get; set; }
        public string? FullName { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public int? Balance { get; set; }
        public DateTime? Dob { get; set; }
        public int? ChatId { get; set; }
        public int? OrderId { get; set; }
        public int? StatusId { get; set; }
        public string? Avatar { get; set; }
        public bool? IsValid { get; set; }

        public virtual Order? Order { get; set; }
        public virtual Status? Status { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<FeedBack> FeedBacks { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
