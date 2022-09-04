using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class MaintenanceReportFile
    {
        public int MaintenanceReportFilesId { get; set; }
        public int? MaintenanceReportId { get; set; }
        public string? MaintenanceReportFileName { get; set; }
        public string? MaintenanceReportFilePath { get; set; }

        public virtual MaintenanceReport? MaintenanceReport { get; set; }
    }
}
