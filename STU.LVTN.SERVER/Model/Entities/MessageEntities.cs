using System;
using System.Collections.Generic;

namespace STU.LVTN.SERVER.Model
{
    public partial class MessageEntities
    {
        public int MessageId { get; set; }
        public int? ConversationId { get; set; }
        public string? Messages { get; set; }
        public string? MessageBy { get; set; }
    }
}
