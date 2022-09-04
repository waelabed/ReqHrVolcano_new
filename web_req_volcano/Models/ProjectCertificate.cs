using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class ProjectCertificate
    {
        public ProjectCertificate()
        {
            ProjectCertificatesFiles = new HashSet<ProjectCertificatesFile>();
        }

        public int ProjectCertificatesId { get; set; }
        public int CustId { get; set; }
        public string? ProjectCertificatesBatch { get; set; }
        public DateTime? ProjectCertificatesRunOrderDate { get; set; }
        public DateTime? ProjectCertificatesDeliveryDate { get; set; }
        public string? ProjectCertificatesEng { get; set; }
        public int ProjectCertificatesEmp { get; set; }
        public string? ProjectCertificatesNote { get; set; }

        public virtual Cust Cust { get; set; } = null!;
        public virtual Emp ProjectCertificatesEmpNavigation { get; set; } = null!;
        public virtual ICollection<ProjectCertificatesFile> ProjectCertificatesFiles { get; set; }
    }
}
