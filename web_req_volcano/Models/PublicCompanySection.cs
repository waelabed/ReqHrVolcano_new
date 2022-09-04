using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class PublicCompanySection
    {
        public int PublicCompanySectionId { get; set; }
        public int? PublicCompanyId { get; set; }
        public int? SecId { get; set; }

        public virtual PublicCompany? PublicCompany { get; set; }
        public virtual Section? Sec { get; set; }
    }
}
