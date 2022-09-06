using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class DeliveryReceiptCovenantFile
    {
        public int DeliveryReceiptCovenantFilesId { get; set; }
        public int? DeliveryReceiptCovenantId { get; set; }
        public string? DeliveryReceiptCovenantFileName { get; set; }
        public string? DeliveryReceiptCovenantFilePath { get; set; }

        public virtual DeliveryReceiptCovenant? DeliveryReceiptCovenant { get; set; }
    }
}
