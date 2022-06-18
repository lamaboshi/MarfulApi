using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarfulApi.Migrations
{
    public partial class addSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Jobs_JobId",
                table: "Messages");

            migrationBuilder.AlterColumn<int>(
                name: "JobId",
                table: "Messages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Conversations",
                columns: new[] { "Id", "CompanyId", "InfulonserId", "Start" },
                values: new object[] { 1, 1, 1, new DateTime(2009, 9, 14, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ConversationId", "JobId", "MessageStatus", "SendTime", "Text" },
                values: new object[] { 1, 1, null, false, new DateTime(2009, 9, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), "hi thanke you very match for this it was nice one" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ConversationId", "JobId", "MessageStatus", "SendTime", "Text" },
                values: new object[] { 2, 1, null, true, new DateTime(2009, 9, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), "hi thanke you very match for this it was nice one" });

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Jobs_JobId",
                table: "Messages",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Jobs_JobId",
                table: "Messages");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Conversations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "JobId",
                table: "Messages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Jobs_JobId",
                table: "Messages",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
