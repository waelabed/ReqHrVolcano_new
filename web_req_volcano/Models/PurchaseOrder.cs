using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class PurchaseOrder
    {
        public PurchaseOrder()
        {
            PurchaseOrderItems = new HashSet<PurchaseOrderItem>();
        }

        public int PurchaseOrderId { get; set; }
        public int PurchaseOrderEmpFrom { get; set; }
        public int PurchaseOrderEmpTo { get; set; }
        public string? PurchaseOrderNote { get; set; }
        public string? Ccto { get; set; }
        public string? Message { get; set; }

        public virtual Emp PurchaseOrderEmpFromNavigation { get; set; } = null!;
        public virtual Emp PurchaseOrderEmpToNavigation { get; set; } = null!;
        public virtual ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; }
    }
}
