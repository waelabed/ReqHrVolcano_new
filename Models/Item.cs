using System;
using System.Collections.Generic;

namespace web_req_volcano.Models
{
    public partial class Item
    {
        public Item()
        {
            EngineeringDepartments = new HashSet<EngineeringDepartment>();
            Invs = new HashSet<Inv>();
            MaintenanceDepartments = new HashSet<MaintenanceDepartment>();
            PurchaseOrderItems = new HashSet<PurchaseOrderItem>();
            RequestQuotes = new HashSet<RequestQuote>();
        }

        public int ItemId { get; set; }
        public string? ItemNameAr { get; set; }
        public string? ItemNameEn { get; set; }
        public string? ItemBrand { get; set; }
        public string? ItemIndustry { get; set; }
        public decimal? ItemPrice { get; set; }
        public string? ItemNote { get; set; }

        public virtual ICollection<EngineeringDepartment> EngineeringDepartments { get; set; }
        public virtual ICollection<Inv> Invs { get; set; }
        public virtual ICollection<MaintenanceDepartment> MaintenanceDepartments { get; set; }
        public virtual ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; }
        public virtual ICollection<RequestQuote> RequestQuotes { get; set; }
    }
}
