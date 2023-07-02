using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Order
    {
        public Order()
        {
            FeedBacks = new HashSet<FeedBack>();
            OrderDetails = new HashSet<OrderDetail>();
            Rents = new HashSet<Rent>();
        }

        public int OrderId { get; set; }
        public int? SaleId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int? ShipId { get; set; }
        public double Price { get; set; }
        public int Status { get; set; }

        public virtual Sale? Sale { get; set; }
        public virtual Shipper? Ship { get; set; }
        public virtual ICollection<FeedBack> FeedBacks { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<Rent> Rents { get; set; }
    }
}
