using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class PurchaseOrderItem
    {
        public int PurchaseOrderItemId { get; set; }
        public int PurchaseOrderId { get; set; }
        public int ItemId { get; set; }

        public virtual Item Item { get; set; } = null!;
        public virtual PurchaseOrder PurchaseOrder { get; set; } = null!;
    }
}
