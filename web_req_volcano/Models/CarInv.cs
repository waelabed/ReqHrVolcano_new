using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class CarInv
    {
        public CarInv()
        {
            CarInvFiles = new HashSet<CarInvFile>();
        }

        public int CarInvId { get; set; }
        public DateTime? CarInvDate { get; set; }
        public string? CarInvNote { get; set; }
        public int? CarId { get; set; }

        public virtual ICollection<CarInvFile> CarInvFiles { get; set; }
    }
}
