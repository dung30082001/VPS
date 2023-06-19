using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Comment
    {
        public Comment()
        {
            Blogs = new HashSet<Blog>();
        }

        public int CommentId { get; set; }
        public int? BlogId { get; set; }
        public int? BloggerId { get; set; }
        public int? CustomerId { get; set; }
        public string? Content { get; set; }
        public DateTime? CommentDate { get; set; }

        public virtual Blogger? Blogger { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual ICollection<Blog> Blogs { get; set; }
    }
}
