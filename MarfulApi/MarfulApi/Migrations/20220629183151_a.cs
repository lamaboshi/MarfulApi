using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarfulApi.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Brands_BrandId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Infulonsers_InfulonserId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Jobs_JobId",
                table: "Posts");

            migrationBuilder.AlterColumn<int>(
                name: "JobId",
                table: "Posts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "InfulonserId",
                table: "Posts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BrandId",
                table: "Posts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Brands_BrandId",
                table: "Posts",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Infulonsers_InfulonserId",
                table: "Posts",
                column: "InfulonserId",
                principalTable: "Infulonsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Jobs_JobId",
                table: "Posts",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Brands_BrandId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Infulonsers_InfulonserId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Jobs_JobId",
                table: "Posts");

            migrationBuilder.AlterColumn<int>(
                name: "JobId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InfulonserId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BrandId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Conversations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Start",
                value: new DateTime(2022, 6, 29, 15, 43, 21, 13, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 6, 29, 15, 43, 21, 13, DateTimeKind.Local).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 6, 29, 15, 43, 21, 13, DateTimeKind.Local).AddTicks(9119));

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Brands_BrandId",
                table: "Posts",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Infulonsers_InfulonserId",
                table: "Posts",
                column: "InfulonserId",
                principalTable: "Infulonsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Jobs_JobId",
                table: "Posts",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
