using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class Message
    {
        public int MessageId { get; set; }
        public int? MessageType { get; set; }
        public DateTime? MessageDate { get; set; }
        public int? MessageEmpFrom { get; set; }
        public string? Message1 { get; set; }
        public int? MessageEmpTo { get; set; }
    }
}
