using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class PricingMatter
    {
        public int PricingMatterId { get; set; }
        public int PricingMatterEmpFrom { get; set; }
        public int PricingMatterEmpTo { get; set; }
        public string? PricingMatterNote { get; set; }
    }
}
