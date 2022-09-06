using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class MaintenanceReport
    {
        public MaintenanceReport()
        {
            MaintenanceReportFiles = new HashSet<MaintenanceReportFile>();
        }

        public int MaintenanceReportId { get; set; }
        public int CustId { get; set; }
        public string? MaintenanceReportBatch { get; set; }
        public DateTime? MaintenanceReportRunOrderDate { get; set; }
        public DateTime? MaintenanceReportDeliveryDate { get; set; }
        public string? MaintenanceReportEng { get; set; }
        public int MaintenanceReportEmp { get; set; }
        public string? MaintenanceReportNote { get; set; }

        public virtual Cust Cust { get; set; } = null!;
        public virtual Emp MaintenanceReportEmpNavigation { get; set; } = null!;
        public virtual ICollection<MaintenanceReportFile> MaintenanceReportFiles { get; set; }
    }
}
