using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class Offer
    {
        public Offer()
        {
            RequestQuotes = new HashSet<RequestQuote>();
        }

        public int OfferId { get; set; }
        public string? OfferNameAr { get; set; }
        public string? OfferNameEn { get; set; }

        public virtual ICollection<RequestQuote> RequestQuotes { get; set; }
    }
}
