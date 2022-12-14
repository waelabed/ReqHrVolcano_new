using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_req_volcano.Models
{
    public class Emp
    {
        

        public int EmpId { get; set; }
        public string? EmpNameAr { get; set; }
        public string? EmpNameEn { get; set; }
        public string? EmpMobile { get; set; }
        public string? EmpIdNumber { get; set; }
        public int? EmpNatId { get; set; }
        public int? EmpSecId { get; set; }
        public bool? EmpIsPosetion { get; set; }
        public string? EmpNote { get; set; }

        

        public virtual Nationality? EmpNat { get; set; }
        public virtual Section? EmpSec { get; set; }

        public string? UserId { get; set; }
        public virtual AspNetUser? User { get; set; }
        public virtual EngineeringDepartment EngineeringDepartment { get; set; } = null!;
        public virtual ICollection<CustomerStatement> CustomerStatementCustomerStatementEmpFromNavigations { get; set; }
        public virtual ICollection<CustomerStatement> CustomerStatementCustomerStatementEmpToNavigations { get; set; }
        public virtual ICollection<Cust> Custs { get; set; }
        public virtual ICollection<DeliveryReceiptCar> DeliveryReceiptCarDeliveryReceiptCarEmpFromNavigations { get; set; }
        public virtual ICollection<DeliveryReceiptCar> DeliveryReceiptCarDeliveryReceiptCarEmpToNavigations { get; set; }
        public virtual ICollection<DeliveryReceiptCovenant> DeliveryReceiptCovenantDeliveryReceiptCovenantEmpFromNavigations { get; set; }
        public virtual ICollection<DeliveryReceiptCovenant> DeliveryReceiptCovenantDeliveryReceiptCovenantEmpToNavigations { get; set; }
        public virtual ICollection<DeliveryReceiptRequest> DeliveryReceiptRequestDeliveryReceiptRequestEmpFromNavigations { get; set; }
        public virtual ICollection<DeliveryReceiptRequest> DeliveryReceiptRequestDeliveryReceiptRequestEmpToNavigations { get; set; }
        public virtual ICollection<MaintenanceDepartment> MaintenanceDepartments { get; set; }
        public virtual ICollection<MaintenanceReport> MaintenanceReports { get; set; }
        public virtual ICollection<ProjectCertificate> ProjectCertificates { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrderPurchaseOrderEmpFromNavigations { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrderPurchaseOrderEmpToNavigations { get; set; }
        public virtual ICollection<RequestQuote> RequestQuotes { get; set; }
    }
}
