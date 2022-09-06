using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class RequestQuoteFile
    {
        public int RequestQuoteFilesId { get; set; }
        public int? RequestQuoteId { get; set; }
        public string? RequestQuoteFileName { get; set; }
        public string? RequestQuoteFilePath { get; set; }

        public virtual RequestQuote? RequestQuote { get; set; }
    }
}
