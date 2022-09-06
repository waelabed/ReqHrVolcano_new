using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class RequestQuote
    {
        public RequestQuote()
        {
            RequestQuoteFiles = new HashSet<RequestQuoteFile>();
        }

        public int RequestQuoteId { get; set; }
        public int RequestQuoteEmpId { get; set; }
        public int RequestQuoteItemId { get; set; }
        public int RequestQuoteCustId { get; set; }
        public int RequestQuoteOfferId { get; set; }
        public int RequestQuoteQuantity { get; set; }
        public decimal RequestQuoteTotal { get; set; }
        public string? RequestQuoteNote { get; set; }
        public DateTime? RequestQuoteDate { get; set; }
        public string? Ccto { get; set; }
        public string? Message { get; set; }
        public int? EngineeringDepartmentEmpTo { get; set; }

        public virtual Cust RequestQuoteCust { get; set; } = null!;
        public virtual Emp RequestQuoteEmp { get; set; } = null!;
        public virtual Item RequestQuoteItem { get; set; } = null!;
        public virtual Offer RequestQuoteOffer { get; set; } = null!;
        public virtual ICollection<RequestQuoteFile> RequestQuoteFiles { get; set; }
    }
}
