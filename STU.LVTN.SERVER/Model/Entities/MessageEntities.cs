using System;
using System.Collections.Generic;

namespace STU.LVTN.SERVER.Model
{
    public partial class MessageEntities
    {
        public int MessageId { get; set; }
        public string? MessagesBy { get; set; }
        public DateTime? Time { get; set; }
        public string? MessageText { get; set; }
        public string? MessageImageSource { get; set; }
        public int? ConversationId { get; set; }
    }
}
