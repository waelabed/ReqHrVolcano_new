using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class Paper
    {
        public Paper()
        {
            CompanyPapers = new HashSet<CompanyPaper>();
        }

        public int PapersId { get; set; }
        public string? PapersNameAr { get; set; }
        public string? PapersNameEn { get; set; }

        public virtual ICollection<CompanyPaper> CompanyPapers { get; set; }
    }
}
