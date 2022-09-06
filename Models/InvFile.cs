using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class InvFile
    {
        public int InvFilesId { get; set; }
        public int? InvId { get; set; }
        public string? InvFileName { get; set; }
        public string? InvFilePath { get; set; }

        public virtual Inv? Inv { get; set; }
    }
}
