using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Qrcode
    {
        public int Qrid { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public DateTime? DayCreate { get; set; }
        public int? ProductId { get; set; }
    }
}
