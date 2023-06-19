using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Blogger
    {
        public Blogger()
        {
            Accounts = new HashSet<Account>();
            Blogs = new HashSet<Blog>();
            Comments = new HashSet<Comment>();
        }

        public int BloggerId { get; set; }
        public string? FullName { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public DateTime? Dob { get; set; }
        public int? StatusId { get; set; }
        public int? BlogId { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Blog> Blogs { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
