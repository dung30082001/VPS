using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Blog
    {
        public int Id { get; set; }
        public int? BloggerId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? PublishDate { get; set; }
        public int? ImageId { get; set; }
        public int? StatusId { get; set; }
        public int? CategoryId { get; set; }

        public virtual Blogger? Blogger { get; set; }
        public virtual Status? Status { get; set; }
    }
}
