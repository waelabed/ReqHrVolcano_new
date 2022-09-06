using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class Nationality
    {
        public Nationality()
        {
            Emps = new HashSet<Emp>();
        }

        public int NationalityId { get; set; }
        public string? NationalityNameAr { get; set; }
        public string? NationalityNameEn { get; set; }

        public virtual ICollection<Emp> Emps { get; set; }
    }
}
