using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarfulApi.Migrations
{
    public partial class error : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InfulonserFollowInfulonsers_Infulonsers_FollowedId",
                table: "InfulonserFollowInfulonsers");

            migrationBuilder.DropForeignKey(
                name: "FK_InfulonserFollowInfulonsers_Infulonsers_FollowId",
                table: "InfulonserFollowInfulonsers");

            migrationBuilder.DropTable(
                name: "InfulonserPosts");

            migrationBuilder.AlterColumn<int>(
                name: "FollowId",
                table: "InfulonserFollowInfulonsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_InfulonserFollowInfulonsers_Infulonsers_FollowedId",
                table: "InfulonserFollowInfulonsers",
                column: "FollowedId",
                principalTable: "Infulonsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InfulonserFollowInfulonsers_Infulonsers_FollowId",
                table: "InfulonserFollowInfulonsers",
                column: "FollowId",
                principalTable: "Infulonsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InfulonserFollowInfulonsers_Infulonsers_FollowedId",
                table: "InfulonserFollowInfulonsers");

            migrationBuilder.DropForeignKey(
                name: "FK_InfulonserFollowInfulonsers_Infulonsers_FollowId",
                table: "InfulonserFollowInfulonsers");

            migrationBuilder.AlterColumn<int>(
                name: "FollowId",
                table: "InfulonserFollowInfulonsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "InfulonserPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InfulonserId = table.Column<int>(type: "int", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    IdInfulonser = table.Column<int>(type: "int", nullable: false),
                    IdPost = table.Column<int>(type: "int", nullable: false)
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
                value: new DateTime(2022, 7, 25, 19, 22, 29, 645, DateTimeKind.Local).AddTicks(3530));

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

            migrationBuilder.CreateIndex(
                name: "IX_InfulonserPosts_InfulonserId",
                table: "InfulonserPosts",
                column: "InfulonserId");

            migrationBuilder.CreateIndex(
                name: "IX_InfulonserPosts_PostId",
                table: "InfulonserPosts",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_InfulonserFollowInfulonsers_Infulonsers_FollowedId",
                table: "InfulonserFollowInfulonsers",
                column: "FollowedId",
                principalTable: "Infulonsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InfulonserFollowInfulonsers_Infulonsers_FollowId",
                table: "InfulonserFollowInfulonsers",
                column: "FollowId",
                principalTable: "Infulonsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
