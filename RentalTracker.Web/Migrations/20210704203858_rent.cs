using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentalTracker.Web.Migrations
{
    public partial class rent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TenantMasters",
                newName: "TenantId");

            migrationBuilder.CreateTable(
                name: "Rents",
                columns: table => new
                {
                    RentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: false),
                    RentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RentAmount = table.Column<double>(type: "float", nullable: false),
                    ReadingUnit = table.Column<int>(type: "int", nullable: false),
                    ReadingAmount = table.Column<double>(type: "float", nullable: false),
                    OtherExcess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherAmount = table.Column<double>(type: "float", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rents", x => x.RentId);
                    table.ForeignKey(
                        name: "FK_Rents_TenantMasters_TenantId",
                        column: x => x.TenantId,
                        principalTable: "TenantMasters",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9524));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9558));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9611));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9651));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9653));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9655));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9722));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9728));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9731));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9735));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9739));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9741));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9754));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9758));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9762));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9769));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9811));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9842));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9882));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9895));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9961));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 174,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9984));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9986));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 180,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 181,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 182,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 183,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 310, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 184,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 310, DateTimeKind.Local).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 185,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 310, DateTimeKind.Local).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 186,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 310, DateTimeKind.Local).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 187,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 310, DateTimeKind.Local).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 307, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(5588));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(5614));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(5618));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(5653));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 2, 8, 56, 309, DateTimeKind.Local).AddTicks(5683));

            migrationBuilder.CreateIndex(
                name: "IX_Rents_TenantId",
                table: "Rents",
                column: "TenantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rents");

            migrationBuilder.RenameColumn(
                name: "TenantId",
                table: "TenantMasters",
                newName: "Id");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(608));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(647));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(656));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(694));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(779));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(788));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(792));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(895));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(948));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(962));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 174,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(991));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 180,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 181,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 182,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 183,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 184,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 185,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 186,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 187,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 733, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 730, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 5, 0, 34, 24, 732, DateTimeKind.Local).AddTicks(7730));
        }
    }
}
