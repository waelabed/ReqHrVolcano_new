using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class DeliveryReceiptCovenant
    {
        public DeliveryReceiptCovenant()
        {
            DeliveryReceiptCovenantFiles = new HashSet<DeliveryReceiptCovenantFile>();
        }

        public int DeliveryReceiptCovenantId { get; set; }
        public int DeliveryReceiptCovenantEmpFrom { get; set; }
        public int DeliveryReceiptCovenantEmpTo { get; set; }
        public int CovenantId { get; set; }
        public bool? DeliveryReceiptCovenantIsIn { get; set; }
        public DateTime? DeliveryReceiptCovenantCurrentDate { get; set; }
        public DateTime? DeliveryReceiptCovenantDate { get; set; }
        public string? DeliveryReceiptCovenantNote { get; set; }
        public string? Ccto { get; set; }
        public string? Message { get; set; }

        public virtual Covenant Covenant { get; set; } = null!;
        public virtual Emp DeliveryReceiptCovenantEmpFromNavigation { get; set; } = null!;
        public virtual Emp DeliveryReceiptCovenantEmpToNavigation { get; set; } = null!;
        public virtual ICollection<DeliveryReceiptCovenantFile> DeliveryReceiptCovenantFiles { get; set; }
    }
}
