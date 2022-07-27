using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarfulApi.Migrations
{
    public partial class fixcomInf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyInfulonsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Followed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InfulonserId = table.Column<int>(type: "int", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyInfulonsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyInfulonsers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CompanyInfulonsers_Infulonsers_InfulonserId",
                        column: x => x.InfulonserId,
                        principalTable: "Infulonsers",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Conversations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Start",
                value: new DateTime(2022, 7, 26, 23, 0, 55, 717, DateTimeKind.Local).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 7, 26, 23, 0, 55, 717, DateTimeKind.Local).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 7, 26, 23, 0, 55, 717, DateTimeKind.Local).AddTicks(6532));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "dateTime",
                value: new DateTime(2022, 7, 26, 23, 0, 55, 717, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "dateTime",
                value: new DateTime(2022, 7, 26, 23, 0, 55, 717, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "dateTime",
                value: new DateTime(2022, 7, 26, 23, 0, 55, 717, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "dateTime",
                value: new DateTime(2022, 7, 26, 23, 0, 55, 717, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.CreateIndex(
                name: "IX_CompanyInfulonsers_CompanyId",
                table: "CompanyInfulonsers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyInfulonsers_InfulonserId",
                table: "CompanyInfulonsers",
                column: "InfulonserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyInfulonsers");

            migrationBuilder.UpdateData(
                table: "Conversations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Start",
                value: new DateTime(2022, 7, 26, 22, 56, 29, 45, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 7, 26, 22, 56, 29, 45, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 7, 26, 22, 56, 29, 45, DateTimeKind.Local).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "dateTime",
                value: new DateTime(2022, 7, 26, 22, 56, 29, 45, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "dateTime",
                value: new DateTime(2022, 7, 26, 22, 56, 29, 45, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "dateTime",
                value: new DateTime(2022, 7, 26, 22, 56, 29, 45, DateTimeKind.Local).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "dateTime",
                value: new DateTime(2022, 7, 26, 22, 56, 29, 45, DateTimeKind.Local).AddTicks(8711));
        }
    }
}
