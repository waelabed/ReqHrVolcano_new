using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class DeliveryReceiptRequest
    {
        public DeliveryReceiptRequest()
        {
            DeliveryReceiptRequestFiles = new HashSet<DeliveryReceiptRequestFile>();
        }

        public int DeliveryReceiptRequestId { get; set; }
        public int DeliveryReceiptRequestEmpFrom { get; set; }
        public int DeliveryReceiptRequestEmpTo { get; set; }
        public int RequestId { get; set; }
        public bool? DeliveryReceiptRequestIsIn { get; set; }
        public DateTime? DeliveryReceiptRequestDate { get; set; }
        public DateTime? DeliveryReceiptRequestCurrentDate { get; set; }
        public string? DeliveryReceiptRequestNote { get; set; }
        public string? Ccto { get; set; }
        public string? Message { get; set; }

        public virtual Emp DeliveryReceiptRequestEmpFromNavigation { get; set; } = null!;
        public virtual Emp DeliveryReceiptRequestEmpToNavigation { get; set; } = null!;
        public virtual Request Request { get; set; } = null!;
        public virtual ICollection<DeliveryReceiptRequestFile> DeliveryReceiptRequestFiles { get; set; }
    }
}
