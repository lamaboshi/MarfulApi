using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarfulApi.Migrations
{
    public partial class @try : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Conversations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Start",
                value: new DateTime(2022, 8, 8, 10, 50, 47, 208, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 8, 8, 10, 50, 47, 208, DateTimeKind.Local).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 8, 8, 10, 50, 47, 208, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "dateTime",
                value: new DateTime(2022, 8, 8, 10, 50, 47, 208, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "dateTime",
                value: new DateTime(2022, 8, 8, 10, 50, 47, 208, DateTimeKind.Local).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "dateTime",
                value: new DateTime(2022, 8, 8, 10, 50, 47, 208, DateTimeKind.Local).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "dateTime",
                value: new DateTime(2022, 8, 8, 10, 50, 47, 208, DateTimeKind.Local).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "dateTime",
                value: new DateTime(2022, 8, 8, 10, 50, 47, 208, DateTimeKind.Local).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "dateTime",
                value: new DateTime(2022, 8, 8, 10, 50, 47, 208, DateTimeKind.Local).AddTicks(4972));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "dateTime",
                value: new DateTime(2022, 8, 8, 10, 50, 47, 208, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "BrandId", "Description", "Image", "InfulonserId", "JobId", "dateTime" },
                values: new object[] { 8, null, " Im infulonser with content sport2", null, 2, null, new DateTime(2022, 8, 8, 10, 50, 47, 208, DateTimeKind.Local).AddTicks(4995) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Conversations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Start",
                value: new DateTime(2022, 8, 6, 23, 54, 47, 941, DateTimeKind.Local).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 8, 6, 23, 54, 47, 941, DateTimeKind.Local).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 8, 6, 23, 54, 47, 941, DateTimeKind.Local).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "dateTime",
                value: new DateTime(2022, 8, 6, 23, 54, 47, 941, DateTimeKind.Local).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "dateTime",
                value: new DateTime(2022, 8, 6, 23, 54, 47, 941, DateTimeKind.Local).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "dateTime",
                value: new DateTime(2022, 8, 6, 23, 54, 47, 941, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "dateTime",
                value: new DateTime(2022, 8, 6, 23, 54, 47, 941, DateTimeKind.Local).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "dateTime",
                value: new DateTime(2022, 8, 6, 23, 54, 47, 941, DateTimeKind.Local).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "dateTime",
                value: new DateTime(2022, 8, 6, 23, 54, 47, 941, DateTimeKind.Local).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "dateTime",
                value: new DateTime(2022, 8, 6, 23, 54, 47, 941, DateTimeKind.Local).AddTicks(3758));
        }
    }
}
