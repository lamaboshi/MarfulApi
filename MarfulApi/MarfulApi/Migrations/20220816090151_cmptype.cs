using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarfulApi.Migrations
{
    public partial class cmptype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Conversations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Start",
                value: new DateTime(2022, 8, 16, 12, 1, 49, 109, DateTimeKind.Local).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 8, 16, 12, 1, 49, 109, DateTimeKind.Local).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 8, 16, 12, 1, 49, 109, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "dateTime",
                value: new DateTime(2022, 8, 16, 12, 1, 49, 109, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "dateTime",
                value: new DateTime(2022, 8, 16, 12, 1, 49, 109, DateTimeKind.Local).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "dateTime",
                value: new DateTime(2022, 8, 16, 12, 1, 49, 109, DateTimeKind.Local).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "dateTime",
                value: new DateTime(2022, 8, 16, 12, 1, 49, 109, DateTimeKind.Local).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "dateTime",
                value: new DateTime(2022, 8, 16, 12, 1, 49, 109, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "dateTime",
                value: new DateTime(2022, 8, 16, 12, 1, 49, 109, DateTimeKind.Local).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "dateTime",
                value: new DateTime(2022, 8, 16, 12, 1, 49, 109, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "dateTime",
                value: new DateTime(2022, 8, 16, 12, 1, 49, 109, DateTimeKind.Local).AddTicks(4572));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Conversations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Start",
                value: new DateTime(2022, 8, 16, 11, 57, 52, 987, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 8, 16, 11, 57, 52, 987, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 8, 16, 11, 57, 52, 987, DateTimeKind.Local).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "dateTime",
                value: new DateTime(2022, 8, 16, 11, 57, 52, 987, DateTimeKind.Local).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "dateTime",
                value: new DateTime(2022, 8, 16, 11, 57, 52, 987, DateTimeKind.Local).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "dateTime",
                value: new DateTime(2022, 8, 16, 11, 57, 52, 987, DateTimeKind.Local).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "dateTime",
                value: new DateTime(2022, 8, 16, 11, 57, 52, 987, DateTimeKind.Local).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "dateTime",
                value: new DateTime(2022, 8, 16, 11, 57, 52, 987, DateTimeKind.Local).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "dateTime",
                value: new DateTime(2022, 8, 16, 11, 57, 52, 987, DateTimeKind.Local).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "dateTime",
                value: new DateTime(2022, 8, 16, 11, 57, 52, 987, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "dateTime",
                value: new DateTime(2022, 8, 16, 11, 57, 52, 987, DateTimeKind.Local).AddTicks(1407));
        }
    }
}
