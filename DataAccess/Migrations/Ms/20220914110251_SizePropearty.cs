using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations.Ms
{
    public partial class SizePropearty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "WareHouses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 285, DateTimeKind.Local).AddTicks(1867), new DateTime(2022, 9, 14, 14, 2, 51, 286, DateTimeKind.Local).AddTicks(2119) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 286, DateTimeKind.Local).AddTicks(3393), new DateTime(2022, 9, 14, 14, 2, 51, 286, DateTimeKind.Local).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(5608), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(5633) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6515), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6519) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6522), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6523) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6524), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6527), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6527) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6532), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6533) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6535), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6537), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6538) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6539), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6542), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6543) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6544), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6545) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6547), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6547) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6549), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6551), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6552) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6553), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6554) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6556), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6557) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6559), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6562), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6563) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6564), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6565) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6566), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6567) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6569), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6569) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6571), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6572) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6573), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6574) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6575), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6576) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6577), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6578) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6580), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6581) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6582), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6583) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6584), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6587), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6589), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6591), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6592) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6593), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6594) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6596), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6596) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6598), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6599) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6601), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6602) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6603), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6604) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6605), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6606) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6607), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6608) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6610), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6610) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6612), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6613) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6614), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6615) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6616), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6617) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6619), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6619) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6621), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6623), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6624) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6625), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6626) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6627), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6630), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6631) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6632), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6634), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6635) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6637), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6637) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6639), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6641), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6642) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6643), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6644) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6645), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6646) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6648), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6650), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6651) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6652), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6653) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6654), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6657), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6657) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6717), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6718) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6721), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6722) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6723), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6726), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6726) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6728), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6729) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6731), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6734), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6735) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6736), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6738), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6740), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6741) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6743), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6744) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6745), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6746) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6747), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6749), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6752), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6753) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6754), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6756), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6757) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6759), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6761), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6762) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6763), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6764) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6765), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6768), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6768) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6770), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6771) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6772), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6774), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6777), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6779), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6781), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6783), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6784) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6786), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6786) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6788), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6791), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6793), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6795), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6796) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6797), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6800), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6802), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6803) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6804), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6805) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6806), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6807) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6808), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6809) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6811), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6811) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6813), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6814) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6815), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6816) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6817), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6818) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6820), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6822), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6824), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6825) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6828), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6829) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6830), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6832), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6833) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6834), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6837), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6837) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6839), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6841), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6842) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6843), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6844) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6845), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6846) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6848), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6850), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6851) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6852), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6853) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6854), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6855) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6857), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6859), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6861), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6863), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6864) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6866), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6866) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6868), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6869) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6870), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6871) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6873), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6873) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6875), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6876) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6878), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6920), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6921) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6922), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6925), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6925) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6927), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6929), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6931), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6932) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6933), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6934) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6936), new DateTime(2022, 9, 14, 14, 2, 51, 300, DateTimeKind.Local).AddTicks(6937) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                table: "WareHouses");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 704, DateTimeKind.Local).AddTicks(4525), new DateTime(2022, 9, 8, 15, 21, 17, 705, DateTimeKind.Local).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 705, DateTimeKind.Local).AddTicks(3529), new DateTime(2022, 9, 8, 15, 21, 17, 705, DateTimeKind.Local).AddTicks(3534) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(3826), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4704), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4708) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4711), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4712) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4714), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4714) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4716), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4717) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4721), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4721) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4723), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4724) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4725), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4726) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4727), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4728) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4731), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4732) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4733), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4734) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4735), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4736) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4737), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4738) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4740), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4742), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4743) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4744), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4745) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4746), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4747) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4749), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4750) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4752), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4752) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4754), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4755) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4756), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4757) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4758), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4759) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4760), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4763), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4763) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4765), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4766) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4768), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4768) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4770), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4772), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4774), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4775) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4777), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4778) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4779), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4782), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4782) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4784), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4785) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4787), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4789), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4791), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4862), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4863) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4865), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4866) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4867), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4868) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4870), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4871) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4872), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4873) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4874), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4875) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4877), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4877) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4879), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4880) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4881), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4882) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4883), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4884) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4886), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4886) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4888), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4889) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4890), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4891) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4892), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4893) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4895), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4896) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4897), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4898) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4899), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4902), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4902) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4904), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4905) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4906), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4907) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4909), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4911), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4912) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4913), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4914) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4916), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4916) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4918), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4919) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4920), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4921) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4922), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4923) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4925), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4926) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4927), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4928) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4931), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4932) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4933), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4934) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4935), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4936) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4938), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4939) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4940), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4941) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4942), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4944), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4947), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4948) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4949), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4950) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4952), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4953) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4954), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4956), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4957) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4959), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4959) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4961), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4962) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4963), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4964) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4965), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4968), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4969) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4970), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4971) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4972), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4974), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4975) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4977), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4978) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4979), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4980) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4981), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4982) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4983), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4984) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4986), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4986) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4988), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4989) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4990), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4991) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4992), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4993) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4995), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4996) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4997), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4998) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4999), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5001), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5002) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5004), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5004) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5006), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5007) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5008), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5009) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5010), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5011) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5013), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5015), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5016) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5017), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5018) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5019), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5020) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5022), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5024), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5025) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5027), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5028) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5029), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5032), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5033) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5034), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5035) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5036), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5037) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5039), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5039) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5041), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5042) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5043), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5044) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5045), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5046) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5048), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5049) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5050), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5051) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5052), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5053) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5054), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5055) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5057), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5057) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5059), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5061), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5063), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5065), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5067) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5068), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5070), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5072), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5073) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5075), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5076) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5120), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5121) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5123), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5124) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5125), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5126) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5127), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5128) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5129), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5132), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5132) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5134), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5135) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5136), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5137) });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "LastUpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5138), new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5139) });
        }
    }
}
