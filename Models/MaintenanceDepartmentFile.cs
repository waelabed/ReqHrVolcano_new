using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class MaintenanceDepartmentFile
    {
        public int MaintenanceDepartmentFilesId { get; set; }
        public int? MaintenanceDepartmentId { get; set; }
        public string? MaintenanceDepartmentFileName { get; set; }
        public string? MaintenanceDepartmentFilePath { get; set; }

        public virtual MaintenanceDepartment? MaintenanceDepartment { get; set; }
    }
}
