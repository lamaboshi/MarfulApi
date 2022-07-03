using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarfulApi.Migrations
{
    public partial class updateSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Conversations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Start",
                value: new DateTime(2022, 7, 3, 0, 25, 52, 439, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "Infulonsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Noor Stars, the first Arabic YouTuber to reach 10 million subscribers, was born in Iraq and grew up in Syria. Having spent her childhood in Damascus, she moved to Turkey for 3 years before moving to the United States with her mother and siblings. She completed her secondary education and university degree, specialising in business administration. Since her channel’s creation in 2014, Noor has posted over 550 videos on her channel, with over 18 million subscribers and 2 billion views in total. She was part of the Maybelline New York's Web series which was named Ramadan stars with Noor Stars and the web series won YouTube's The Lantern award 2019. Noor is best known for her content related to beauty, comics and vlogs.");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Conversations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Start",
                value: new DateTime(2022, 6, 30, 13, 50, 16, 988, DateTimeKind.Local).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "Infulonsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "fdsfsgfd");

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

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "dateTime",
                value: new DateTime(2022, 6, 30, 13, 50, 16, 988, DateTimeKind.Local).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "dateTime",
                value: new DateTime(2022, 6, 30, 13, 50, 16, 988, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "dateTime",
                value: new DateTime(2022, 6, 30, 13, 50, 16, 988, DateTimeKind.Local).AddTicks(1032));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "dateTime",
                value: new DateTime(2022, 6, 30, 13, 50, 16, 988, DateTimeKind.Local).AddTicks(1067));
        }
    }
}
