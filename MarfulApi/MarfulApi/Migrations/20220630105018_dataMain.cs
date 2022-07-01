using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarfulApi.Migrations
{
    public partial class dataMain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Conversations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Start",
                value: new DateTime(2022, 6, 30, 13, 50, 16, 988, DateTimeKind.Local).AddTicks(522));

            migrationBuilder.InsertData(
                table: "InfulonserUsers",
                columns: new[] { "Id", "InfulonserId", "UserId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 6, 30, 13, 50, 16, 988, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 6, 30, 13, 50, 16, 988, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "BrandId", "Description", "Image", "InfulonserId", "JobId", "dateTime" },
                values: new object[,]
                {
                    { 1, null, " test for infulonser post", null, 1, null, new DateTime(2022, 6, 30, 13, 50, 16, 988, DateTimeKind.Local).AddTicks(953) },
                    { 2, null, " test another post for infulonser", null, 1, null, new DateTime(2022, 6, 30, 13, 50, 16, 988, DateTimeKind.Local).AddTicks(996) },
                    { 3, 1, " test for company post", null, null, null, new DateTime(2022, 6, 30, 13, 50, 16, 988, DateTimeKind.Local).AddTicks(1032) },
                    { 4, 1, " test another post for company", null, null, null, new DateTime(2022, 6, 30, 13, 50, 16, 988, DateTimeKind.Local).AddTicks(1067) }
                });

            migrationBuilder.InsertData(
                table: "UserCompanies",
                columns: new[] { "Id", "CompanyId", "UserId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "UserPosts",
                columns: new[] { "Id", "InterAction", "PostId", "UserId" },
                values: new object[] { 1, true, 1, 1 });

            migrationBuilder.InsertData(
                table: "UserPosts",
                columns: new[] { "Id", "InterAction", "PostId", "UserId" },
                values: new object[] { 2, false, 2, 1 });

            migrationBuilder.InsertData(
                table: "UserPosts",
                columns: new[] { "Id", "InterAction", "PostId", "UserId" },
                values: new object[] { 3, true, 4, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InfulonserUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserCompanies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserPosts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserPosts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserPosts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4);

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
    }
}
