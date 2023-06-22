using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Account
    {
        public int AccountId { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Avatar { get; set; }
        public bool? Status { get; set; }
        public string? Profile { get; set; }
        public int? RoleId { get; set; }
        public int? BloggerId { get; set; }
        public int? ConsultantId { get; set; }
        public int? CustomerId { get; set; }
        public int? ManagerId { get; set; }
        public int? SupplierId { get; set; }
        public int? TechnicalId { get; set; }
        public int? AdminId { get; set; }
        public int? SaleId { get; set; }
        public int? ShipperId { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Admin? Admin { get; set; }
        public virtual Blogger? Blogger { get; set; }
        public virtual Consultant? Consultant { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual Manager? Manager { get; set; }
        public virtual Role? Role { get; set; }
        public virtual Sale? Sale { get; set; }
        public virtual Shipper? Shipper { get; set; }
        public virtual Supplier? Supplier { get; set; }
        public virtual Technical? Technical { get; set; }
    }
}
