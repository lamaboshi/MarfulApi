using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarfulApi.Migrations
{
    public partial class AddSomeSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "Code", "Description", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 3, 1, "32434", "This some Text about found", null, "Foundation", 350.0 },
                    { 4, 1, "32434", "This some Text about found", null, "CareKream", 290.0 },
                    { 5, 1, "32434", "This some Text about found", null, "CareSun", 400.0 },
                    { 6, 1, "32434", "This some Text about found", null, "Plasher", 600.0 },
                    { 7, 1, "32434", "This some Text about found", null, "Oclador", 178.0 },
                    { 8, 1, "32434", "This some Text about found", null, "Mascara", 1300.0 },
                    { 9, 1, "32434", "This some Text about found", null, "Tant", 700.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
