using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentalTracker.Web.Migrations
{
    public partial class InitialMigration : Migration
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
                name: "AspNetUserRoleMenus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(900)", maxLength: 900, nullable: true),
                    MenuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoleMenus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProfileImage = table.Column<string>(type: "nvarchar(500)", nullable: true),
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
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CountryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "MailLibraries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MailUserId = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    EmailName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Host = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Port = table.Column<int>(type: "int", nullable: false),
                    EnableSsl = table.Column<bool>(type: "bit", nullable: false),
                    UseDefaultCredentials = table.Column<bool>(type: "bit", nullable: false),
                    System = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailLibraries", x => x.Id);
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
                name: "States",
                columns: table => new
                {
                    StateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    StateCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StateName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.StateId);
                    table.ForeignKey(
                        name: "FK_States_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    CityCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_Cities_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TenantMasters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HouseRent = table.Column<int>(type: "int", nullable: false),
                    ReadingPerUnit = table.Column<int>(type: "int", nullable: false),
                    RentStartOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ContactNo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    AlternateNo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    IDType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IDCardNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PreviousAddress = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Pincode = table.Column<int>(type: "int", nullable: false),
                    ProfileImageUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    DocUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TenantMasters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TenantMasters_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CountryCode", "CountryName", "CreatedBy", "CreatedDate", "IsActive", "ShortName", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, "91", "India", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 255, DateTimeKind.Local).AddTicks(4452), true, "IN", null, null });

            migrationBuilder.InsertData(
                table: "MailLibraries",
                columns: new[] { "Id", "EmailAddress", "EmailName", "EnableSsl", "Host", "MailUserId", "Password", "Port", "System", "UseDefaultCredentials" },
                values: new object[] { 1, "kpljain21@gmail.com", "Rental Tracker", true, "smtp.gmail.com", "DNR", ".", 587, true, false });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "StateId", "CountryId", "CreatedBy", "CreatedDate", "IsActive", "ShortName", "StateCode", "StateName", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(2577), true, "AD", "1", "Andaman and Nicobar Islands", null, null },
                    { 32, 1, "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8399), true, "UP", "32", "Uttar Pradesh", null, null },
                    { 31, 1, "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8395), true, "TP", "31", "Tripura", null, null },
                    { 30, 1, "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8391), true, "TL", "30", "Telangana", null, null },
                    { 29, 1, "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8386), true, "TN", "29", "Tamil Nadu", null, null },
                    { 28, 1, "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8380), true, "SK", "28", "Sikkim", null, null },
                    { 27, 1, "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8375), true, "RJ", "27", "Rajasthan", null, null },
                    { 26, 1, "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8371), true, "PB", "26", "Punjab", null, null },
                    { 25, 1, "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8365), true, "PD", "25", "Puducherry", null, null },
                    { 24, 1, "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8358), true, "OD", "24", "Odisha", null, null },
                    { 23, 1, "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8351), true, "NG", "23", "Nagaland", null, null },
                    { 22, 1, "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8348), true, "MZ", "22", "Mizoram", null, null },
                    { 21, 1, "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8344), true, "MG", "21", "Meghalaya", null, null },
                    { 20, 1, "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8339), true, "MN", "20", "Manipur", null, null },
                    { 19, 1, "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8324), true, "MH", "19", "Maharashtra", null, null },
                    { 18, 1, "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8144), true, "MP", "18", "Madhya Pradesh", null, null },
                    { 17, 1, "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8141), true, "LW", "17", "Lakshadweep", null, null },
                    { 16, 1, "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8137), true, "KL", "16", "Kerala", null, null },
                    { 2, 1, "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8044), true, "AN", "2", "Andhra Pradesh", null, null },
                    { 3, 1, "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8076), true, "AP", "3", "Arunachal Pradesh", null, null },
                    { 4, 1, "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8083), true, "AS", "4", "Assam", null, null },
                    { 5, 1, "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8087), true, "BH", "5", "Bihar", null, null },
                    { 6, 1, "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8093), true, "CH", "6", "Chandigarh", null, null },
                    { 7, 1, "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8097), true, "CG", "7", "Chhattisgarh", null, null },
                    { 33, 1, "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8403), true, "UK", "33", "Uttarakhand", null, null },
                    { 8, 1, "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8101), true, "DL", "8", "Delhi", null, null },
                    { 10, 1, "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8112), true, "GJ", "10", "Gujarat", null, null },
                    { 11, 1, "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8117), true, "HR", "11", "Haryana", null, null },
                    { 12, 1, "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8120), true, "HP", "12", "Himachal Pradesh", null, null },
                    { 13, 1, "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8123), true, "JK", "13", "Jammu and Kashmir", null, null },
                    { 14, 1, "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8127), true, "JH", "14", "Jharkhand", null, null },
                    { 15, 1, "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8131), true, "KR", "15", "Karnataka", null, null },
                    { 9, 1, "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8106), true, "GA", "9", "Goa", null, null },
                    { 34, 1, "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8407), true, "WB", "34", "West Bengal", null, null }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityCode", "CityName", "CreatedBy", "CreatedDate", "IsActive", "ShortName", "StateId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "1", "Port Blair", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(444), true, "PB", 1, null, null },
                    { 120, "120", "Jalandhar", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6508), true, "Jalandhar", 26, null, null },
                    { 121, "121", "Patiala", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6518), true, "Patiala", 26, null, null },
                    { 122, "122", "Jaipur", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6522), true, "Jaipur", 27, null, null },
                    { 123, "123", "Kota", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6528), true, "Kota", 27, null, null },
                    { 124, "124", "Jodhpur", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6531), true, "Jodhpur", 27, null, null },
                    { 125, "125", "Ajmer", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6536), true, "Ajmer", 27, null, null },
                    { 126, "126", "Bikaner", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6539), true, "Bikaner", 27, null, null },
                    { 127, "127", "Udaipur", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6544), true, "Udaipur", 27, null, null },
                    { 128, "128", "Sikar", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6548), true, "Sikar", 27, null, null },
                    { 129, "129", "Bhilwara", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6553), true, "Bhilwara", 27, null, null },
                    { 130, "130", "Alwar", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6556), true, "Alwar", 27, null, null },
                    { 131, "131", "Bharatpur", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6563), true, "Bharatpur", 27, null, null },
                    { 132, "132", "Pali", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6567), true, "Pali", 27, null, null },
                    { 133, "133", "Gangtok", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6570), true, "Gangtok", 28, null, null },
                    { 134, "134", "Chennai", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6575), true, "Chennai", 29, null, null },
                    { 135, "135", "Madurai", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6579), true, "Madurai", 29, null, null },
                    { 136, "136", "Coimbatore", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6584), true, "Coimbatore", 29, null, null },
                    { 137, "137", "Trichinopoly", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6588), true, "Trichinopoly", 29, null, null },
                    { 138, "138", "Salem", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6596), true, "Salem", 29, null, null },
                    { 119, "119", "Amritsar", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6503), true, "Amritsar", 26, null, null },
                    { 118, "118", "Ludhiana", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6499), true, "Ludhiana", 26, null, null },
                    { 117, "117", "Puducherry", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6495), true, "Puducherry", 25, null, null },
                    { 116, "116", "Sambalpur", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6490), true, "Sambalpur", 24, null, null },
                    { 96, "96", "Nanded", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6405), true, "Nanded", 19, null, null },
                    { 97, "97", "Chanda", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6408), true, "Chanda", 19, null, null },
                    { 98, "98", "Amravati", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6413), true, "Amravati", 19, null, null },
                    { 99, "99", "Ulhasnagar", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6416), true, "Ulhasnagar", 19, null, null },
                    { 100, "100", "Dhulia", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6421), true, "Dhulia", 19, null, null },
                    { 101, "101", "Jalgaon", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6424), true, "Jalgaon", 19, null, null },
                    { 102, "102", "Sangli", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6429), true, "Sangli", 19, null, null },
                    { 103, "103", "Akola", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6432), true, "Akola", 19, null, null },
                    { 104, "104", "Parbhani", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6438), true, "Parbhani", 19, null, null },
                    { 139, "139", "Tiruppur", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6602), true, "Tiruppur", 29, null, null },
                    { 105, "105", "Latur", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6444), true, "Latur", 19, null, null },
                    { 107, "107", "Ichalkaranji", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6453), true, "Ichalkaranji", 19, null, null },
                    { 108, "108", "Imphal", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6456), true, "Imphal", 20, null, null },
                    { 109, "109", "Shillong", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6461), true, "Shillong", 21, null, null },
                    { 110, "110", "aizawl", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6464), true, "aizawl", 22, null, null },
                    { 111, "111", "Kohima", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6469), true, "Kohima", 23, null, null },
                    { 112, "112", "Bhubaneshwar", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6473), true, "Bhubaneshwar", 24, null, null },
                    { 113, "113", "Raurkela", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6478), true, "Raurkela", 24, null, null }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityCode", "CityName", "CreatedBy", "CreatedDate", "IsActive", "ShortName", "StateId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 114, "114", "Cuttack", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6481), true, "Cuttack", 24, null, null },
                    { 115, "115", "Brahmapur", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6486), true, "Brahmapur", 24, null, null },
                    { 106, "106", "Ahmadnagar", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6447), true, "Ahmadnagar", 19, null, null },
                    { 95, "95", "Malegaon", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6400), true, "Malegaon", 19, null, null },
                    { 140, "140", "Tinnevelly", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6607), true, "Tinnevelly", 29, null, null },
                    { 142, "142", "Rajapalaiyam", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6615), true, "Rajapalaiyam", 29, null, null },
                    { 167, "167", "Mathura", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6806), true, "Mathura", 32, null, null },
                    { 168, "168", "Shahjanpur", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6811), true, "Shahjanpur", 32, null, null },
                    { 169, "169", "Firozabad", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6814), true, "Firozabad", 32, null, null },
                    { 170, "170", "Rampur", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6820), true, "Rampur", 32, null, null },
                    { 171, "171", "Etawah", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6824), true, "Etawah", 32, null, null },
                    { 172, "172", "Hapur", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6830), true, "Hapur", 32, null, null },
                    { 173, "173", "Sambhal", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6833), true, "Sambhal", 32, null, null },
                    { 174, "174", "Dehra Dun", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6836), true, "Dehra Dun", 33, null, null },
                    { 175, "175", "Kolkata", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6841), true, "Kolkata", 34, null, null },
                    { 176, "176", "Haora", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6846), true, "Haora", 34, null, null },
                    { 177, "177", "Durgapur", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6849), true, "Durgapur", 34, null, null },
                    { 178, "178", "asansol", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6855), true, "asansol", 34, null, null },
                    { 179, "179", "Bhatpara", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6859), true, "Bhatpara", 34, null, null },
                    { 180, "180", "Panihati", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6864), true, "Panihati", 34, null, null },
                    { 181, "181", "Kamarhati", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6867), true, "Kamarhati", 34, null, null },
                    { 182, "182", "Barddhaman", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6872), true, "Barddhaman", 34, null, null },
                    { 183, "183", "Kulti", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6875), true, "Kulti", 34, null, null },
                    { 184, "184", "Shiliguri", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6880), true, "Shiliguri", 34, null, null },
                    { 185, "185", "Bali", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6883), true, "Bali", 34, null, null },
                    { 166, "166", "Muzaffarnagar", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6803), true, "Muzaffarnagar", 32, null, null },
                    { 165, "165", "Jhansi", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6798), true, "Jhansi", 32, null, null },
                    { 164, "164", "Gorakhpur", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6795), true, "Gorakhpur", 32, null, null },
                    { 163, "163", "Saharanpur", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6790), true, "Saharanpur", 32, null, null },
                    { 143, "143", "Nagercoil", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6702), true, "Nagercoil", 29, null, null },
                    { 144, "144", "Tanjore", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6711), true, "Tanjore", 29, null, null },
                    { 145, "145", "Hyderabad", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6716), true, "Hyderabad", 30, null, null },
                    { 146, "146", "Warangal", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6719), true, "Warangal", 30, null, null },
                    { 147, "147", "Nizamabad", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6723), true, "Nizamabad", 30, null, null },
                    { 148, "148", "Karimnagar", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6726), true, "Karimnagar", 30, null, null },
                    { 149, "149", "Ramgundam", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6731), true, "Ramgundam", 30, null, null },
                    { 150, "150", "Kagaznagar", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6735), true, "Kagaznagar", 30, null, null },
                    { 151, "151", "Agartala", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6740), true, "Agartala", 31, null, null },
                    { 141, "141", "Tuticorin", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6610), true, "Tuticorin", 29, null, null },
                    { 152, "152", "Lucknow", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6743), true, "Lucknow", 32, null, null },
                    { 154, "154", "Mirzapur", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6754), true, "Mirzapur", 32, null, null },
                    { 155, "155", "Ghaziabad", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6757), true, "Ghaziabad", 32, null, null }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityCode", "CityName", "CreatedBy", "CreatedDate", "IsActive", "ShortName", "StateId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 156, "156", "agra", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6763), true, "agra", 32, null, null },
                    { 157, "157", "Meerut", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6766), true, "Meerut", 32, null, null },
                    { 158, "158", "Allahabad", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6771), true, "Allahabad", 32, null, null },
                    { 159, "159", "Varanasi", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6774), true, "Varanasi", 32, null, null },
                    { 160, "160", "Aligarh", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6779), true, "Aligarh", 32, null, null },
                    { 161, "161", "Bareilly", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6782), true, "Bareilly", 32, null, null },
                    { 162, "162", "Moradabad", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6787), true, "Moradabad", 32, null, null },
                    { 153, "153", "Cawnpore", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6748), true, "Cawnpore", 32, null, null },
                    { 186, "186", "Barasat", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6886), true, "Barasat", 34, null, null },
                    { 94, "94", "Kolhapur", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6392), true, "Kolhapur", 19, null, null },
                    { 92, "92", "Solapur", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6385), true, "Solapur", 19, null, null },
                    { 26, "26", "Bilaspur", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6015), true, "BSP", 7, null, null },
                    { 27, "27", "Drug", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6020), true, "DURG", 7, null, null },
                    { 28, "28", "Delhi", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6027), true, "DLI", 8, null, null },
                    { 29, "29", "New Delhi", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6031), true, "NDLS", 8, null, null },
                    { 30, "30", "Panaji", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6036), true, "PANA", 9, null, null },
                    { 31, "31", "Ahmadabad", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6041), true, "ADI", 10, null, null },
                    { 32, "32", "Surat", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6045), true, "ST", 10, null, null },
                    { 33, "33", "Vadodara", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6053), true, "BRC", 10, null, null },
                    { 34, "34", "Rajkot", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6056), true, "RJT", 10, null, null },
                    { 35, "35", "Bhavnagar", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6062), true, "BVC", 10, null, null },
                    { 36, "36", "Jamnagar", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6068), true, "JAM", 10, null, null },
                    { 37, "37", "Bhuj", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6071), true, "BHUJ", 10, null, null },
                    { 38, "38", "Porbandar", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6077), true, "PBR", 10, null, null },
                    { 39, "39", "Ghandinagar", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6083), true, "GNC", 10, null, null },
                    { 40, "40", "Daman", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6092), true, "VRL", 10, null, null },
                    { 41, "41", "Faridabad", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6095), true, "FDB", 11, null, null },
                    { 42, "42", "Rohtak", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6100), true, "ROK", 11, null, null },
                    { 43, "43", "Hisar", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6103), true, "HSR", 11, null, null },
                    { 44, "44", "Panipat", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6108), true, "PNP", 11, null, null },
                    { 25, "25", "Raipur", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6007), true, "R", 7, null, null },
                    { 24, "24", "Bhilai", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6003), true, "BIA", 7, null, null },
                    { 23, "23", "Chandigarh", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5993), true, "CDG", 6, null, null },
                    { 22, "22", "Begusarai", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5898), true, "BGS", 5, null, null },
                    { 2, "2", "Vishakhapatnam", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5798), true, "VSKP", 2, null, null },
                    { 3, "3", "Vijayawada", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5817), true, "BZA", 2, null, null },
                    { 4, "4", "Guntur", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5821), true, "GNT", 2, null, null },
                    { 5, "5", "Nellore", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5825), true, "NLR", 2, null, null },
                    { 6, "6", "Kurnool", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5831), true, "KRNT", 2, null, null },
                    { 7, "7", "Kakinada", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5835), true, "CCT", 2, null, null },
                    { 8, "8", "Cuddapah", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5840), true, "HX", 2, null, null },
                    { 9, "9", "Rajahmundry", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5844), true, "RJY", 2, null, null }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityCode", "CityName", "CreatedBy", "CreatedDate", "IsActive", "ShortName", "StateId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 10, "10", "Tirupati", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5847), true, "TPTY", 2, null, null },
                    { 45, "45", "Sonipat", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6111), true, "SNP", 11, null, null },
                    { 11, "11", "Anantapur", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5851), true, "ATP", 2, null, null },
                    { 13, "13", "Vizianagaram", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5861), true, "VZM", 2, null, null },
                    { 14, "14", "Itanagar", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5865), true, "ITN", 3, null, null },
                    { 15, "15", "Dispur", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5868), true, "DSP", 4, null, null },
                    { 16, "16", "Guwahati", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5873), true, "GHY", 4, null, null },
                    { 17, "17", "Patna", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5876), true, "PNBE", 5, null, null },
                    { 18, "18", "Gaya", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5880), true, "GAYA", 5, null, null },
                    { 19, "19", "Bhagalpur", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5884), true, "BGP", 5, null, null },
                    { 20, "20", "Muzaffarpur", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5890), true, "MFP", 5, null, null },
                    { 21, "21", "Purnea", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5893), true, "PRNA", 5, null, null },
                    { 12, "12", "Ongole", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5857), true, "OGL", 2, null, null },
                    { 93, "93", "Bhayandar", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6389), true, "Bhayandar", 19, null, null },
                    { 46, "46", "Karnal", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6116), true, "KUN", 11, null, null },
                    { 48, "48", "Shimla", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6125), true, "SML", 12, null, null },
                    { 73, "73", "Trichur", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6230), true, "Trichur", 16, null, null },
                    { 74, "74", "Kavaratti", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6235), true, "Kavaratti", 17, null, null },
                    { 75, "75", "Indore", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6239), true, "Indore", 18, null, null },
                    { 76, "76", "Bhopal", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6244), true, "Bhopal", 18, null, null },
                    { 77, "77", "Jabalpur", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6249), true, "Jabalpur", 18, null, null },
                    { 78, "78", "Gwalior", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6253), true, "Gwalior", 18, null, null },
                    { 79, "79", "Ujjain", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6258), true, "Ujjain", 18, null, null },
                    { 80, "80", "Saugor", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6262), true, "Saugor", 18, null, null },
                    { 81, "81", "Sannai", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6267), true, "Sannai", 18, null, null },
                    { 82, "82", "Ratlam", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6270), true, "Ratlam", 18, null, null },
                    { 83, "83", "Mumbai", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6335), true, "Mumbai", 19, null, null },
                    { 84, "84", "Pune", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6346), true, "Pune", 19, null, null },
                    { 85, "85", "Nagpur", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6349), true, "Nagpur", 19, null, null },
                    { 86, "86", "Chinchvad", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6356), true, "Chinchvad", 19, null, null },
                    { 87, "87", "Kalyan", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6359), true, "Kalyan", 19, null, null },
                    { 88, "88", "Nasik", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6366), true, "Nasik", 19, null, null },
                    { 89, "89", "Aurangabad", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6370), true, "Aurangabad", 19, null, null },
                    { 90, "90", "Thane", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6375), true, "Thane", 19, null, null },
                    { 91, "91", "Bhiwandi", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6381), true, "Bhiwandi", 19, null, null },
                    { 72, "72", "Quilon", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6226), true, "Quilon", 16, null, null },
                    { 71, "71", "Calicut", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6220), true, "Calicut", 16, null, null },
                    { 70, "70", "Kochi", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6217), true, "Kochi", 16, null, null },
                    { 69, "69", "Thiruvananthapuram", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6212), true, "Thiruvananthapuram", 16, null, null },
                    { 49, "49", "Srinagar", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6128), true, "SINA", 13, null, null },
                    { 50, "50", "Jammu", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6135), true, "JAT", 13, null, null },
                    { 51, "51", "Handwara", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6140), true, "HAND", 13, null, null }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityCode", "CityName", "CreatedBy", "CreatedDate", "IsActive", "ShortName", "StateId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 52, "52", "Jamshedpur", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6143), true, "JAMS", 14, null, null },
                    { 53, "53", "Dhanbad", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6148), true, "DHN", 14, null, null },
                    { 54, "54", "Ranchi", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6151), true, "RNC", 14, null, null },
                    { 55, "55", "Bangalore", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6157), true, "BNC", 15, null, null },
                    { 56, "56", "Mysore", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6161), true, "MYS", 15, null, null },
                    { 57, "57", "Hubli", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6165), true, "UBL", 15, null, null },
                    { 47, "47", "Panchkula", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6119), true, "PANCH", 11, null, null },
                    { 58, "58", "Shimoga", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6168), true, "SHIM", 15, null, null },
                    { 60, "60", "Davangere", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6176), true, "DVG", 15, null, null },
                    { 61, "61", "Belgaum", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6180), true, "BLG", 15, null, null },
                    { 62, "62", "Gulbarga", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6184), true, "GR", 15, null, null },
                    { 63, "63", "Bellary", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6188), true, "BAY", 15, null, null },
                    { 64, "64", "Tumkur", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6193), true, "Tumkur", 15, null, null },
                    { 65, "65", "Bijapur", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6196), true, "Bijapur", 15, null, null },
                    { 66, "66", "Bidar", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6201), true, "Bidar", 15, null, null },
                    { 67, "67", "Hospet", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6204), true, "Hospet", 15, null, null },
                    { 68, "68", "Raichur", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6209), true, "Raichur", 15, null, null },
                    { 59, "59", "Mangalore", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6171), true, "MAQ", 15, null, null },
                    { 187, "187", "Uluberiya", "SystemGenerated", new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6890), true, "Uluberiya", 34, null, null }
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
                name: "IX_Cities_StateId",
                table: "Cities",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_States_CountryId",
                table: "States",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_TenantMasters_CityId",
                table: "TenantMasters",
                column: "CityId");
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
                name: "AspNetUserRoleMenus");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "MailLibraries");

            migrationBuilder.DropTable(
                name: "TenantMasters");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
