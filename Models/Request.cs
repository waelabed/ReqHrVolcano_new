using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class Request
    {
        public Request()
        {
            DeliveryReceiptRequests = new HashSet<DeliveryReceiptRequest>();
        }

        public int RequestId { get; set; }
        public string? RequestNameAr { get; set; }
        public string? RequestNameEn { get; set; }

        public virtual ICollection<DeliveryReceiptRequest> DeliveryReceiptRequests { get; set; }
    }
}
