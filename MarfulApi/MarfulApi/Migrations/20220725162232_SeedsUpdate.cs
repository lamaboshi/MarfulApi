using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarfulApi.Migrations
{
    public partial class SeedsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "Description", "Email", "Image", "Name", "Password", "Phone", "TelePhone" },
                values: new object[] { 2, "From Streat", "Asics sponsors a variety of sports associations", "Asics@test.com", null, "ASIC", "111222", "0921423432", "223554" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, "All About sports", "Sports" });

            migrationBuilder.UpdateData(
                table: "Conversations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Start",
                value: new DateTime(2022, 7, 25, 19, 22, 29, 645, DateTimeKind.Local).AddTicks(3530));

            migrationBuilder.InsertData(
                table: "InfulonserContents",
                columns: new[] { "Id", "ContentId", "InfulonserId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "Infulonsers",
                columns: new[] { "Id", "Address", "Description", "Email", "Image", "Name", "Password", "Paypal", "Phone", "UserName" },
                values: new object[] { 2, "USA LA", "Joshua Patterson is an actor, known for ER (1994), 7th Heaven (1996) and Weird Science (1994).", "Joshua@test.com", null, "Joshua Patterson", "1111", "dskjffff", "0965465760", "Joshua" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 7, 25, 19, 22, 29, 645, DateTimeKind.Local).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 7, 25, 19, 22, 29, 645, DateTimeKind.Local).AddTicks(3597));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "dateTime",
                value: new DateTime(2022, 7, 25, 19, 22, 29, 645, DateTimeKind.Local).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "dateTime",
                value: new DateTime(2022, 7, 25, 19, 22, 29, 645, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "dateTime",
                value: new DateTime(2022, 7, 25, 19, 22, 29, 645, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "dateTime",
                value: new DateTime(2022, 7, 25, 19, 22, 29, 645, DateTimeKind.Local).AddTicks(3707));

            migrationBuilder.InsertData(
                table: "CompanyContents",
                columns: new[] { "Id", "CompanyId", "ContentId" },
                values: new object[] { 2, 2, 2 });

            migrationBuilder.InsertData(
                table: "InfulonserContents",
                columns: new[] { "Id", "ContentId", "InfulonserId" },
                values: new object[] { 2, 2, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyContents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "InfulonserContents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InfulonserContents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Infulonsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Conversations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Start",
                value: new DateTime(2022, 7, 3, 0, 25, 52, 439, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 7, 3, 0, 25, 52, 439, DateTimeKind.Local).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 7, 3, 0, 25, 52, 439, DateTimeKind.Local).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "dateTime",
                value: new DateTime(2022, 7, 3, 0, 25, 52, 439, DateTimeKind.Local).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "dateTime",
                value: new DateTime(2022, 7, 3, 0, 25, 52, 439, DateTimeKind.Local).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "dateTime",
                value: new DateTime(2022, 7, 3, 0, 25, 52, 439, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "dateTime",
                value: new DateTime(2022, 7, 3, 0, 25, 52, 439, DateTimeKind.Local).AddTicks(5889));
        }
    }
}
