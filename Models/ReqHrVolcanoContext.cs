using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace web_req_volcano.Models
{
    public  class ReqHrVolcanoContext : IdentityDbContext<AspNetUser, IdentityRole, string>
    {
        public ReqHrVolcanoContext(DbContextOptions<ReqHrVolcanoContext> options) : base(options)
        {

        }

        //public virtual DbSet<AspNetRole> AspNetRoles { get; set; } = null!;
        //public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; } = null!;
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; } = null!;
        //public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; } = null!;
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; } = null!;
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; } = null!;
        public virtual DbSet<Car> Cars { get; set; } = null!;
        public virtual DbSet<CarInv> CarInvs { get; set; } = null!;
        public virtual DbSet<CarInvFile> CarInvFiles { get; set; } = null!;
        public virtual DbSet<CompanyPaper> CompanyPapers { get; set; } = null!;
        public virtual DbSet<CompanyPapersFile> CompanyPapersFiles { get; set; } = null!;
        public virtual DbSet<Covenant> Covenants { get; set; } = null!;
        public virtual DbSet<Cust> Custs { get; set; } = null!;
        public virtual DbSet<CustomerStatement> CustomerStatements { get; set; } = null!;
        public virtual DbSet<DeliveryReceiptCar> DeliveryReceiptCars { get; set; } = null!;
        public virtual DbSet<DeliveryReceiptCarFile> DeliveryReceiptCarFiles { get; set; } = null!;
        public virtual DbSet<DeliveryReceiptCovenant> DeliveryReceiptCovenants { get; set; } = null!;
        public virtual DbSet<DeliveryReceiptCovenantFile> DeliveryReceiptCovenantFiles { get; set; } = null!;
        public virtual DbSet<DeliveryReceiptRequest> DeliveryReceiptRequests { get; set; } = null!;
        public virtual DbSet<DeliveryReceiptRequestFile> DeliveryReceiptRequestFiles { get; set; } = null!;
        public virtual DbSet<Emp> Emps { get; set; } = null!;
        public virtual DbSet<EngineeringDepartment> EngineeringDepartments { get; set; } = null!;
        public virtual DbSet<EngineeringDepartmentFile> EngineeringDepartmentFiles { get; set; } = null!;
        public virtual DbSet<Inv> Invs { get; set; } = null!;
        public virtual DbSet<InvFile> InvFiles { get; set; } = null!;
        public virtual DbSet<Item> Items { get; set; } = null!;
        public virtual DbSet<MaintenanceDepartment> MaintenanceDepartments { get; set; } = null!;
        public virtual DbSet<MaintenanceDepartmentFile> MaintenanceDepartmentFiles { get; set; } = null!;
        public virtual DbSet<MaintenanceReport> MaintenanceReports { get; set; } = null!;
        public virtual DbSet<MaintenanceReportFile> MaintenanceReportFiles { get; set; } = null!;
        public virtual DbSet<Message> Messages { get; set; } = null!;
        public virtual DbSet<Nationality> Nationalities { get; set; } = null!;
        public virtual DbSet<Offer> Offers { get; set; } = null!;
        public virtual DbSet<Paper> Papers { get; set; } = null!;
        public virtual DbSet<PricingMatter> PricingMatters { get; set; } = null!;
        public virtual DbSet<PricingMatterItem> PricingMatterItems { get; set; } = null!;
        public virtual DbSet<ProjectCertificate> ProjectCertificates { get; set; } = null!;
        public virtual DbSet<ProjectCertificatesFile> ProjectCertificatesFiles { get; set; } = null!;
        public virtual DbSet<PublicCompany> PublicCompanies { get; set; } = null!;
        public virtual DbSet<PublicCompanyFile> PublicCompanyFiles { get; set; } = null!;
        public virtual DbSet<PublicCompanySection> PublicCompanySections { get; set; } = null!;
        public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; } = null!;
        public virtual DbSet<PurchaseOrderItem> PurchaseOrderItems { get; set; } = null!;
        public virtual DbSet<Request> Requests { get; set; } = null!;
        public virtual DbSet<RequestQuote> RequestQuotes { get; set; } = null!;
        public virtual DbSet<RequestQuoteFile> RequestQuoteFiles { get; set; } = null!;
        public virtual DbSet<Section> Sections { get; set; } = null!;
        public virtual DbSet<VehicleType> VehicleTypes { get; set; } = null!;



      
    }
}
