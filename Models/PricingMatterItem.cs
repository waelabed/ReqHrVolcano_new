using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class PricingMatterItem
    {
        public int PricingMatterItemId { get; set; }
        public int PricingMatterId { get; set; }
        public int ItemId { get; set; }
    }
}
