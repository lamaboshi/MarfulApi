using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarfulApi.Migrations
{
    public partial class aa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "dateTime",
                table: "Posts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Conversations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Start",
                value: new DateTime(2022, 6, 30, 13, 36, 21, 565, DateTimeKind.Local).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 6, 30, 13, 36, 21, 565, DateTimeKind.Local).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 6, 30, 13, 36, 21, 565, DateTimeKind.Local).AddTicks(4202));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dateTime",
                table: "Posts");

            migrationBuilder.UpdateData(
                table: "Conversations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Start",
                value: new DateTime(2022, 6, 29, 21, 31, 50, 638, DateTimeKind.Local).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 6, 29, 21, 31, 50, 638, DateTimeKind.Local).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 6, 29, 21, 31, 50, 638, DateTimeKind.Local).AddTicks(1132));
        }
    }
}
