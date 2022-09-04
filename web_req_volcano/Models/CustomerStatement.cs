using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class CustomerStatement
    {
        public int CustomerStatementId { get; set; }
        public int CustomerStatementEmpFrom { get; set; }
        public int CustomerStatementEmpTo { get; set; }
        public DateTime? CustomerStatementDate { get; set; }
        public int? CustomerStatementCustId { get; set; }
        public string? CustomerStatementNote { get; set; }
        public string? Ccto { get; set; }
        public string? Message { get; set; }

        public virtual Cust? CustomerStatementCust { get; set; }
        public virtual Emp CustomerStatementEmpFromNavigation { get; set; } = null!;
        public virtual Emp CustomerStatementEmpToNavigation { get; set; } = null!;
    }
}
