using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class DeliveryReceiptCarFile
    {
        public int DeliveryReceiptCarFilesId { get; set; }
        public int? DeliveryReceiptCarId { get; set; }
        public string? DeliveryReceiptCarFileName { get; set; }
        public string? DeliveryReceiptCarFilePath { get; set; }

        public virtual DeliveryReceiptCar? DeliveryReceiptCar { get; set; }
    }
}
