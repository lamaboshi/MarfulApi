using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarfulApi.Migrations
{
    public partial class g : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyContents_Companies_CompanyId",
                table: "CompanyContents");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyContents_Contents_ContentId",
                table: "CompanyContents");

            migrationBuilder.DropForeignKey(
                name: "FK_InfulonserContents_Contents_ContentId",
                table: "InfulonserContents");

            migrationBuilder.DropForeignKey(
                name: "FK_InfulonserContents_Infulonsers_InfulonserId",
                table: "InfulonserContents");

            migrationBuilder.DropForeignKey(
                name: "FK_InfulonserUsers_Infulonsers_InfulonserId",
                table: "InfulonserUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_InfulonserUsers_Users_UserId",
                table: "InfulonserUsers");

            migrationBuilder.DropTable(
                name: "InfulonserCompanies");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "InfulonserUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "InfulonserId",
                table: "InfulonserUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FollowedId",
                table: "InfulonserFollowInfulonsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "InfulonserId",
                table: "InfulonserContents",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ContentId",
                table: "InfulonserContents",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ContentId",
                table: "CompanyContents",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "CompanyContents",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyContents_Companies_CompanyId",
                table: "CompanyContents",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyContents_Contents_ContentId",
                table: "CompanyContents",
                column: "ContentId",
                principalTable: "Contents",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InfulonserContents_Contents_ContentId",
                table: "InfulonserContents",
                column: "ContentId",
                principalTable: "Contents",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InfulonserContents_Infulonsers_InfulonserId",
                table: "InfulonserContents",
                column: "InfulonserId",
                principalTable: "Infulonsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InfulonserUsers_Infulonsers_InfulonserId",
                table: "InfulonserUsers",
                column: "InfulonserId",
                principalTable: "Infulonsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InfulonserUsers_Users_UserId",
                table: "InfulonserUsers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyContents_Companies_CompanyId",
                table: "CompanyContents");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyContents_Contents_ContentId",
                table: "CompanyContents");

            migrationBuilder.DropForeignKey(
                name: "FK_InfulonserContents_Contents_ContentId",
                table: "InfulonserContents");

            migrationBuilder.DropForeignKey(
                name: "FK_InfulonserContents_Infulonsers_InfulonserId",
                table: "InfulonserContents");

            migrationBuilder.DropForeignKey(
                name: "FK_InfulonserUsers_Infulonsers_InfulonserId",
                table: "InfulonserUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_InfulonserUsers_Users_UserId",
                table: "InfulonserUsers");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "InfulonserUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InfulonserId",
                table: "InfulonserUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FollowedId",
                table: "InfulonserFollowInfulonsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InfulonserId",
                table: "InfulonserContents",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ContentId",
                table: "InfulonserContents",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ContentId",
                table: "CompanyContents",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "CompanyContents",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "InfulonserCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    InfulonserId = table.Column<int>(type: "int", nullable: false),
                    Followed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdCompany = table.Column<int>(type: "int", nullable: false),
                    IdInfulonser = table.Column<int>(type: "int", nullable: false)
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
                name: "IX_InfulonserCompanies_CompanyId",
                table: "InfulonserCompanies",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_InfulonserCompanies_InfulonserId",
                table: "InfulonserCompanies",
                column: "InfulonserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyContents_Companies_CompanyId",
                table: "CompanyContents",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyContents_Contents_ContentId",
                table: "CompanyContents",
                column: "ContentId",
                principalTable: "Contents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InfulonserContents_Contents_ContentId",
                table: "InfulonserContents",
                column: "ContentId",
                principalTable: "Contents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InfulonserContents_Infulonsers_InfulonserId",
                table: "InfulonserContents",
                column: "InfulonserId",
                principalTable: "Infulonsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InfulonserUsers_Infulonsers_InfulonserId",
                table: "InfulonserUsers",
                column: "InfulonserId",
                principalTable: "Infulonsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InfulonserUsers_Users_UserId",
                table: "InfulonserUsers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
