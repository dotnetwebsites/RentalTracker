using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentalTracker.Web.Migrations
{
    public partial class startreading : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "TenantMasters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNo",
                table: "TenantMasters",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "AlternateNo",
                table: "TenantMasters",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StartReading",
                table: "TenantMasters",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StartReading",
                table: "TenantMasters");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "TenantMasters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNo",
                table: "TenantMasters",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "AlternateNo",
                table: "TenantMasters",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5873));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6108));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6151));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6184));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6209));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6335));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6366));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 174,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 180,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 181,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 182,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 183,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 184,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 185,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 186,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 187,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 259, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 255, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 16, 52, 42, 258, DateTimeKind.Local).AddTicks(8407));
        }
    }
}
