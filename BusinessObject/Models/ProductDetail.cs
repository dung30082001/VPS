using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class ProductDetail
    {
        public int DetailId { get; set; }
        public int? ProductId { get; set; }
        public int? ImageId { get; set; }
    }
}
