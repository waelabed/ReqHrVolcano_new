using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class MaintenanceDepartment
    {
        public MaintenanceDepartment()
        {
            MaintenanceDepartmentFiles = new HashSet<MaintenanceDepartmentFile>();
        }

        public int MaintenanceDepartmentId { get; set; }
        public int MaintenanceDepartmentEmpId { get; set; }
        public int MaintenanceDepartmentCustId { get; set; }
        public int MaintenanceDepartmentItemId { get; set; }
        public decimal? MaintenanceDepartmentQuantity { get; set; }
        public int? MaintenanceDepartmentTotal { get; set; }
        public string? MaintenanceDepartmentNote { get; set; }
        public DateTime? MaintenanceDepartmentDate { get; set; }
        public string? Ccto { get; set; }
        public string? Message { get; set; }

        public virtual Cust MaintenanceDepartmentCust { get; set; } = null!;
        public virtual Emp MaintenanceDepartmentEmp { get; set; } = null!;
        public virtual Item MaintenanceDepartmentItem { get; set; } = null!;
        public virtual ICollection<MaintenanceDepartmentFile> MaintenanceDepartmentFiles { get; set; }
    }
}
