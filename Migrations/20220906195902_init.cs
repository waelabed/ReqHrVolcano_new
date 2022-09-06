using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace web_req_volcano.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarInv",
                columns: table => new
                {
                    CarInvId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarInvDate = table.Column<DateTime>(type: "date", nullable: true),
                    CarInvNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarInv", x => x.CarInvId);
                });

            migrationBuilder.CreateTable(
                name: "Covenant",
                columns: table => new
                {
                    CovenantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CovenantNameAr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CovenantNameEn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Covenant", x => x.CovenantId);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemNameAR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ItemNameEN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ItemBrand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ItemIndustry = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ItemPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    ItemNote = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    MessageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageType = table.Column<int>(type: "int", nullable: true),
                    MessageDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    MessageEmpFrom = table.Column<int>(type: "int", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageEmpTo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.MessageId);
                });

            migrationBuilder.CreateTable(
                name: "Nationality",
                columns: table => new
                {
                    NationalityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalityNameAr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NationalityNameEn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationality", x => x.NationalityId);
                });

            migrationBuilder.CreateTable(
                name: "Offer",
                columns: table => new
                {
                    OfferId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OfferNameAr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OfferNameEn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offer", x => x.OfferId);
                });

            migrationBuilder.CreateTable(
                name: "Papers",
                columns: table => new
                {
                    PapersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PapersNameAr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PapersNameEn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Papers", x => x.PapersId);
                });

            migrationBuilder.CreateTable(
                name: "PricingMatter",
                columns: table => new
                {
                    PricingMatterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PricingMatterEmpFrom = table.Column<int>(type: "int", nullable: false),
                    PricingMatterEmpTo = table.Column<int>(type: "int", nullable: false),
                    PricingMatterNote = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PricingMatter", x => x.PricingMatterId);
                });

            migrationBuilder.CreateTable(
                name: "PricingMatterItem",
                columns: table => new
                {
                    PricingMatterItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PricingMatterId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PricingMatterItem", x => x.PricingMatterItemId);
                });

            migrationBuilder.CreateTable(
                name: "PublicCompany",
                columns: table => new
                {
                    PublicCompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublicCompanyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PublicCompanyDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicCompany", x => x.PublicCompanyId);
                });

            migrationBuilder.CreateTable(
                name: "request",
                columns: table => new
                {
                    requestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    requestNameAr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    requestNameEn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_request", x => x.requestId);
                });

            migrationBuilder.CreateTable(
                name: "Section",
                columns: table => new
                {
                    SectionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionNameAR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SectionNameEN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SectionNote = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section", x => x.SectionId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleType",
                columns: table => new
                {
                    VehicleTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleTypeNameAr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VehicleTypeNameEn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleType", x => x.VehicleTypeId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarInv_Files",
                columns: table => new
                {
                    CarInv_FilesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarInvId = table.Column<int>(type: "int", nullable: true),
                    CarInv_FileName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CarInv_FilePath = table.Column<string>(type: "ntext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarInv_Files", x => x.CarInv_FilesId);
                    table.ForeignKey(
                        name: "FK_CarInv_Files_CarInv",
                        column: x => x.CarInvId,
                        principalTable: "CarInv",
                        principalColumn: "CarInvId");
                });

            migrationBuilder.CreateTable(
                name: "Inv",
                columns: table => new
                {
                    InvId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvDate = table.Column<DateTime>(type: "date", nullable: true),
                    InvNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvQuantity = table.Column<int>(type: "int", nullable: true),
                    ItemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inv", x => x.InvId);
                    table.ForeignKey(
                        name: "FK_Inv_Item",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "ItemId");
                });

            migrationBuilder.CreateTable(
                name: "CompanyPapers",
                columns: table => new
                {
                    CompanyPapersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PapersId = table.Column<int>(type: "int", nullable: true),
                    CompanyPapersDate = table.Column<DateTime>(type: "date", nullable: true),
                    CompanyPapersYear = table.Column<int>(type: "int", nullable: true),
                    CompanyPapersNote = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyPapers", x => x.CompanyPapersId);
                    table.ForeignKey(
                        name: "FK_CompanyPapers_Papers",
                        column: x => x.PapersId,
                        principalTable: "Papers",
                        principalColumn: "PapersId");
                });

            migrationBuilder.CreateTable(
                name: "PublicCompany_Files",
                columns: table => new
                {
                    PublicCompany_FilesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublicCompanyId = table.Column<int>(type: "int", nullable: true),
                    PublicCompany_FileName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PublicCompany_FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicCompany_Files", x => x.PublicCompany_FilesId);
                    table.ForeignKey(
                        name: "FK_PublicCompany_Files_PublicCompany",
                        column: x => x.PublicCompanyId,
                        principalTable: "PublicCompany",
                        principalColumn: "PublicCompanyId");
                });

            migrationBuilder.CreateTable(
                name: "Emp",
                columns: table => new
                {
                    EmpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpNameAR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmpNameEN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmpMobile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmpIdNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmpNatId = table.Column<int>(type: "int", nullable: true),
                    EmpSecId = table.Column<int>(type: "int", nullable: true),
                    EmpIsPosetion = table.Column<bool>(type: "bit", nullable: true),
                    EmpNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emp", x => x.EmpId);
                    table.ForeignKey(
                        name: "FK_Emp_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Emp_Nationality",
                        column: x => x.EmpNatId,
                        principalTable: "Nationality",
                        principalColumn: "NationalityId");
                    table.ForeignKey(
                        name: "FK_Emp_Section",
                        column: x => x.EmpSecId,
                        principalTable: "Section",
                        principalColumn: "SectionId");
                });

            migrationBuilder.CreateTable(
                name: "PublicCompanySection",
                columns: table => new
                {
                    PublicCompanySectionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublicCompanyId = table.Column<int>(type: "int", nullable: true),
                    SecId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicCompanySection", x => x.PublicCompanySectionId);
                    table.ForeignKey(
                        name: "FK_PublicCompanySection_PublicCompanySection",
                        column: x => x.PublicCompanyId,
                        principalTable: "PublicCompany",
                        principalColumn: "PublicCompanyId");
                    table.ForeignKey(
                        name: "FK_PublicCompanySection_Section",
                        column: x => x.SecId,
                        principalTable: "Section",
                        principalColumn: "SectionId");
                });

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleTypeId = table.Column<int>(type: "int", nullable: true),
                    CarSpecifications = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CarIdNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CarNote = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.CarId);
                    table.ForeignKey(
                        name: "FK_Car_VehicleType",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleType",
                        principalColumn: "VehicleTypeId");
                });

            migrationBuilder.CreateTable(
                name: "Inv_Files",
                columns: table => new
                {
                    Inv_FilesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvId = table.Column<int>(type: "int", nullable: true),
                    Inv_FileName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Inv_FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inv_Files", x => x.Inv_FilesId);
                    table.ForeignKey(
                        name: "FK_Inv_Files_Inv",
                        column: x => x.InvId,
                        principalTable: "Inv",
                        principalColumn: "InvId");
                });

            migrationBuilder.CreateTable(
                name: "CompanyPapers_Files",
                columns: table => new
                {
                    CompanyPapers_FilesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyPapersId = table.Column<int>(type: "int", nullable: true),
                    CompanyPapers_FileName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CompanyPapers_FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyPapers_Files", x => x.CompanyPapers_FilesId);
                    table.ForeignKey(
                        name: "FK_CompanyPapers_Files_CompanyPapers",
                        column: x => x.CompanyPapersId,
                        principalTable: "CompanyPapers",
                        principalColumn: "CompanyPapersId");
                });

            migrationBuilder.CreateTable(
                name: "Cust",
                columns: table => new
                {
                    CustId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustNameAR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CustNameEN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CustIdNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CustResponsible = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CustEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CustRegion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CustCommissioner = table.Column<int>(type: "int", nullable: true),
                    CustNote = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cust", x => x.CustId);
                    table.ForeignKey(
                        name: "FK_Cust_Emp",
                        column: x => x.CustCommissioner,
                        principalTable: "Emp",
                        principalColumn: "EmpId");
                });

            migrationBuilder.CreateTable(
                name: "Delivery_receipt_covenant",
                columns: table => new
                {
                    Delivery_receipt_covenantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Delivery_receipt_covenantEmpFrom = table.Column<int>(type: "int", nullable: false),
                    Delivery_receipt_covenantEmpTo = table.Column<int>(type: "int", nullable: false),
                    CovenantId = table.Column<int>(type: "int", nullable: false),
                    Delivery_receipt_covenant_IsIn = table.Column<bool>(type: "bit", nullable: true),
                    Delivery_receipt_covenantCurrentDate = table.Column<DateTime>(type: "date", nullable: true),
                    Delivery_receipt_covenantDate = table.Column<DateTime>(type: "date", nullable: true),
                    Delivery_receipt_covenantNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CCTO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delivery_receipt_covenant", x => x.Delivery_receipt_covenantId);
                    table.ForeignKey(
                        name: "FK_Delivery_receipt_covenant_Covenant",
                        column: x => x.CovenantId,
                        principalTable: "Covenant",
                        principalColumn: "CovenantId");
                    table.ForeignKey(
                        name: "FK_Delivery_receipt_covenant_Emp",
                        column: x => x.Delivery_receipt_covenantEmpFrom,
                        principalTable: "Emp",
                        principalColumn: "EmpId");
                    table.ForeignKey(
                        name: "FK_Delivery_receipt_covenant_Emp1",
                        column: x => x.Delivery_receipt_covenantEmpTo,
                        principalTable: "Emp",
                        principalColumn: "EmpId");
                });

            migrationBuilder.CreateTable(
                name: "Delivery_receipt_request",
                columns: table => new
                {
                    Delivery_receipt_requestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Delivery_receipt_requestEmpFrom = table.Column<int>(type: "int", nullable: false),
                    Delivery_receipt_requestEmpTo = table.Column<int>(type: "int", nullable: false),
                    requestId = table.Column<int>(type: "int", nullable: false),
                    Delivery_receipt_request_IsIn = table.Column<bool>(type: "bit", nullable: true),
                    Delivery_receipt_requestDate = table.Column<DateTime>(type: "date", nullable: true),
                    Delivery_receipt_requestCurrentDate = table.Column<DateTime>(type: "date", nullable: true),
                    Delivery_receipt_requestNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CCTO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delivery_receipt_request", x => x.Delivery_receipt_requestId);
                    table.ForeignKey(
                        name: "FK_Delivery_receipt_request_Emp",
                        column: x => x.Delivery_receipt_requestEmpFrom,
                        principalTable: "Emp",
                        principalColumn: "EmpId");
                    table.ForeignKey(
                        name: "FK_Delivery_receipt_request_Emp1",
                        column: x => x.Delivery_receipt_requestEmpTo,
                        principalTable: "Emp",
                        principalColumn: "EmpId");
                    table.ForeignKey(
                        name: "FK_Delivery_receipt_request_request",
                        column: x => x.requestId,
                        principalTable: "request",
                        principalColumn: "requestId");
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrder",
                columns: table => new
                {
                    PurchaseOrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseOrderEmpFrom = table.Column<int>(type: "int", nullable: false),
                    PurchaseOrderEmpTo = table.Column<int>(type: "int", nullable: false),
                    PurchaseOrderNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CCTO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrder", x => x.PurchaseOrderId);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_Emp",
                        column: x => x.PurchaseOrderEmpTo,
                        principalTable: "Emp",
                        principalColumn: "EmpId");
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_Emp1",
                        column: x => x.PurchaseOrderEmpFrom,
                        principalTable: "Emp",
                        principalColumn: "EmpId");
                });

            migrationBuilder.CreateTable(
                name: "Delivery_Receipt_Car",
                columns: table => new
                {
                    Delivery_Receipt_CarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Delivery_Receipt_CarEmpFrom = table.Column<int>(type: "int", nullable: true),
                    Delivery_Receipt_CarEmpTo = table.Column<int>(type: "int", nullable: true),
                    CarId = table.Column<int>(type: "int", nullable: true),
                    Delivery_Receipt_CarDate = table.Column<DateTime>(type: "date", nullable: true),
                    Delivery_Receipt_CarCurrentDate = table.Column<DateTime>(type: "date", nullable: true),
                    Delivery_Receipt_Car_IsIn = table.Column<short>(type: "smallint", nullable: true),
                    Delivery_Receipt_CarNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CCTO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delivery_Receipt_Car", x => x.Delivery_Receipt_CarId);
                    table.ForeignKey(
                        name: "FK_Delivery_Receipt_Car_Car",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "CarId");
                    table.ForeignKey(
                        name: "FK_Delivery_Receipt_Car_Emp",
                        column: x => x.Delivery_Receipt_CarEmpFrom,
                        principalTable: "Emp",
                        principalColumn: "EmpId");
                    table.ForeignKey(
                        name: "FK_Delivery_Receipt_Car_Emp1",
                        column: x => x.Delivery_Receipt_CarEmpTo,
                        principalTable: "Emp",
                        principalColumn: "EmpId");
                });

            migrationBuilder.CreateTable(
                name: "CustomerStatement",
                columns: table => new
                {
                    CustomerStatementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerStatementEmpFrom = table.Column<int>(type: "int", nullable: false),
                    CustomerStatementEmpTo = table.Column<int>(type: "int", nullable: false),
                    CustomerStatementDate = table.Column<DateTime>(type: "date", nullable: true),
                    CustomerStatementCustId = table.Column<int>(type: "int", nullable: true),
                    CustomerStatementNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CCTO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerStatement", x => x.CustomerStatementId);
                    table.ForeignKey(
                        name: "FK_CustomerStatement_Cust",
                        column: x => x.CustomerStatementCustId,
                        principalTable: "Cust",
                        principalColumn: "CustId");
                    table.ForeignKey(
                        name: "FK_CustomerStatement_Emp",
                        column: x => x.CustomerStatementEmpTo,
                        principalTable: "Emp",
                        principalColumn: "EmpId");
                    table.ForeignKey(
                        name: "FK_CustomerStatement_Emp1",
                        column: x => x.CustomerStatementEmpFrom,
                        principalTable: "Emp",
                        principalColumn: "EmpId");
                });

            migrationBuilder.CreateTable(
                name: "EngineeringDepartment",
                columns: table => new
                {
                    EngineeringDepartmentId = table.Column<int>(type: "int", nullable: false),
                    EngineeringDepartmentEmpId = table.Column<int>(type: "int", nullable: false),
                    EngineeringDepartmentCustId = table.Column<int>(type: "int", nullable: false),
                    EngineeringDepartmentItemId = table.Column<int>(type: "int", nullable: false),
                    EngineeringDepartmentQuantity = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    EngineeringDepartmentTotal = table.Column<int>(type: "int", nullable: true),
                    EngineeringDepartmentNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngineeringDepartmentDate = table.Column<DateTime>(type: "date", nullable: true),
                    CCTO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngineeringDepartmentEmpTo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EngineeringDepartment", x => x.EngineeringDepartmentId);
                    table.ForeignKey(
                        name: "FK_EngineeringDepartment_Cust",
                        column: x => x.EngineeringDepartmentCustId,
                        principalTable: "Cust",
                        principalColumn: "CustId");
                    table.ForeignKey(
                        name: "FK_EngineeringDepartment_Emp",
                        column: x => x.EngineeringDepartmentId,
                        principalTable: "Emp",
                        principalColumn: "EmpId");
                    table.ForeignKey(
                        name: "FK_EngineeringDepartment_Item",
                        column: x => x.EngineeringDepartmentItemId,
                        principalTable: "Item",
                        principalColumn: "ItemId");
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceDepartment",
                columns: table => new
                {
                    MaintenanceDepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaintenanceDepartmentEmpId = table.Column<int>(type: "int", nullable: false),
                    MaintenanceDepartmentCustId = table.Column<int>(type: "int", nullable: false),
                    MaintenanceDepartmentItemId = table.Column<int>(type: "int", nullable: false),
                    MaintenanceDepartmentQuantity = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    MaintenanceDepartmentTotal = table.Column<int>(type: "int", nullable: true),
                    MaintenanceDepartmentNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaintenanceDepartmentDate = table.Column<DateTime>(type: "date", nullable: true),
                    CCTO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceDepartment", x => x.MaintenanceDepartmentId);
                    table.ForeignKey(
                        name: "FK_MaintenanceDepartment_Cust",
                        column: x => x.MaintenanceDepartmentCustId,
                        principalTable: "Cust",
                        principalColumn: "CustId");
                    table.ForeignKey(
                        name: "FK_MaintenanceDepartment_Emp",
                        column: x => x.MaintenanceDepartmentEmpId,
                        principalTable: "Emp",
                        principalColumn: "EmpId");
                    table.ForeignKey(
                        name: "FK_MaintenanceDepartment_Item",
                        column: x => x.MaintenanceDepartmentItemId,
                        principalTable: "Item",
                        principalColumn: "ItemId");
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceReport",
                columns: table => new
                {
                    MaintenanceReportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustId = table.Column<int>(type: "int", nullable: false),
                    MaintenanceReportBatch = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MaintenanceReportRunOrderDate = table.Column<DateTime>(type: "date", nullable: true),
                    MaintenanceReportDeliveryDate = table.Column<DateTime>(type: "date", nullable: true),
                    MaintenanceReportEng = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MaintenanceReportEmp = table.Column<int>(type: "int", nullable: false),
                    MaintenanceReportNote = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceReport", x => x.MaintenanceReportId);
                    table.ForeignKey(
                        name: "FK_MaintenanceReport_Cust",
                        column: x => x.CustId,
                        principalTable: "Cust",
                        principalColumn: "CustId");
                    table.ForeignKey(
                        name: "FK_MaintenanceReport_Emp",
                        column: x => x.MaintenanceReportEmp,
                        principalTable: "Emp",
                        principalColumn: "EmpId");
                });

            migrationBuilder.CreateTable(
                name: "ProjectCertificates",
                columns: table => new
                {
                    ProjectCertificatesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustId = table.Column<int>(type: "int", nullable: false),
                    ProjectCertificatesBatch = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProjectCertificatesRunOrderDate = table.Column<DateTime>(type: "date", nullable: true),
                    ProjectCertificatesDeliveryDate = table.Column<DateTime>(type: "date", nullable: true),
                    ProjectCertificatesEng = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProjectCertificatesEmp = table.Column<int>(type: "int", nullable: false),
                    ProjectCertificatesNote = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectCertificates", x => x.ProjectCertificatesId);
                    table.ForeignKey(
                        name: "FK_ProjectCertificates_Cust",
                        column: x => x.CustId,
                        principalTable: "Cust",
                        principalColumn: "CustId");
                    table.ForeignKey(
                        name: "FK_ProjectCertificates_Emp",
                        column: x => x.ProjectCertificatesEmp,
                        principalTable: "Emp",
                        principalColumn: "EmpId");
                });

            migrationBuilder.CreateTable(
                name: "RequestQuote",
                columns: table => new
                {
                    RequestQuoteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestQuoteEmpId = table.Column<int>(type: "int", nullable: false),
                    RequestQuoteItemId = table.Column<int>(type: "int", nullable: false),
                    RequestQuoteCustId = table.Column<int>(type: "int", nullable: false),
                    RequestQuoteOfferId = table.Column<int>(type: "int", nullable: false),
                    RequestQuoteQuantity = table.Column<int>(type: "int", nullable: false),
                    RequestQuoteTotal = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    RequestQuoteNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestQuoteDate = table.Column<DateTime>(type: "date", nullable: true),
                    CCTO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngineeringDepartmentEmpTo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestQuote", x => x.RequestQuoteId);
                    table.ForeignKey(
                        name: "FK_RequestQuote_Cust",
                        column: x => x.RequestQuoteCustId,
                        principalTable: "Cust",
                        principalColumn: "CustId");
                    table.ForeignKey(
                        name: "FK_RequestQuote_Emp",
                        column: x => x.RequestQuoteEmpId,
                        principalTable: "Emp",
                        principalColumn: "EmpId");
                    table.ForeignKey(
                        name: "FK_RequestQuote_Item",
                        column: x => x.RequestQuoteItemId,
                        principalTable: "Item",
                        principalColumn: "ItemId");
                    table.ForeignKey(
                        name: "FK_RequestQuote_Offer",
                        column: x => x.RequestQuoteOfferId,
                        principalTable: "Offer",
                        principalColumn: "OfferId");
                });

            migrationBuilder.CreateTable(
                name: "Delivery_receipt_covenant_Files",
                columns: table => new
                {
                    Delivery_receipt_covenant_FilesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Delivery_receipt_covenantId = table.Column<int>(type: "int", nullable: true),
                    Delivery_receipt_covenant_FileName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Delivery_receipt_covenant_FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delivery_receipt_covenant_Files", x => x.Delivery_receipt_covenant_FilesId);
                    table.ForeignKey(
                        name: "FK_Delivery_receipt_covenant_Files_Delivery_receipt_covenant",
                        column: x => x.Delivery_receipt_covenantId,
                        principalTable: "Delivery_receipt_covenant",
                        principalColumn: "Delivery_receipt_covenantId");
                });

            migrationBuilder.CreateTable(
                name: "Delivery_receipt_request_Files",
                columns: table => new
                {
                    Delivery_receipt_request_FilesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Delivery_receipt_requestId = table.Column<int>(type: "int", nullable: true),
                    Delivery_receipt_request_FileName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Delivery_receipt_request_FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delivery_receipt_request_Files", x => x.Delivery_receipt_request_FilesId);
                    table.ForeignKey(
                        name: "FK_Delivery_receipt_request_Files_Delivery_receipt_request",
                        column: x => x.Delivery_receipt_requestId,
                        principalTable: "Delivery_receipt_request",
                        principalColumn: "Delivery_receipt_requestId");
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrderItem",
                columns: table => new
                {
                    PurchaseOrderItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseOrderId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrderItem", x => x.PurchaseOrderItemId);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderItem_Item",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "ItemId");
                    table.ForeignKey(
                        name: "FK_PurchaseOrderItem_PurchaseOrder",
                        column: x => x.PurchaseOrderId,
                        principalTable: "PurchaseOrder",
                        principalColumn: "PurchaseOrderId");
                });

            migrationBuilder.CreateTable(
                name: "Delivery_Receipt_Car_Files",
                columns: table => new
                {
                    Delivery_Receipt_Car_FilesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Delivery_Receipt_CarId = table.Column<int>(type: "int", nullable: true),
                    Delivery_Receipt_Car_FileName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Delivery_Receipt_Car_FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delivery_Receipt_Car_Files", x => x.Delivery_Receipt_Car_FilesId);
                    table.ForeignKey(
                        name: "FK_Delivery_Receipt_Car_Files_Delivery_Receipt_Car",
                        column: x => x.Delivery_Receipt_CarId,
                        principalTable: "Delivery_Receipt_Car",
                        principalColumn: "Delivery_Receipt_CarId");
                });

            migrationBuilder.CreateTable(
                name: "EngineeringDepartment_Files",
                columns: table => new
                {
                    EngineeringDepartment_FilesId = table.Column<int>(type: "int", nullable: false),
                    EngineeringDepartmentId = table.Column<int>(type: "int", nullable: true),
                    EngineeringDepartment_FileName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EngineeringDepartment_FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EngineeringDepartment_Files", x => x.EngineeringDepartment_FilesId);
                    table.ForeignKey(
                        name: "FK_EngineeringDepartment_Files_EngineeringDepartment",
                        column: x => x.EngineeringDepartmentId,
                        principalTable: "EngineeringDepartment",
                        principalColumn: "EngineeringDepartmentId");
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceDepartment_Files",
                columns: table => new
                {
                    MaintenanceDepartment_FilesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaintenanceDepartmentId = table.Column<int>(type: "int", nullable: true),
                    MaintenanceDepartment_FileName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MaintenanceDepartment_FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceDepartment_Files", x => x.MaintenanceDepartment_FilesId);
                    table.ForeignKey(
                        name: "FK_MaintenanceDepartment_Files_MaintenanceDepartment",
                        column: x => x.MaintenanceDepartmentId,
                        principalTable: "MaintenanceDepartment",
                        principalColumn: "MaintenanceDepartmentId");
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceReport_Files",
                columns: table => new
                {
                    MaintenanceReport_FilesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaintenanceReportId = table.Column<int>(type: "int", nullable: true),
                    MaintenanceReport_FileName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MaintenanceReport_FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceReport_Files", x => x.MaintenanceReport_FilesId);
                    table.ForeignKey(
                        name: "FK_MaintenanceReport_Files_MaintenanceReport",
                        column: x => x.MaintenanceReportId,
                        principalTable: "MaintenanceReport",
                        principalColumn: "MaintenanceReportId");
                });

            migrationBuilder.CreateTable(
                name: "ProjectCertificates_Files",
                columns: table => new
                {
                    ProjectCertificates_FilesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectCertificatesId = table.Column<int>(type: "int", nullable: true),
                    ProjectCertificates_FileName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProjectCertificates_FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectCertificates_Files", x => x.ProjectCertificates_FilesId);
                    table.ForeignKey(
                        name: "FK_ProjectCertificates_Files_ProjectCertificates",
                        column: x => x.ProjectCertificatesId,
                        principalTable: "ProjectCertificates",
                        principalColumn: "ProjectCertificatesId");
                });

            migrationBuilder.CreateTable(
                name: "RequestQuote_Files",
                columns: table => new
                {
                    RequestQuote_FilesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestQuoteId = table.Column<int>(type: "int", nullable: true),
                    RequestQuote_FileName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RequestQuote_FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestQuote_Files", x => x.RequestQuote_FilesId);
                    table.ForeignKey(
                        name: "FK_RequestQuote_Files_RequestQuote",
                        column: x => x.RequestQuoteId,
                        principalTable: "RequestQuote",
                        principalColumn: "RequestQuoteId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Car_VehicleTypeId",
                table: "Car",
                column: "VehicleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CarInv_Files_CarInvId",
                table: "CarInv_Files",
                column: "CarInvId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyPapers_PapersId",
                table: "CompanyPapers",
                column: "PapersId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyPapers_Files_CompanyPapersId",
                table: "CompanyPapers_Files",
                column: "CompanyPapersId");

            migrationBuilder.CreateIndex(
                name: "IX_Cust_CustCommissioner",
                table: "Cust",
                column: "CustCommissioner");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerStatement_CustomerStatementCustId",
                table: "CustomerStatement",
                column: "CustomerStatementCustId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerStatement_CustomerStatementEmpFrom",
                table: "CustomerStatement",
                column: "CustomerStatementEmpFrom");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerStatement_CustomerStatementEmpTo",
                table: "CustomerStatement",
                column: "CustomerStatementEmpTo");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_Receipt_Car_CarId",
                table: "Delivery_Receipt_Car",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_Receipt_Car_Delivery_Receipt_CarEmpFrom",
                table: "Delivery_Receipt_Car",
                column: "Delivery_Receipt_CarEmpFrom");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_Receipt_Car_Delivery_Receipt_CarEmpTo",
                table: "Delivery_Receipt_Car",
                column: "Delivery_Receipt_CarEmpTo");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_Receipt_Car_Files_Delivery_Receipt_CarId",
                table: "Delivery_Receipt_Car_Files",
                column: "Delivery_Receipt_CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_receipt_covenant_CovenantId",
                table: "Delivery_receipt_covenant",
                column: "CovenantId");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_receipt_covenant_Delivery_receipt_covenantEmpFrom",
                table: "Delivery_receipt_covenant",
                column: "Delivery_receipt_covenantEmpFrom");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_receipt_covenant_Delivery_receipt_covenantEmpTo",
                table: "Delivery_receipt_covenant",
                column: "Delivery_receipt_covenantEmpTo");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_receipt_covenant_Files_Delivery_receipt_covenantId",
                table: "Delivery_receipt_covenant_Files",
                column: "Delivery_receipt_covenantId");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_receipt_request_Delivery_receipt_requestEmpFrom",
                table: "Delivery_receipt_request",
                column: "Delivery_receipt_requestEmpFrom");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_receipt_request_Delivery_receipt_requestEmpTo",
                table: "Delivery_receipt_request",
                column: "Delivery_receipt_requestEmpTo");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_receipt_request_requestId",
                table: "Delivery_receipt_request",
                column: "requestId");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_receipt_request_Files_Delivery_receipt_requestId",
                table: "Delivery_receipt_request_Files",
                column: "Delivery_receipt_requestId");

            migrationBuilder.CreateIndex(
                name: "IX_Emp_EmpNatId",
                table: "Emp",
                column: "EmpNatId");

            migrationBuilder.CreateIndex(
                name: "IX_Emp_EmpSecId",
                table: "Emp",
                column: "EmpSecId");

            migrationBuilder.CreateIndex(
                name: "IX_Emp_UserId",
                table: "Emp",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EngineeringDepartment_EngineeringDepartmentCustId",
                table: "EngineeringDepartment",
                column: "EngineeringDepartmentCustId");

            migrationBuilder.CreateIndex(
                name: "IX_EngineeringDepartment_EngineeringDepartmentItemId",
                table: "EngineeringDepartment",
                column: "EngineeringDepartmentItemId");

            migrationBuilder.CreateIndex(
                name: "IX_EngineeringDepartment_Files_EngineeringDepartmentId",
                table: "EngineeringDepartment_Files",
                column: "EngineeringDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Inv_ItemId",
                table: "Inv",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Inv_Files_InvId",
                table: "Inv_Files",
                column: "InvId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceDepartment_MaintenanceDepartmentCustId",
                table: "MaintenanceDepartment",
                column: "MaintenanceDepartmentCustId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceDepartment_MaintenanceDepartmentEmpId",
                table: "MaintenanceDepartment",
                column: "MaintenanceDepartmentEmpId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceDepartment_MaintenanceDepartmentItemId",
                table: "MaintenanceDepartment",
                column: "MaintenanceDepartmentItemId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceDepartment_Files_MaintenanceDepartmentId",
                table: "MaintenanceDepartment_Files",
                column: "MaintenanceDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceReport_CustId",
                table: "MaintenanceReport",
                column: "CustId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceReport_MaintenanceReportEmp",
                table: "MaintenanceReport",
                column: "MaintenanceReportEmp");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceReport_Files_MaintenanceReportId",
                table: "MaintenanceReport_Files",
                column: "MaintenanceReportId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectCertificates_CustId",
                table: "ProjectCertificates",
                column: "CustId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectCertificates_ProjectCertificatesEmp",
                table: "ProjectCertificates",
                column: "ProjectCertificatesEmp");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectCertificates_Files_ProjectCertificatesId",
                table: "ProjectCertificates_Files",
                column: "ProjectCertificatesId");

            migrationBuilder.CreateIndex(
                name: "IX_PublicCompany_Files_PublicCompanyId",
                table: "PublicCompany_Files",
                column: "PublicCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_PublicCompanySection_PublicCompanyId",
                table: "PublicCompanySection",
                column: "PublicCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_PublicCompanySection_SecId",
                table: "PublicCompanySection",
                column: "SecId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_PurchaseOrderEmpFrom",
                table: "PurchaseOrder",
                column: "PurchaseOrderEmpFrom");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_PurchaseOrderEmpTo",
                table: "PurchaseOrder",
                column: "PurchaseOrderEmpTo");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderItem_ItemId",
                table: "PurchaseOrderItem",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderItem_PurchaseOrderId",
                table: "PurchaseOrderItem",
                column: "PurchaseOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestQuote_RequestQuoteCustId",
                table: "RequestQuote",
                column: "RequestQuoteCustId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestQuote_RequestQuoteEmpId",
                table: "RequestQuote",
                column: "RequestQuoteEmpId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestQuote_RequestQuoteItemId",
                table: "RequestQuote",
                column: "RequestQuoteItemId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestQuote_RequestQuoteOfferId",
                table: "RequestQuote",
                column: "RequestQuoteOfferId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestQuote_Files_RequestQuoteId",
                table: "RequestQuote_Files",
                column: "RequestQuoteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CarInv_Files");

            migrationBuilder.DropTable(
                name: "CompanyPapers_Files");

            migrationBuilder.DropTable(
                name: "CustomerStatement");

            migrationBuilder.DropTable(
                name: "Delivery_Receipt_Car_Files");

            migrationBuilder.DropTable(
                name: "Delivery_receipt_covenant_Files");

            migrationBuilder.DropTable(
                name: "Delivery_receipt_request_Files");

            migrationBuilder.DropTable(
                name: "EngineeringDepartment_Files");

            migrationBuilder.DropTable(
                name: "Inv_Files");

            migrationBuilder.DropTable(
                name: "MaintenanceDepartment_Files");

            migrationBuilder.DropTable(
                name: "MaintenanceReport_Files");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "PricingMatter");

            migrationBuilder.DropTable(
                name: "PricingMatterItem");

            migrationBuilder.DropTable(
                name: "ProjectCertificates_Files");

            migrationBuilder.DropTable(
                name: "PublicCompany_Files");

            migrationBuilder.DropTable(
                name: "PublicCompanySection");

            migrationBuilder.DropTable(
                name: "PurchaseOrderItem");

            migrationBuilder.DropTable(
                name: "RequestQuote_Files");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "CarInv");

            migrationBuilder.DropTable(
                name: "CompanyPapers");

            migrationBuilder.DropTable(
                name: "Delivery_Receipt_Car");

            migrationBuilder.DropTable(
                name: "Delivery_receipt_covenant");

            migrationBuilder.DropTable(
                name: "Delivery_receipt_request");

            migrationBuilder.DropTable(
                name: "EngineeringDepartment");

            migrationBuilder.DropTable(
                name: "Inv");

            migrationBuilder.DropTable(
                name: "MaintenanceDepartment");

            migrationBuilder.DropTable(
                name: "MaintenanceReport");

            migrationBuilder.DropTable(
                name: "ProjectCertificates");

            migrationBuilder.DropTable(
                name: "PublicCompany");

            migrationBuilder.DropTable(
                name: "PurchaseOrder");

            migrationBuilder.DropTable(
                name: "RequestQuote");

            migrationBuilder.DropTable(
                name: "Papers");

            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "Covenant");

            migrationBuilder.DropTable(
                name: "request");

            migrationBuilder.DropTable(
                name: "Cust");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Offer");

            migrationBuilder.DropTable(
                name: "VehicleType");

            migrationBuilder.DropTable(
                name: "Emp");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Nationality");

            migrationBuilder.DropTable(
                name: "Section");
        }
    }
}
