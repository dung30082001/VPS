﻿using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Conversation
    {
        public Conversation()
        {
            Messages = new HashSet<Message>();
        }

        public int ConversationId { get; set; }
        public string? ConversationName { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
    }
}
