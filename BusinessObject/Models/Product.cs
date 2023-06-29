using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public int? CategoryId { get; set; }
        public int? UnitInStock { get; set; }
        public double? UnitPrice { get; set; }
        public string? Image { get; set; }
        public int? StatusId { get; set; }
        public string? Brand { get; set; }
        public string? Description { get; set; }
        public DateTime? DiscountDate { get; set; }
        public string? Type { get; set; }
        public string? Moneytype { get; set; }
        public int? Quality { get; set; }
        public string? Maintaince { get; set; }

        public virtual Category? Category { get; set; }
        public virtual Status? Status { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
