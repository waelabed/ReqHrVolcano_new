using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class DeliveryReceiptCar
    {
        public DeliveryReceiptCar()
        {
            DeliveryReceiptCarFiles = new HashSet<DeliveryReceiptCarFile>();
        }

        public int DeliveryReceiptCarId { get; set; }
        public int? DeliveryReceiptCarEmpFrom { get; set; }
        public int? DeliveryReceiptCarEmpTo { get; set; }
        public int? CarId { get; set; }
        public DateTime? DeliveryReceiptCarDate { get; set; }
        public DateTime? DeliveryReceiptCarCurrentDate { get; set; }
        public short? DeliveryReceiptCarIsIn { get; set; }
        public string? DeliveryReceiptCarNote { get; set; }
        public string? Ccto { get; set; }
        public string? Message { get; set; }

        public virtual Car? Car { get; set; }
        public virtual Emp? DeliveryReceiptCarEmpFromNavigation { get; set; }
        public virtual Emp? DeliveryReceiptCarEmpToNavigation { get; set; }
        public virtual ICollection<DeliveryReceiptCarFile> DeliveryReceiptCarFiles { get; set; }
    }
}
