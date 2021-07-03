using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentalTracker.Web.Migrations
{
    public partial class tenantmasterupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "TenantMasters");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNo",
                table: "TenantMasters",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "AlternateNo",
                table: "TenantMasters",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "TenantMasters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "TenantMasters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 0, 13, 53, 821, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 0, 13, 53, 851, DateTimeKind.Local).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 0, 13, 53, 852, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.CreateIndex(
                name: "IX_TenantMasters_CityId",
                table: "TenantMasters",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_TenantMasters_Cities_CityId",
                table: "TenantMasters",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TenantMasters_Cities_CityId",
                table: "TenantMasters");

            migrationBuilder.DropIndex(
                name: "IX_TenantMasters_CityId",
                table: "TenantMasters");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "TenantMasters");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "TenantMasters");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNo",
                table: "TenantMasters",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "AlternateNo",
                table: "TenantMasters",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "TenantMasters",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 1, 1, 59, 13, 558, DateTimeKind.Local).AddTicks(2559));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 1, 1, 59, 13, 567, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 1, 1, 59, 13, 569, DateTimeKind.Local).AddTicks(379));
        }
    }
}
