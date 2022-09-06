using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class Cust
    {
        public Cust()
        {
            CustomerStatements = new HashSet<CustomerStatement>();
            EngineeringDepartments = new HashSet<EngineeringDepartment>();
            MaintenanceDepartments = new HashSet<MaintenanceDepartment>();
            MaintenanceReports = new HashSet<MaintenanceReport>();
            ProjectCertificates = new HashSet<ProjectCertificate>();
            RequestQuotes = new HashSet<RequestQuote>();
        }

        public int CustId { get; set; }
        public string? CustNameAr { get; set; }
        public string? CustNameEn { get; set; }
        public string? CustIdNumber { get; set; }
        public string? CustResponsible { get; set; }
        public string? CustEmail { get; set; }
        public string? CustRegion { get; set; }
        public int? CustCommissioner { get; set; }
        public string? CustNote { get; set; }

        public virtual Emp? CustCommissionerNavigation { get; set; }
        public virtual ICollection<CustomerStatement> CustomerStatements { get; set; }
        public virtual ICollection<EngineeringDepartment> EngineeringDepartments { get; set; }
        public virtual ICollection<MaintenanceDepartment> MaintenanceDepartments { get; set; }
        public virtual ICollection<MaintenanceReport> MaintenanceReports { get; set; }
        public virtual ICollection<ProjectCertificate> ProjectCertificates { get; set; }
        public virtual ICollection<RequestQuote> RequestQuotes { get; set; }
    }
}
