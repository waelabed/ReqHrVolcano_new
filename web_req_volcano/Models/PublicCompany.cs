using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class PublicCompany
    {
        public PublicCompany()
        {
            PublicCompanyFiles = new HashSet<PublicCompanyFile>();
            PublicCompanySections = new HashSet<PublicCompanySection>();
        }

        public int PublicCompanyId { get; set; }
        public string? PublicCompanyName { get; set; }
        public DateTime? PublicCompanyDate { get; set; }

        public virtual ICollection<PublicCompanyFile> PublicCompanyFiles { get; set; }
        public virtual ICollection<PublicCompanySection> PublicCompanySections { get; set; }
    }
}
