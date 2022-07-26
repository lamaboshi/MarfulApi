using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarfulApi.Migrations
{
    public partial class main : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InfulonserCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Followed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdInfulonser = table.Column<int>(type: "int", nullable: false),
                    InfulonserId = table.Column<int>(type: "int", nullable: false),
                    IdCompany = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfulonserCompanies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InfulonserCompanies_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InfulonserCompanies_Infulonsers_InfulonserId",
                        column: x => x.InfulonserId,
                        principalTable: "Infulonsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InfulonserFollowInfulonsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FollowId = table.Column<int>(type: "int", nullable: true),
                    FollowedId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfulonserFollowInfulonsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InfulonserFollowInfulonsers_Infulonsers_FollowedId",
                        column: x => x.FollowedId,
                        principalTable: "Infulonsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_InfulonserFollowInfulonsers_Infulonsers_FollowId",
                        column: x => x.FollowId,
                        principalTable: "Infulonsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "InfulonserPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdInfulonser = table.Column<int>(type: "int", nullable: false),
                    InfulonserId = table.Column<int>(type: "int", nullable: false),
                    IdPost = table.Column<int>(type: "int", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfulonserPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InfulonserPosts_Infulonsers_InfulonserId",
                        column: x => x.InfulonserId,
                        principalTable: "Infulonsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InfulonserPosts_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Conversations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Start",
                value: new DateTime(2022, 7, 26, 15, 33, 38, 724, DateTimeKind.Local).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 7, 26, 15, 33, 38, 724, DateTimeKind.Local).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 7, 26, 15, 33, 38, 724, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "dateTime",
                value: new DateTime(2022, 7, 26, 15, 33, 38, 724, DateTimeKind.Local).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "dateTime",
                value: new DateTime(2022, 7, 26, 15, 33, 38, 724, DateTimeKind.Local).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "dateTime",
                value: new DateTime(2022, 7, 26, 15, 33, 38, 724, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "dateTime",
                value: new DateTime(2022, 7, 26, 15, 33, 38, 724, DateTimeKind.Local).AddTicks(7921));

            migrationBuilder.CreateIndex(
                name: "IX_InfulonserCompanies_CompanyId",
                table: "InfulonserCompanies",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_InfulonserCompanies_InfulonserId",
                table: "InfulonserCompanies",
                column: "InfulonserId");

            migrationBuilder.CreateIndex(
                name: "IX_InfulonserFollowInfulonsers_FollowedId",
                table: "InfulonserFollowInfulonsers",
                column: "FollowedId");

            migrationBuilder.CreateIndex(
                name: "IX_InfulonserFollowInfulonsers_FollowId",
                table: "InfulonserFollowInfulonsers",
                column: "FollowId");

            migrationBuilder.CreateIndex(
                name: "IX_InfulonserPosts_InfulonserId",
                table: "InfulonserPosts",
                column: "InfulonserId");

            migrationBuilder.CreateIndex(
                name: "IX_InfulonserPosts_PostId",
                table: "InfulonserPosts",
                column: "PostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InfulonserCompanies");

            migrationBuilder.DropTable(
                name: "InfulonserFollowInfulonsers");

            migrationBuilder.DropTable(
                name: "InfulonserPosts");

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
