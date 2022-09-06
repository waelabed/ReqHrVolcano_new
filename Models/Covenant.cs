using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class Covenant
    {
        public Covenant()
        {
            DeliveryReceiptCovenants = new HashSet<DeliveryReceiptCovenant>();
        }

        public int CovenantId { get; set; }
        public string? CovenantNameAr { get; set; }
        public string? CovenantNameEn { get; set; }

        public virtual ICollection<DeliveryReceiptCovenant> DeliveryReceiptCovenants { get; set; }
    }
}
