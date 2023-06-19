using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Message
    {
        public int MessageId { get; set; }
        public int? ConversationId { get; set; }
        public int? CustomerId { get; set; }
        public string? Description { get; set; }
        public DateTime? Time { get; set; }
        public int? StatusId { get; set; }
        public int? ConsultantId { get; set; }

        public virtual Consultant? Consultant { get; set; }
        public virtual Conversation? Conversation { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual Status? Status { get; set; }
    }
}
