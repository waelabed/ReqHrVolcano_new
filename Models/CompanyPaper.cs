using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class CompanyPaper
    {
        public CompanyPaper()
        {
            CompanyPapersFiles = new HashSet<CompanyPapersFile>();
        }

        public int CompanyPapersId { get; set; }
        public int? PapersId { get; set; }
        public DateTime? CompanyPapersDate { get; set; }
        public int? CompanyPapersYear { get; set; }
        public string? CompanyPapersNote { get; set; }

        public virtual Paper? Papers { get; set; }
        public virtual ICollection<CompanyPapersFile> CompanyPapersFiles { get; set; }
    }
}
