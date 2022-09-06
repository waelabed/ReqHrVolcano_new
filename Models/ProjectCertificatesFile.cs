using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class ProjectCertificatesFile
    {
        public int ProjectCertificatesFilesId { get; set; }
        public int? ProjectCertificatesId { get; set; }
        public string? ProjectCertificatesFileName { get; set; }
        public string? ProjectCertificatesFilePath { get; set; }

        public virtual ProjectCertificate? ProjectCertificates { get; set; }
    }
}
