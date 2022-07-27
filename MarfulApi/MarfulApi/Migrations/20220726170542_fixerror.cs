using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarfulApi.Migrations
{
    public partial class fixerror : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PostInfulonsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Interaction = table.Column<bool>(type: "bit", nullable: false),
                    InfulonserId = table.Column<int>(type: "int", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostInfulonsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostInfulonsers_Infulonsers_InfulonserId",
                        column: x => x.InfulonserId,
                        principalTable: "Infulonsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostInfulonsers_Posts_PostId",
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

            migrationBuilder.CreateIndex(
                name: "IX_PostInfulonsers_InfulonserId",
                table: "PostInfulonsers",
                column: "InfulonserId");

            migrationBuilder.CreateIndex(
                name: "IX_PostInfulonsers_PostId",
                table: "PostInfulonsers",
                column: "PostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostInfulonsers");

            migrationBuilder.UpdateData(
                table: "Conversations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Start",
                value: new DateTime(2022, 7, 26, 19, 34, 42, 895, DateTimeKind.Local).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 7, 26, 19, 34, 42, 895, DateTimeKind.Local).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 7, 26, 19, 34, 42, 895, DateTimeKind.Local).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "dateTime",
                value: new DateTime(2022, 7, 26, 19, 34, 42, 895, DateTimeKind.Local).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "dateTime",
                value: new DateTime(2022, 7, 26, 19, 34, 42, 895, DateTimeKind.Local).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "dateTime",
                value: new DateTime(2022, 7, 26, 19, 34, 42, 895, DateTimeKind.Local).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "dateTime",
                value: new DateTime(2022, 7, 26, 19, 34, 42, 895, DateTimeKind.Local).AddTicks(1732));
        }
    }
}
