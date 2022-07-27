using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarfulApi.Migrations
{
    public partial class type : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyTypes_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Conversations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Start",
                value: new DateTime(2022, 7, 26, 20, 14, 59, 472, DateTimeKind.Local).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 7, 26, 20, 14, 59, 472, DateTimeKind.Local).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 7, 26, 20, 14, 59, 472, DateTimeKind.Local).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "dateTime",
                value: new DateTime(2022, 7, 26, 20, 14, 59, 472, DateTimeKind.Local).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "dateTime",
                value: new DateTime(2022, 7, 26, 20, 14, 59, 472, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "dateTime",
                value: new DateTime(2022, 7, 26, 20, 14, 59, 472, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "dateTime",
                value: new DateTime(2022, 7, 26, 20, 14, 59, 472, DateTimeKind.Local).AddTicks(6265));

            migrationBuilder.CreateIndex(
                name: "IX_CompanyTypes_CompanyId",
                table: "CompanyTypes",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyTypes");

            migrationBuilder.UpdateData(
                table: "Conversations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Start",
                value: new DateTime(2022, 7, 26, 20, 5, 40, 713, DateTimeKind.Local).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 7, 26, 20, 5, 40, 713, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 7, 26, 20, 5, 40, 713, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "dateTime",
                value: new DateTime(2022, 7, 26, 20, 5, 40, 713, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "dateTime",
                value: new DateTime(2022, 7, 26, 20, 5, 40, 713, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "dateTime",
                value: new DateTime(2022, 7, 26, 20, 5, 40, 713, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "dateTime",
                value: new DateTime(2022, 7, 26, 20, 5, 40, 713, DateTimeKind.Local).AddTicks(8613));
        }
    }
}
