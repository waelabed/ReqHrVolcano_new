using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class CarInvFile
    {
        public int CarInvFilesId { get; set; }
        public int? CarInvId { get; set; }
        public string? CarInvFileName { get; set; }
        public string? CarInvFilePath { get; set; }

        public virtual CarInv? CarInv { get; set; }
    }
}
