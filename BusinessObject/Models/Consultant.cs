using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Consultant
    {
        public Consultant()
        {
            Accounts = new HashSet<Account>();
            FeedBacks = new HashSet<FeedBack>();
            Messages = new HashSet<Message>();
        }

        public int ConsultantId { get; set; }
        public string? FullName { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public DateTime? Dob { get; set; }
        public int? StatusId { get; set; }

        public virtual Hstatus? Status { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<FeedBack> FeedBacks { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
