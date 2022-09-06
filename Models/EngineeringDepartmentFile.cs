using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class EngineeringDepartmentFile
    {
        public int EngineeringDepartmentFilesId { get; set; }
        public int? EngineeringDepartmentId { get; set; }
        public string? EngineeringDepartmentFileName { get; set; }
        public string? EngineeringDepartmentFilePath { get; set; }

        public virtual EngineeringDepartment? EngineeringDepartment { get; set; }
    }
}
