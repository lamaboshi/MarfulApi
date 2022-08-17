using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarfulApi.Migrations
{
    public partial class updateSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "CompanyId", "Password", "type" },
                values: new object[,]
                {
                    { 1, 1, "chat employee", "chat employee" },
                    { 2, 1, "Publishing Officer", "Publishing Officer" },
                    { 3, 1, "Editing Officer", "Editing Officer" },
                    { 4, 1, "Owner", "Owner" },
                    { 5, 2, "chat employee", "chat employee" }
                });

            migrationBuilder.UpdateData(
                table: "Conversations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Start",
                value: new DateTime(2022, 8, 17, 9, 28, 45, 138, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 8, 17, 9, 28, 45, 138, DateTimeKind.Local).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 8, 17, 9, 28, 45, 138, DateTimeKind.Local).AddTicks(5223));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "dateTime",
                value: new DateTime(2022, 8, 17, 9, 28, 45, 138, DateTimeKind.Local).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "dateTime",
                value: new DateTime(2022, 8, 17, 9, 28, 45, 138, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "dateTime",
                value: new DateTime(2022, 8, 17, 9, 28, 45, 138, DateTimeKind.Local).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "dateTime",
                value: new DateTime(2022, 8, 17, 9, 28, 45, 138, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "dateTime",
                value: new DateTime(2022, 8, 17, 9, 28, 45, 138, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "dateTime",
                value: new DateTime(2022, 8, 17, 9, 28, 45, 138, DateTimeKind.Local).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "dateTime",
                value: new DateTime(2022, 8, 17, 9, 28, 45, 138, DateTimeKind.Local).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "dateTime",
                value: new DateTime(2022, 8, 17, 9, 28, 45, 138, DateTimeKind.Local).AddTicks(5760));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Conversations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Start",
                value: new DateTime(2022, 8, 17, 9, 16, 3, 714, DateTimeKind.Local).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 8, 17, 9, 16, 3, 714, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 8, 17, 9, 16, 3, 714, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "dateTime",
                value: new DateTime(2022, 8, 17, 9, 16, 3, 714, DateTimeKind.Local).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "dateTime",
                value: new DateTime(2022, 8, 17, 9, 16, 3, 714, DateTimeKind.Local).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "dateTime",
                value: new DateTime(2022, 8, 17, 9, 16, 3, 714, DateTimeKind.Local).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "dateTime",
                value: new DateTime(2022, 8, 17, 9, 16, 3, 714, DateTimeKind.Local).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "dateTime",
                value: new DateTime(2022, 8, 17, 9, 16, 3, 714, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "dateTime",
                value: new DateTime(2022, 8, 17, 9, 16, 3, 714, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "dateTime",
                value: new DateTime(2022, 8, 17, 9, 16, 3, 714, DateTimeKind.Local).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "dateTime",
                value: new DateTime(2022, 8, 17, 9, 16, 3, 714, DateTimeKind.Local).AddTicks(7740));
        }
    }
}
