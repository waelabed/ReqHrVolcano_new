using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace web_req_volcano.Models
{
    public  partial class ReqHrVolcanoContext : IdentityDbContext<AspNetUser, IdentityRole, string>
    {
        public ReqHrVolcanoContext(DbContextOptions<ReqHrVolcanoContext> options) : base(options)
        {

        }

        //public virtual DbSet<AspNetRole> AspNetRoles { get; set; } = null!;
        //public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; } = null!;
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; } = null!;
        // //public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; } = null!;
        // public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; } = null!;
        // public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; } = null!;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             

            
            
            modelBuilder.Entity<Car>(entity =>
            {
                entity.ToTable("Car");

                entity.Property(e => e.CarIdNumber).HasMaxLength(50);

                entity.Property(e => e.CarSpecifications).HasMaxLength(50);

                entity.HasOne(d => d.VehicleType)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.VehicleTypeId)
                    .HasConstraintName("FK_Car_VehicleType");
            });

            modelBuilder.Entity<CarInv>(entity =>
            {
                entity.ToTable("CarInv");

                entity.Property(e => e.CarInvDate).HasColumnType("date");
            });

            modelBuilder.Entity<CarInvFile>(entity =>
            {
                entity.HasKey(e => e.CarInvFilesId);

                entity.ToTable("CarInv_Files");

                entity.Property(e => e.CarInvFilesId).HasColumnName("CarInv_FilesId");

                entity.Property(e => e.CarInvFileName)
                    .HasMaxLength(50)
                    .HasColumnName("CarInv_FileName");

                entity.Property(e => e.CarInvFilePath)
                    .HasColumnType("ntext")
                    .HasColumnName("CarInv_FilePath");

                entity.HasOne(d => d.CarInv)
                    .WithMany(p => p.CarInvFiles)
                    .HasForeignKey(d => d.CarInvId)
                    .HasConstraintName("FK_CarInv_Files_CarInv");
            });

            modelBuilder.Entity<CompanyPaper>(entity =>
            {
                entity.HasKey(e => e.CompanyPapersId);

                entity.Property(e => e.CompanyPapersDate).HasColumnType("date");

                entity.HasOne(d => d.Papers)
                    .WithMany(p => p.CompanyPapers)
                    .HasForeignKey(d => d.PapersId)
                    .HasConstraintName("FK_CompanyPapers_Papers");
            });

            modelBuilder.Entity<CompanyPapersFile>(entity =>
            {
                entity.HasKey(e => e.CompanyPapersFilesId);

                entity.ToTable("CompanyPapers_Files");

                entity.Property(e => e.CompanyPapersFilesId).HasColumnName("CompanyPapers_FilesId");

                entity.Property(e => e.CompanyPapersFileName)
                    .HasMaxLength(50)
                    .HasColumnName("CompanyPapers_FileName");

                entity.Property(e => e.CompanyPapersFilePath).HasColumnName("CompanyPapers_FilePath");

                entity.HasOne(d => d.CompanyPapers)
                    .WithMany(p => p.CompanyPapersFiles)
                    .HasForeignKey(d => d.CompanyPapersId)
                    .HasConstraintName("FK_CompanyPapers_Files_CompanyPapers");
            });

            modelBuilder.Entity<Covenant>(entity =>
            {
                entity.ToTable("Covenant");

                entity.Property(e => e.CovenantNameAr).HasMaxLength(50);

                entity.Property(e => e.CovenantNameEn).HasMaxLength(50);
            });

            modelBuilder.Entity<Cust>(entity =>
            {
                entity.ToTable("Cust");

                entity.Property(e => e.CustEmail).HasMaxLength(50);

                entity.Property(e => e.CustIdNumber).HasMaxLength(50);

                entity.Property(e => e.CustNameAr)
                    .HasMaxLength(50)
                    .HasColumnName("CustNameAR");

                entity.Property(e => e.CustNameEn)
                    .HasMaxLength(50)
                    .HasColumnName("CustNameEN");

                entity.Property(e => e.CustRegion).HasMaxLength(50);

                entity.Property(e => e.CustResponsible).HasMaxLength(50);

                entity.HasOne(d => d.CustCommissionerNavigation)
                    .WithMany(p => p.Custs)
                    .HasForeignKey(d => d.CustCommissioner)
                    .HasConstraintName("FK_Cust_Emp");
            });

            modelBuilder.Entity<CustomerStatement>(entity =>
            {
                entity.ToTable("CustomerStatement");

                entity.Property(e => e.Ccto)
                    .HasMaxLength(50)
                    .HasColumnName("CCTO");

                entity.Property(e => e.CustomerStatementDate).HasColumnType("date");

                entity.HasOne(d => d.CustomerStatementCust)
                    .WithMany(p => p.CustomerStatements)
                    .HasForeignKey(d => d.CustomerStatementCustId)
                    .HasConstraintName("FK_CustomerStatement_Cust");

                entity.HasOne(d => d.CustomerStatementEmpFromNavigation)
                    .WithMany(p => p.CustomerStatementCustomerStatementEmpFromNavigations)
                    .HasForeignKey(d => d.CustomerStatementEmpFrom)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerStatement_Emp1");

                entity.HasOne(d => d.CustomerStatementEmpToNavigation)
                    .WithMany(p => p.CustomerStatementCustomerStatementEmpToNavigations)
                    .HasForeignKey(d => d.CustomerStatementEmpTo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerStatement_Emp");
            });

            modelBuilder.Entity<DeliveryReceiptCar>(entity =>
            {
                entity.ToTable("Delivery_Receipt_Car");

                entity.Property(e => e.DeliveryReceiptCarId).HasColumnName("Delivery_Receipt_CarId");

                entity.Property(e => e.Ccto)
                    .HasMaxLength(50)
                    .HasColumnName("CCTO");

                entity.Property(e => e.DeliveryReceiptCarCurrentDate)
                    .HasColumnType("date")
                    .HasColumnName("Delivery_Receipt_CarCurrentDate");

                entity.Property(e => e.DeliveryReceiptCarDate)
                    .HasColumnType("date")
                    .HasColumnName("Delivery_Receipt_CarDate");

                entity.Property(e => e.DeliveryReceiptCarEmpFrom).HasColumnName("Delivery_Receipt_CarEmpFrom");

                entity.Property(e => e.DeliveryReceiptCarEmpTo).HasColumnName("Delivery_Receipt_CarEmpTo");

                entity.Property(e => e.DeliveryReceiptCarIsIn).HasColumnName("Delivery_Receipt_Car_IsIn");

                entity.Property(e => e.DeliveryReceiptCarNote).HasColumnName("Delivery_Receipt_CarNote");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.DeliveryReceiptCars)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("FK_Delivery_Receipt_Car_Car");

                entity.HasOne(d => d.DeliveryReceiptCarEmpFromNavigation)
                    .WithMany(p => p.DeliveryReceiptCarDeliveryReceiptCarEmpFromNavigations)
                    .HasForeignKey(d => d.DeliveryReceiptCarEmpFrom)
                    .HasConstraintName("FK_Delivery_Receipt_Car_Emp");

                entity.HasOne(d => d.DeliveryReceiptCarEmpToNavigation)
                    .WithMany(p => p.DeliveryReceiptCarDeliveryReceiptCarEmpToNavigations)
                    .HasForeignKey(d => d.DeliveryReceiptCarEmpTo)
                    .HasConstraintName("FK_Delivery_Receipt_Car_Emp1");
            });

            modelBuilder.Entity<DeliveryReceiptCarFile>(entity =>
            {
                entity.HasKey(e => e.DeliveryReceiptCarFilesId);

                entity.ToTable("Delivery_Receipt_Car_Files");

                entity.Property(e => e.DeliveryReceiptCarFilesId).HasColumnName("Delivery_Receipt_Car_FilesId");

                entity.Property(e => e.DeliveryReceiptCarFileName)
                    .HasMaxLength(50)
                    .HasColumnName("Delivery_Receipt_Car_FileName");

                entity.Property(e => e.DeliveryReceiptCarFilePath).HasColumnName("Delivery_Receipt_Car_FilePath");

                entity.Property(e => e.DeliveryReceiptCarId).HasColumnName("Delivery_Receipt_CarId");

                entity.HasOne(d => d.DeliveryReceiptCar)
                    .WithMany(p => p.DeliveryReceiptCarFiles)
                    .HasForeignKey(d => d.DeliveryReceiptCarId)
                    .HasConstraintName("FK_Delivery_Receipt_Car_Files_Delivery_Receipt_Car");
            });

            modelBuilder.Entity<DeliveryReceiptCovenant>(entity =>
            {
                entity.ToTable("Delivery_receipt_covenant");

                entity.Property(e => e.DeliveryReceiptCovenantId).HasColumnName("Delivery_receipt_covenantId");

                entity.Property(e => e.Ccto)
                    .HasMaxLength(50)
                    .HasColumnName("CCTO");

                entity.Property(e => e.DeliveryReceiptCovenantCurrentDate)
                    .HasColumnType("date")
                    .HasColumnName("Delivery_receipt_covenantCurrentDate");

                entity.Property(e => e.DeliveryReceiptCovenantDate)
                    .HasColumnType("date")
                    .HasColumnName("Delivery_receipt_covenantDate");

                entity.Property(e => e.DeliveryReceiptCovenantEmpFrom).HasColumnName("Delivery_receipt_covenantEmpFrom");

                entity.Property(e => e.DeliveryReceiptCovenantEmpTo).HasColumnName("Delivery_receipt_covenantEmpTo");

                entity.Property(e => e.DeliveryReceiptCovenantIsIn).HasColumnName("Delivery_receipt_covenant_IsIn");

                entity.Property(e => e.DeliveryReceiptCovenantNote).HasColumnName("Delivery_receipt_covenantNote");

                entity.HasOne(d => d.Covenant)
                    .WithMany(p => p.DeliveryReceiptCovenants)
                    .HasForeignKey(d => d.CovenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Delivery_receipt_covenant_Covenant");

                entity.HasOne(d => d.DeliveryReceiptCovenantEmpFromNavigation)
                    .WithMany(p => p.DeliveryReceiptCovenantDeliveryReceiptCovenantEmpFromNavigations)
                    .HasForeignKey(d => d.DeliveryReceiptCovenantEmpFrom)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Delivery_receipt_covenant_Emp");

                entity.HasOne(d => d.DeliveryReceiptCovenantEmpToNavigation)
                    .WithMany(p => p.DeliveryReceiptCovenantDeliveryReceiptCovenantEmpToNavigations)
                    .HasForeignKey(d => d.DeliveryReceiptCovenantEmpTo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Delivery_receipt_covenant_Emp1");
            });

            modelBuilder.Entity<DeliveryReceiptCovenantFile>(entity =>
            {
                entity.HasKey(e => e.DeliveryReceiptCovenantFilesId);

                entity.ToTable("Delivery_receipt_covenant_Files");

                entity.Property(e => e.DeliveryReceiptCovenantFilesId).HasColumnName("Delivery_receipt_covenant_FilesId");

                entity.Property(e => e.DeliveryReceiptCovenantFileName)
                    .HasMaxLength(50)
                    .HasColumnName("Delivery_receipt_covenant_FileName");

                entity.Property(e => e.DeliveryReceiptCovenantFilePath).HasColumnName("Delivery_receipt_covenant_FilePath");

                entity.Property(e => e.DeliveryReceiptCovenantId).HasColumnName("Delivery_receipt_covenantId");

                entity.HasOne(d => d.DeliveryReceiptCovenant)
                    .WithMany(p => p.DeliveryReceiptCovenantFiles)
                    .HasForeignKey(d => d.DeliveryReceiptCovenantId)
                    .HasConstraintName("FK_Delivery_receipt_covenant_Files_Delivery_receipt_covenant");
            });

            modelBuilder.Entity<DeliveryReceiptRequest>(entity =>
            {
                entity.ToTable("Delivery_receipt_request");

                entity.Property(e => e.DeliveryReceiptRequestId).HasColumnName("Delivery_receipt_requestId");

                entity.Property(e => e.Ccto)
                    .HasMaxLength(50)
                    .HasColumnName("CCTO");

                entity.Property(e => e.DeliveryReceiptRequestCurrentDate)
                    .HasColumnType("date")
                    .HasColumnName("Delivery_receipt_requestCurrentDate");

                entity.Property(e => e.DeliveryReceiptRequestDate)
                    .HasColumnType("date")
                    .HasColumnName("Delivery_receipt_requestDate");

                entity.Property(e => e.DeliveryReceiptRequestEmpFrom).HasColumnName("Delivery_receipt_requestEmpFrom");

                entity.Property(e => e.DeliveryReceiptRequestEmpTo).HasColumnName("Delivery_receipt_requestEmpTo");

                entity.Property(e => e.DeliveryReceiptRequestIsIn).HasColumnName("Delivery_receipt_request_IsIn");

                entity.Property(e => e.DeliveryReceiptRequestNote).HasColumnName("Delivery_receipt_requestNote");

                entity.Property(e => e.RequestId).HasColumnName("requestId");

                entity.HasOne(d => d.DeliveryReceiptRequestEmpFromNavigation)
                    .WithMany(p => p.DeliveryReceiptRequestDeliveryReceiptRequestEmpFromNavigations)
                    .HasForeignKey(d => d.DeliveryReceiptRequestEmpFrom)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Delivery_receipt_request_Emp");

                entity.HasOne(d => d.DeliveryReceiptRequestEmpToNavigation)
                    .WithMany(p => p.DeliveryReceiptRequestDeliveryReceiptRequestEmpToNavigations)
                    .HasForeignKey(d => d.DeliveryReceiptRequestEmpTo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Delivery_receipt_request_Emp1");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.DeliveryReceiptRequests)
                    .HasForeignKey(d => d.RequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Delivery_receipt_request_request");
            });

            modelBuilder.Entity<DeliveryReceiptRequestFile>(entity =>
            {
                entity.HasKey(e => e.DeliveryReceiptRequestFilesId);

                entity.ToTable("Delivery_receipt_request_Files");

                entity.Property(e => e.DeliveryReceiptRequestFilesId).HasColumnName("Delivery_receipt_request_FilesId");

                entity.Property(e => e.DeliveryReceiptRequestFileName)
                    .HasMaxLength(50)
                    .HasColumnName("Delivery_receipt_request_FileName");

                entity.Property(e => e.DeliveryReceiptRequestFilePath).HasColumnName("Delivery_receipt_request_FilePath");

                entity.Property(e => e.DeliveryReceiptRequestId).HasColumnName("Delivery_receipt_requestId");

                entity.HasOne(d => d.DeliveryReceiptRequest)
                    .WithMany(p => p.DeliveryReceiptRequestFiles)
                    .HasForeignKey(d => d.DeliveryReceiptRequestId)
                    .HasConstraintName("FK_Delivery_receipt_request_Files_Delivery_receipt_request");
            });

            modelBuilder.Entity<Emp>(entity =>
            {
                entity.ToTable("Emp");

                entity.Property(e => e.EmpIdNumber).HasMaxLength(50);

                entity.Property(e => e.EmpMobile).HasMaxLength(50);

                entity.Property(e => e.EmpNameAr)
                    .HasMaxLength(50)
                    .HasColumnName("EmpNameAR");

                entity.Property(e => e.EmpNameEn)
                    .HasMaxLength(50)
                    .HasColumnName("EmpNameEN");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.EmpNat)
                    .WithMany(p => p.Emps)
                    .HasForeignKey(d => d.EmpNatId)
                    .HasConstraintName("FK_Emp_Nationality");

                entity.HasOne(d => d.EmpSec)
                    .WithMany(p => p.Emps)
                    .HasForeignKey(d => d.EmpSecId)
                    .HasConstraintName("FK_Emp_Section");

                
            });

            modelBuilder.Entity<EngineeringDepartment>(entity =>
            {
                entity.ToTable("EngineeringDepartment");

                entity.Property(e => e.EngineeringDepartmentId).ValueGeneratedOnAdd();

                entity.Property(e => e.Ccto)
                    .HasMaxLength(50)
                    .HasColumnName("CCTO");

                entity.Property(e => e.EngineeringDepartmentDate).HasColumnType("date");

                entity.Property(e => e.EngineeringDepartmentQuantity).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.EngineeringDepartmentCust)
                    .WithMany(p => p.EngineeringDepartments)
                    .HasForeignKey(d => d.EngineeringDepartmentCustId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EngineeringDepartment_Cust");

                entity.HasOne(d => d.EngineeringDepartmentNavigation)
                    .WithOne(p => p.EngineeringDepartment)
                    .HasForeignKey<EngineeringDepartment>(d => d.EngineeringDepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EngineeringDepartment_Emp");

                entity.HasOne(d => d.EngineeringDepartmentItem)
                    .WithMany(p => p.EngineeringDepartments)
                    .HasForeignKey(d => d.EngineeringDepartmentItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EngineeringDepartment_Item");
            });

            modelBuilder.Entity<EngineeringDepartmentFile>(entity =>
            {
                entity.HasKey(e => e.EngineeringDepartmentFilesId);

                entity.ToTable("EngineeringDepartment_Files");

                entity.Property(e => e.EngineeringDepartmentFilesId)
                    .ValueGeneratedNever()
                    .HasColumnName("EngineeringDepartment_FilesId");

                entity.Property(e => e.EngineeringDepartmentFileName)
                    .HasMaxLength(50)
                    .HasColumnName("EngineeringDepartment_FileName");

                entity.Property(e => e.EngineeringDepartmentFilePath).HasColumnName("EngineeringDepartment_FilePath");

                entity.HasOne(d => d.EngineeringDepartment)
                    .WithMany(p => p.EngineeringDepartmentFiles)
                    .HasForeignKey(d => d.EngineeringDepartmentId)
                    .HasConstraintName("FK_EngineeringDepartment_Files_EngineeringDepartment");
            });

            modelBuilder.Entity<Inv>(entity =>
            {
                entity.ToTable("Inv");

                entity.Property(e => e.InvDate).HasColumnType("date");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Invs)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_Inv_Item");
            });

            modelBuilder.Entity<InvFile>(entity =>
            {
                entity.HasKey(e => e.InvFilesId);

                entity.ToTable("Inv_Files");

                entity.Property(e => e.InvFilesId).HasColumnName("Inv_FilesId");

                entity.Property(e => e.InvFileName)
                    .HasMaxLength(50)
                    .HasColumnName("Inv_FileName");

                entity.Property(e => e.InvFilePath).HasColumnName("Inv_FilePath");

                entity.HasOne(d => d.Inv)
                    .WithMany(p => p.InvFiles)
                    .HasForeignKey(d => d.InvId)
                    .HasConstraintName("FK_Inv_Files_Inv");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.ToTable("Item");

                entity.Property(e => e.ItemBrand).HasMaxLength(50);

                entity.Property(e => e.ItemIndustry).HasMaxLength(50);

                entity.Property(e => e.ItemNameAr)
                    .HasMaxLength(50)
                    .HasColumnName("ItemNameAR");

                entity.Property(e => e.ItemNameEn)
                    .HasMaxLength(50)
                    .HasColumnName("ItemNameEN");

                entity.Property(e => e.ItemPrice).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<MaintenanceDepartment>(entity =>
            {
                entity.ToTable("MaintenanceDepartment");

                entity.Property(e => e.Ccto)
                    .HasMaxLength(50)
                    .HasColumnName("CCTO");

                entity.Property(e => e.MaintenanceDepartmentDate).HasColumnType("date");

                entity.Property(e => e.MaintenanceDepartmentQuantity).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.MaintenanceDepartmentCust)
                    .WithMany(p => p.MaintenanceDepartments)
                    .HasForeignKey(d => d.MaintenanceDepartmentCustId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaintenanceDepartment_Cust");

                entity.HasOne(d => d.MaintenanceDepartmentEmp)
                    .WithMany(p => p.MaintenanceDepartments)
                    .HasForeignKey(d => d.MaintenanceDepartmentEmpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaintenanceDepartment_Emp");

                entity.HasOne(d => d.MaintenanceDepartmentItem)
                    .WithMany(p => p.MaintenanceDepartments)
                    .HasForeignKey(d => d.MaintenanceDepartmentItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaintenanceDepartment_Item");
            });

            modelBuilder.Entity<MaintenanceDepartmentFile>(entity =>
            {
                entity.HasKey(e => e.MaintenanceDepartmentFilesId);

                entity.ToTable("MaintenanceDepartment_Files");

                entity.Property(e => e.MaintenanceDepartmentFilesId).HasColumnName("MaintenanceDepartment_FilesId");

                entity.Property(e => e.MaintenanceDepartmentFileName)
                    .HasMaxLength(50)
                    .HasColumnName("MaintenanceDepartment_FileName");

                entity.Property(e => e.MaintenanceDepartmentFilePath).HasColumnName("MaintenanceDepartment_FilePath");

                entity.HasOne(d => d.MaintenanceDepartment)
                    .WithMany(p => p.MaintenanceDepartmentFiles)
                    .HasForeignKey(d => d.MaintenanceDepartmentId)
                    .HasConstraintName("FK_MaintenanceDepartment_Files_MaintenanceDepartment");
            });

            modelBuilder.Entity<MaintenanceReport>(entity =>
            {
                entity.ToTable("MaintenanceReport");

                entity.Property(e => e.MaintenanceReportBatch).HasMaxLength(50);

                entity.Property(e => e.MaintenanceReportDeliveryDate).HasColumnType("date");

                entity.Property(e => e.MaintenanceReportEng).HasMaxLength(50);

                entity.Property(e => e.MaintenanceReportRunOrderDate).HasColumnType("date");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.MaintenanceReports)
                    .HasForeignKey(d => d.CustId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaintenanceReport_Cust");

                entity.HasOne(d => d.MaintenanceReportEmpNavigation)
                    .WithMany(p => p.MaintenanceReports)
                    .HasForeignKey(d => d.MaintenanceReportEmp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaintenanceReport_Emp");
            });

            modelBuilder.Entity<MaintenanceReportFile>(entity =>
            {
                entity.HasKey(e => e.MaintenanceReportFilesId);

                entity.ToTable("MaintenanceReport_Files");

                entity.Property(e => e.MaintenanceReportFilesId).HasColumnName("MaintenanceReport_FilesId");

                entity.Property(e => e.MaintenanceReportFileName)
                    .HasMaxLength(50)
                    .HasColumnName("MaintenanceReport_FileName");

                entity.Property(e => e.MaintenanceReportFilePath).HasColumnName("MaintenanceReport_FilePath");

                entity.HasOne(d => d.MaintenanceReport)
                    .WithMany(p => p.MaintenanceReportFiles)
                    .HasForeignKey(d => d.MaintenanceReportId)
                    .HasConstraintName("FK_MaintenanceReport_Files_MaintenanceReport");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.ToTable("Message");

                entity.Property(e => e.Message1).HasColumnName("Message");

                entity.Property(e => e.MessageDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Nationality>(entity =>
            {
                entity.ToTable("Nationality");

                entity.Property(e => e.NationalityNameAr).HasMaxLength(50);

                entity.Property(e => e.NationalityNameEn).HasMaxLength(50);
            });

            modelBuilder.Entity<Offer>(entity =>
            {
                entity.ToTable("Offer");

                entity.Property(e => e.OfferNameAr).HasMaxLength(50);

                entity.Property(e => e.OfferNameEn).HasMaxLength(50);
            });

            modelBuilder.Entity<Paper>(entity =>
            {
                entity.HasKey(e => e.PapersId);

                entity.Property(e => e.PapersNameAr).HasMaxLength(50);

                entity.Property(e => e.PapersNameEn).HasMaxLength(50);
            });

            modelBuilder.Entity<PricingMatter>(entity =>
            {
                entity.ToTable("PricingMatter");
            });

            modelBuilder.Entity<PricingMatterItem>(entity =>
            {
                entity.ToTable("PricingMatterItem");
            });

            modelBuilder.Entity<ProjectCertificate>(entity =>
            {
                entity.HasKey(e => e.ProjectCertificatesId);

                entity.Property(e => e.ProjectCertificatesBatch).HasMaxLength(50);

                entity.Property(e => e.ProjectCertificatesDeliveryDate).HasColumnType("date");

                entity.Property(e => e.ProjectCertificatesEng).HasMaxLength(50);

                entity.Property(e => e.ProjectCertificatesRunOrderDate).HasColumnType("date");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.ProjectCertificates)
                    .HasForeignKey(d => d.CustId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectCertificates_Cust");

                entity.HasOne(d => d.ProjectCertificatesEmpNavigation)
                    .WithMany(p => p.ProjectCertificates)
                    .HasForeignKey(d => d.ProjectCertificatesEmp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectCertificates_Emp");
            });

            modelBuilder.Entity<ProjectCertificatesFile>(entity =>
            {
                entity.HasKey(e => e.ProjectCertificatesFilesId);

                entity.ToTable("ProjectCertificates_Files");

                entity.Property(e => e.ProjectCertificatesFilesId).HasColumnName("ProjectCertificates_FilesId");

                entity.Property(e => e.ProjectCertificatesFileName)
                    .HasMaxLength(50)
                    .HasColumnName("ProjectCertificates_FileName");

                entity.Property(e => e.ProjectCertificatesFilePath).HasColumnName("ProjectCertificates_FilePath");

                entity.HasOne(d => d.ProjectCertificates)
                    .WithMany(p => p.ProjectCertificatesFiles)
                    .HasForeignKey(d => d.ProjectCertificatesId)
                    .HasConstraintName("FK_ProjectCertificates_Files_ProjectCertificates");
            });

            modelBuilder.Entity<PublicCompany>(entity =>
            {
                entity.ToTable("PublicCompany");

                entity.Property(e => e.PublicCompanyDate).HasColumnType("date");

                entity.Property(e => e.PublicCompanyName).HasMaxLength(50);
            });

            modelBuilder.Entity<PublicCompanyFile>(entity =>
            {
                entity.HasKey(e => e.PublicCompanyFilesId);

                entity.ToTable("PublicCompany_Files");

                entity.Property(e => e.PublicCompanyFilesId).HasColumnName("PublicCompany_FilesId");

                entity.Property(e => e.PublicCompanyFileName)
                    .HasMaxLength(50)
                    .HasColumnName("PublicCompany_FileName");

                entity.Property(e => e.PublicCompanyFilePath).HasColumnName("PublicCompany_FilePath");

                entity.HasOne(d => d.PublicCompany)
                    .WithMany(p => p.PublicCompanyFiles)
                    .HasForeignKey(d => d.PublicCompanyId)
                    .HasConstraintName("FK_PublicCompany_Files_PublicCompany");
            });

            modelBuilder.Entity<PublicCompanySection>(entity =>
            {
                entity.ToTable("PublicCompanySection");

                entity.HasOne(d => d.PublicCompany)
                    .WithMany(p => p.PublicCompanySections)
                    .HasForeignKey(d => d.PublicCompanyId)
                    .HasConstraintName("FK_PublicCompanySection_PublicCompanySection");

                entity.HasOne(d => d.Sec)
                    .WithMany(p => p.PublicCompanySections)
                    .HasForeignKey(d => d.SecId)
                    .HasConstraintName("FK_PublicCompanySection_Section");
            });

            modelBuilder.Entity<PurchaseOrder>(entity =>
            {
                entity.ToTable("PurchaseOrder");

                entity.Property(e => e.Ccto)
                    .HasMaxLength(50)
                    .HasColumnName("CCTO");

                entity.HasOne(d => d.PurchaseOrderEmpFromNavigation)
                    .WithMany(p => p.PurchaseOrderPurchaseOrderEmpFromNavigations)
                    .HasForeignKey(d => d.PurchaseOrderEmpFrom)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrder_Emp1");

                entity.HasOne(d => d.PurchaseOrderEmpToNavigation)
                    .WithMany(p => p.PurchaseOrderPurchaseOrderEmpToNavigations)
                    .HasForeignKey(d => d.PurchaseOrderEmpTo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrder_Emp");
            });

            modelBuilder.Entity<PurchaseOrderItem>(entity =>
            {
                entity.ToTable("PurchaseOrderItem");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.PurchaseOrderItems)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrderItem_Item");

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.PurchaseOrderItems)
                    .HasForeignKey(d => d.PurchaseOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrderItem_PurchaseOrder");
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.ToTable("request");

                entity.Property(e => e.RequestId).HasColumnName("requestId");

                entity.Property(e => e.RequestNameAr)
                    .HasMaxLength(50)
                    .HasColumnName("requestNameAr");

                entity.Property(e => e.RequestNameEn)
                    .HasMaxLength(50)
                    .HasColumnName("requestNameEn");
            });

            modelBuilder.Entity<RequestQuote>(entity =>
            {
                entity.ToTable("RequestQuote");

                entity.Property(e => e.Ccto)
                    .HasMaxLength(50)
                    .HasColumnName("CCTO");

                entity.Property(e => e.RequestQuoteDate).HasColumnType("date");

                entity.Property(e => e.RequestQuoteTotal).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.RequestQuoteCust)
                    .WithMany(p => p.RequestQuotes)
                    .HasForeignKey(d => d.RequestQuoteCustId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestQuote_Cust");

                entity.HasOne(d => d.RequestQuoteEmp)
                    .WithMany(p => p.RequestQuotes)
                    .HasForeignKey(d => d.RequestQuoteEmpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestQuote_Emp");

                entity.HasOne(d => d.RequestQuoteItem)
                    .WithMany(p => p.RequestQuotes)
                    .HasForeignKey(d => d.RequestQuoteItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestQuote_Item");

                entity.HasOne(d => d.RequestQuoteOffer)
                    .WithMany(p => p.RequestQuotes)
                    .HasForeignKey(d => d.RequestQuoteOfferId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestQuote_Offer");
            });

            modelBuilder.Entity<RequestQuoteFile>(entity =>
            {
                entity.HasKey(e => e.RequestQuoteFilesId);

                entity.ToTable("RequestQuote_Files");

                entity.Property(e => e.RequestQuoteFilesId).HasColumnName("RequestQuote_FilesId");

                entity.Property(e => e.RequestQuoteFileName)
                    .HasMaxLength(50)
                    .HasColumnName("RequestQuote_FileName");

                entity.Property(e => e.RequestQuoteFilePath).HasColumnName("RequestQuote_FilePath");

                entity.HasOne(d => d.RequestQuote)
                    .WithMany(p => p.RequestQuoteFiles)
                    .HasForeignKey(d => d.RequestQuoteId)
                    .HasConstraintName("FK_RequestQuote_Files_RequestQuote");
            });

            modelBuilder.Entity<Section>(entity =>
            {
                entity.ToTable("Section");

                entity.Property(e => e.SectionNameAr)
                    .HasMaxLength(50)
                    .HasColumnName("SectionNameAR");

                entity.Property(e => e.SectionNameEn)
                    .HasMaxLength(50)
                    .HasColumnName("SectionNameEN");
            });

            modelBuilder.Entity<VehicleType>(entity =>
            {
                entity.ToTable("VehicleType");

                entity.Property(e => e.VehicleTypeNameAr).HasMaxLength(50);

                entity.Property(e => e.VehicleTypeNameEn).HasMaxLength(50);
            });

            //OnModelCreatingPartial(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
