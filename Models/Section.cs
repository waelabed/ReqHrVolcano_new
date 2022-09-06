using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class Section
    {
        public Section()
        {
            Emps = new HashSet<Emp>();
            PublicCompanySections = new HashSet<PublicCompanySection>();
        }

        public int SectionId { get; set; }
        public string? SectionNameAr { get; set; }
        public string? SectionNameEn { get; set; }
        public string? SectionNote { get; set; }

        public virtual ICollection<Emp> Emps { get; set; }
        public virtual ICollection<PublicCompanySection> PublicCompanySections { get; set; }
    }
}
