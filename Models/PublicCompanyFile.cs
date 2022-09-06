using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class PublicCompanyFile
    {
        public int PublicCompanyFilesId { get; set; }
        public int? PublicCompanyId { get; set; }
        public string? PublicCompanyFileName { get; set; }
        public string? PublicCompanyFilePath { get; set; }

        public virtual PublicCompany? PublicCompany { get; set; }
    }
}
