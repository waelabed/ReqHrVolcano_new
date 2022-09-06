using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class CompanyPapersFile
    {
        public int CompanyPapersFilesId { get; set; }
        public int? CompanyPapersId { get; set; }
        public string? CompanyPapersFileName { get; set; }
        public string? CompanyPapersFilePath { get; set; }

        public virtual CompanyPaper? CompanyPapers { get; set; }
    }
}
