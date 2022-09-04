using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class EngineeringDepartment
    {
        public EngineeringDepartment()
        {
            EngineeringDepartmentFiles = new HashSet<EngineeringDepartmentFile>();
        }

        public int EngineeringDepartmentId { get; set; }
        public int EngineeringDepartmentEmpId { get; set; }
        public int EngineeringDepartmentCustId { get; set; }
        public int EngineeringDepartmentItemId { get; set; }
        public decimal? EngineeringDepartmentQuantity { get; set; }
        public int? EngineeringDepartmentTotal { get; set; }
        public string? EngineeringDepartmentNote { get; set; }
        public DateTime? EngineeringDepartmentDate { get; set; }
        public string? Ccto { get; set; }
        public string? Message { get; set; }
        public int? EngineeringDepartmentEmpTo { get; set; }

        public virtual Cust EngineeringDepartmentCust { get; set; } = null!;
        public virtual Item EngineeringDepartmentItem { get; set; } = null!;
        public virtual Emp EngineeringDepartmentNavigation { get; set; } = null!;
        public virtual ICollection<EngineeringDepartmentFile> EngineeringDepartmentFiles { get; set; }
    }
}
