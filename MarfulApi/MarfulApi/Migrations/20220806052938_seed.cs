using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarfulApi.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CompanyContentId", "Description", "Image", "InfulonserId", "Name" },
                values: new object[] { 2, 2, "Our company has all kind 0f sport element type", null, null, "Addidas" });

            migrationBuilder.InsertData(
                table: "CompanyInfulonsers",
                columns: new[] { "Id", "CompanyId", "Followed", "InfulonserId" },
                values: new object[] { 2, 1, "infulonser", 1 });

            migrationBuilder.UpdateData(
                table: "Conversations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Start",
                value: new DateTime(2022, 8, 6, 8, 29, 36, 702, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 8, 6, 8, 29, 36, 702, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 8, 6, 8, 29, 36, 702, DateTimeKind.Local).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "dateTime",
                value: new DateTime(2022, 8, 6, 8, 29, 36, 702, DateTimeKind.Local).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "dateTime",
                value: new DateTime(2022, 8, 6, 8, 29, 36, 702, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "dateTime",
                value: new DateTime(2022, 8, 6, 8, 29, 36, 702, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "dateTime",
                value: new DateTime(2022, 8, 6, 8, 29, 36, 702, DateTimeKind.Local).AddTicks(5276));

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "BrandId", "Description", "Image", "InfulonserId", "JobId", "dateTime" },
                values: new object[] { 7, null, " Im infulonser with content sport", null, 2, null, new DateTime(2022, 8, 6, 8, 29, 36, 702, DateTimeKind.Local).AddTicks(5319) });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "BrandId", "Description", "Image", "InfulonserId", "JobId", "dateTime" },
                values: new object[] { 5, 2, " this is the first post for sport company", null, null, null, new DateTime(2022, 8, 6, 8, 29, 36, 702, DateTimeKind.Local).AddTicks(5290) });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "BrandId", "Description", "Image", "InfulonserId", "JobId", "dateTime" },
                values: new object[] { 6, 2, " this is the second post for sport company", null, null, null, new DateTime(2022, 8, 6, 8, 29, 36, 702, DateTimeKind.Local).AddTicks(5305) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Conversations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Start",
                value: new DateTime(2022, 7, 27, 12, 0, 46, 744, DateTimeKind.Local).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 7, 27, 12, 0, 46, 744, DateTimeKind.Local).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 7, 27, 12, 0, 46, 744, DateTimeKind.Local).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "dateTime",
                value: new DateTime(2022, 7, 27, 12, 0, 46, 744, DateTimeKind.Local).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "dateTime",
                value: new DateTime(2022, 7, 27, 12, 0, 46, 744, DateTimeKind.Local).AddTicks(9642));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "dateTime",
                value: new DateTime(2022, 7, 27, 12, 0, 46, 744, DateTimeKind.Local).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "dateTime",
                value: new DateTime(2022, 7, 27, 12, 0, 46, 744, DateTimeKind.Local).AddTicks(9701));
        }
    }
}
