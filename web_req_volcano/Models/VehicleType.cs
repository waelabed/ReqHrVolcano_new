using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class VehicleType
    {
        public VehicleType()
        {
            Cars = new HashSet<Car>();
        }

        public int VehicleTypeId { get; set; }
        public string? VehicleTypeNameAr { get; set; }
        public string? VehicleTypeNameEn { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
