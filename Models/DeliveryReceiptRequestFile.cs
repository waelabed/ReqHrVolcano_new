using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class DeliveryReceiptRequestFile
    {
        public int DeliveryReceiptRequestFilesId { get; set; }
        public int? DeliveryReceiptRequestId { get; set; }
        public string? DeliveryReceiptRequestFileName { get; set; }
        public string? DeliveryReceiptRequestFilePath { get; set; }

        public virtual DeliveryReceiptRequest? DeliveryReceiptRequest { get; set; }
    }
}
