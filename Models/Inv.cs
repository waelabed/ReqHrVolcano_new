using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class Inv
    {
        public Inv()
        {
            InvFiles = new HashSet<InvFile>();
        }

        public int InvId { get; set; }
        public DateTime? InvDate { get; set; }
        public string? InvNote { get; set; }
        public int? InvQuantity { get; set; }
        public int? ItemId { get; set; }

        public virtual Item? Item { get; set; }
        public virtual ICollection<InvFile> InvFiles { get; set; }
    }
}
