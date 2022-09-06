using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class Car
    {
        public Car()
        {
            DeliveryReceiptCars = new HashSet<DeliveryReceiptCar>();
        }

        public int CarId { get; set; }
        public int? VehicleTypeId { get; set; }
        public string? CarSpecifications { get; set; }
        public string? CarIdNumber { get; set; }
        public string? CarNote { get; set; }

        public virtual VehicleType? VehicleType { get; set; }
        public virtual ICollection<DeliveryReceiptCar> DeliveryReceiptCars { get; set; }
    }
}
