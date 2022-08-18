using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarfulApi.Migrations
{
    public partial class tryUserCmp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Infulonsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Paypal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Infulonsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Paypal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "CompanyContents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    ContentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyContents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyContents_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CompanyContents_Contents_ContentId",
                        column: x => x.ContentId,
                        principalTable: "Contents",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateTable(
                name: "Conversations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    InfulonserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conversations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conversations_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Conversations_Infulonsers_InfulonserId",
                        column: x => x.InfulonserId,
                        principalTable: "Infulonsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InfulonserContents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InfulonserId = table.Column<int>(type: "int", nullable: true),
                    ContentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfulonserContents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InfulonserContents_Contents_ContentId",
                        column: x => x.ContentId,
                        principalTable: "Contents",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InfulonserContents_Infulonsers_InfulonserId",
                        column: x => x.InfulonserId,
                        principalTable: "Infulonsers",
                        principalColumn: "Id");
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InfulonserFollowInfulonsers_Infulonsers_FollowId",
                        column: x => x.FollowId,
                        principalTable: "Infulonsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InfulonserUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InfulonserId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfulonserUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InfulonserUsers_Infulonsers_InfulonserId",
                        column: x => x.InfulonserId,
                        principalTable: "Infulonsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InfulonserUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCompanies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCompanies_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCompanies_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    InfulonserId = table.Column<int>(type: "int", nullable: true),
                    CompanyContentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Brands_CompanyContents_CompanyContentId",
                        column: x => x.CompanyContentId,
                        principalTable: "CompanyContents",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Brands_Infulonsers_InfulonserId",
                        column: x => x.InfulonserId,
                        principalTable: "Infulonsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Salary = table.Column<double>(type: "float", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    InfulonserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jobs_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Jobs_Infulonsers_InfulonserId",
                        column: x => x.InfulonserId,
                        principalTable: "Infulonsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SendTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MessageStatus = table.Column<bool>(type: "bit", nullable: false),
                    JobId = table.Column<int>(type: "int", nullable: true),
                    ConversationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_Conversations_ConversationId",
                        column: x => x.ConversationId,
                        principalTable: "Conversations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Messages_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    dateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BrandId = table.Column<int>(type: "int", nullable: true),
                    JobId = table.Column<int>(type: "int", nullable: true),
                    InfulonserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Posts_Infulonsers_InfulonserId",
                        column: x => x.InfulonserId,
                        principalTable: "Infulonsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Posts_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateTable(
                name: "UserPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InterAction = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPosts_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPosts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UserPostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Baskets_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Baskets_UserPosts_UserPostId",
                        column: x => x.UserPostId,
                        principalTable: "UserPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "Description", "Email", "Image", "Name", "Password", "Phone", "TelePhone" },
                values: new object[,]
                {
                    { 1, "From Streat", "JUICY BEAUTY is the place where you can talk about makeup. You can go there for advice from the brand’s makeup artists and cosmetics experts. You can play with new colors and, with the 50 products on display, experiment with new looks and effective makeup products that are tailored to your needs", "JUICYBEAUTY@test.com", null, "JUICY BEAUTY", "12123", "0921423432", "4232543" },
                    { 2, "From Streat", "Huda Beauty is a cosmetics line  the brand has a positive reputation on some of its products, such as the popular fake eyelashes series, as well as a collection of foundations, eyeshadows and some face palettes", "hudabeauty@test.com", null, "HUDA BEAUTY", "12123", "0921423432", "4232543" },
                    { 3, "From Streat", "Maybelline, is an American multinational cosmetics, skin care, fragrance, and personal care company, based in New York City. It was founded in Chicago in 1914", "MAYBELLINE@test.com", null, "MAYBELLINE", "34345", "0921423432", "4232543" },
                    { 4, "From Streat", "L'Oréal  is a French personal care company headquartered in Clichy, Hauts-de-Seinewith a registered office in Paris. It is the world's largest cosmetics company and has developed activities in the field concentrating on hair color, skin care, sun protection, make-up, perfume, and hair care.", "LOREAL@test.com", null, "LOREAL", "23234", "0921423432", "4232543" },
                    { 5, "From Streat", "Collection ,Sephora offers beauty products including cosmetics, skincare, body, fragrance, nail color, beauty tools, body lotions and haircare.", "SEPHORA@test.com", null, "SEPHORA", "45456", "0921423432", "4232543" },
                    { 6, "From Streat", "Asics sponsors a variety of sports associations", "Asics@test.com", null, "ASIC", "111222", "0921423432", "223554" },
                    { 7, "From Streat", "Manufacturer of sports shoes and apparel. It was the largest sportswear manufacturer in Europe and the second largest after Nike in the world. Adidas products are traditionally distinguished by a three-line brand, which remains an element of the company's latest products", "ADDIDAS@test.com", null, "ADDIDAS", "111222", "0921423432", "223554" },
                    { 8, "From Streat", "The world’s largest athletic apparel company, Nike is best known for its footwear, apparel, and equipment. One of the most valuable brands among sport businesses,The company sponsors top athletes and sports teams around the world.", "NIKE@test.com", null, "NIKE", "78789", "0921423432", "223554" },
                    { 9, "From Streat", "Puma, is a German multinational corporation that designs and manufactures athletic and casual footwear, apparel and accessories, which is headquartered in Herzogenaurach, Bavaria, Germany. Puma is the third largest sportswear manufacturer in the world", "PUMA@test.com", null, "PUMA", "67678", "0921423432", "223554" },
                    { 10, "Reebok International Limited (/ˈriːbɒk/) is an American fitness footwear and clothing manufacturer that is a part of Authentic Brands Group.", "Asics sponsors a variety of sports associations", "REEBOK@test.com", null, "REEBOK", "8989", "0921423432", "223554" },
                    { 11, "From Streat", "A clothing retailer, the company specializes in fast fashion, and its products include apparel, accessories, footwear, swimwear, cosmetics, and perfume. It is one of the largest clothing retailers in the world which also includes brands such as Bershka and Massimo Dutti.", "ZARA@test.com", null, "ZARA", "0909", "0921423432", "223554" },
                    { 12, "From Streat", "Max Fashion is an Indian fashion brand under the banner of the Landmark Group in Dubai", "MAX@test.com", null, "MAX", "111222", "0921423432", "223554" },
                    { 13, "From Streat", "It is an Italian luxury fashion house specializing in ready-to-wear and haute couture, headquartered in Milan, Italy. Expanded to design raincoats, windbreakers, knitwear, leather goods, shoes, perfume, and accessories", "MONCLER@test.com", null, "MONCLER", "6789", "0921423432", "223554" },
                    { 14, "From Streat", "Lacoste S.A. is a French company. It sells clothing, footwear, sportswear, eyewear, leather goods, perfume, towels and watches", "LACOSTE@test.com", null, "LACOSTE", "111222", "0921423432", "223554" },
                    { 15, "From Streat", "It is one of the most famous fashion companies in the world. The group enjoys a unified identity consisting of colours, authentic fashion and quality at democratic prices", "BENETTON@test.com", null, "BENETTON", "9463", "0921423432", "223554" },
                    { 16, "Louisville, KentuckyFrom Streat", "Kentucky Fried Chicken or KFC is a chain of fast food restaurants that specializes primarily in fried chicken.  It is the second largest chain of fast food restaurants in the world in terms of sales after McDonald's. Kentucky Fried Chicken has nearly twenty thousand branches spread over 123 countries and territories around the world.", "KFC@test.com", null, "KFC", "5252", "0921423432", "223554" },
                    { 17, "From Streat", "MCDONALD'S is the world's largest restaurant chain by revenue,McDonald's is best known for its hamburgers, cheeseburgers and french fries, although their menus include other items like chicken, fish, fruit, and salads", "MCDONALDS@test.com", null, "MCDONALDS", "99999", "0921423432", "223554" },
                    { 18, "From Streat", "Nestlé is a multinational company specializing in the production of canned foods, founded in Vevey, Switzerland.", "NESTLE@test.com", null, "NESTLE", "111222", "0921423432", "223554" },
                    { 19, "From Streat", "STARBUCKS is a specialty coffee retailer. It roasts, markets, and retails specialty coffee. The company, through its stores, offers several blends of coffee, handcrafted beverages, merchandise, and food items", "STARBUCKS@test.com", null, "STARBUCKS", "123122", "0921423432", "223554" },
                    { 20, "From Streat", "Pizza Hut is an American multinational restaurant chain and international franchise founded in 1958 in Wichita, Kansas by Dan and Frank Carney. They serve their signature pan pizza and other dishes including pasta, breadsticks and desserts.", "PIZZAHUT@test.com", null, "PIZZA HUT", "34345", "0921423432", "223554" },
                    { 21, "Suwon, South Korea", " Samsung Electronics is the world's largest electronics and information technology company.  Samsung Electronics is part of the Samsung Group, which is the largest conglomerate in South Korea and the global market leader with more than 60 products including semiconductors such as DRAM and flash memory, digital display devices such as liquid crystal TVs  LCD and plasma, consumer electronics such as DVD players, mobile phones, digital cameras and laser printers, household appliances such as refrigerators, microwaves and dishwashers.", "SAMSUNG@test.com", null, "SAMSUNG", "111222", "0921423432", "223554" },
                    { 22, "Cupertino, California, United States", "The Apple Corporation is an American multinational technology company specializing in consumer electronics, software and online services.  It is one of the top five American IT companies", "APPLE@test.com", null, "APPLE", "77666", "0921423432", "223554" },
                    { 23, "South Korea", "The Korean LG Group this company is the second largest holding company, producing electronics, chemicals and telecommunications products.  from 80 countries", "LG@test.com", null, "LG", "989887", "0921423432", "223554" },
                    { 24, " Los Gatos, California", "Netflix is   an American entertainment company that specializes in providing live broadcasting, video-on-demand, and mail-delivery of CDs. Netflix has expanded into the production of films and television shows, and online video distribution", "NETFLIX@test.com", null, "NETFLIX", "34567", "0921423432", "223554" },
                    { 25, "From Streat", "Shahid is the first Arab platform to provide \"Video on Demand\" service in the Middle East, and it has been re-launched by the \"MBC\" media group.  It is worth noting that Shahid,the leading subscription video-on-demand platform, is considered the leading Arab broadcasting platform in the world and the home of original Arabic productions with world-class specifications.along with a live broadcast of a group of the most watched Arab TV channels", "SHAHID@test.com", null, "SHAHID", "888877", "0921423432", "223554" },
                    { 26, "From Streat", "DIOR Products Clothing, cosmetics, fashion accessories, jewelry, perfumes, watches", "DIOR@test.com", null, "DIOR", "777776", "0921423432", "223554" },
                    { 27, "From Streat", "Chanel Its products cover clothes, fragrances, handbags and watches", "CHANNEL@test.com", null, "CHANNEL", "333333", "0921423432", "223554" },
                    { 28, "From Streat", "Gucci offers a range of different luxury  Shoes, ready-to-wear apparel, watches, and jewelry are the other main , however they also sell other products such as perfume and home decor", "Gucci@test.com", null, "GUCCI", "8888882", "0921423432", "223554" }
                });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "All About MakeUp", "MackeUp" },
                    { 2, "All About sports", "Sports" },
                    { 3, "All About Clothes", "Clothes" },
                    { 4, "All About Food", "Food" },
                    { 5, "All About electronics", "Electronics" },
                    { 6, "All About Movies & Series", "Platforms" },
                    { 7, "All About Perfumes", "Perfumes" }
                });

            migrationBuilder.InsertData(
                table: "Infulonsers",
                columns: new[] { "Id", "Address", "Description", "Email", "Image", "Name", "Password", "Paypal", "Phone", "UserName" },
                values: new object[,]
                {
                    { 1, "USA LA", "Noor Stars, the first Arabic YouTuber to reach 10 million subscribers, was born in Iraq and grew up in Syria. Having spent her childhood in Damascus, she moved to Turkey for 3 years before moving to the United States with her mother and siblings. She completed her secondary education and university degree, specialising in business administration. Since her channel’s creation in 2014, Noor has posted over 550 videos on her channel, with over 18 million subscribers and 2 billion views in total. She was part of the Maybelline New York's Web series which was named Ramadan stars with Noor Stars and the web series won YouTube's The Lantern award 2019. Noor is best known for her content related to beauty, comics and vlogs.", "info@test.com", null, "NoorStars", "0000", "dskjfhjh", "0965465760", "NoorStars" },
                    { 2, "USA LA", "Joshua Patterson is an actor, known for ER (1994), 7th Heaven (1996) and Weird Science (1994).", "Joshua@test.com", null, "Joshua Patterson", "1111", "dskjffff", "0965465760", "Joshua" },
                    { 3, "Dubai/Los Angeles", "You Tuber/Content Creator", "Ossy@test.com", null, "Ossy Marwah", "2222", "dskjffff", "0965465760", "Ossy" },
                    { 4, "DUBAI", "Critic/You Tuber", "barhom@test.com", null, "Ibrahim Almarrawi", "3333", "dskjffff", "0965465760", "barhom" },
                    { 5, "Dubia,United Arab Emirates", "foodblogger/cars/travel", "feras@test.com", null, "Feras Abo Shaar", "4444", "dskjffff", "0965465760", "Feras" },
                    { 6, "Dubia/London", "The Guy Who Drove Your Dream Car", "kareem@test.com", null, "Kareem Deeb", "5555", "dskjffff", "0965465760", "Deeb" },
                    { 7, "Syria", "journalist & Presenter @mbc1", "Leen@test.com", null, "Leen AbouShaar", "6666", "dskjffff", "0965465760", "Leen" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "Image", "Name", "Password", "Paypal", "Phone", "UserName" },
                values: new object[,]
                {
                    { 1, 20, "Hadel@test.com", null, "Hadel Dabbas", "123", "Lb1267", "0964654765", "hadel2000" },
                    { 2, 20, "Asia@test.com", null, "Asia", "456", "Lb1267", "0964654765", "Asel" },
                    { 3, 20, "yousfi@test.com", null, "Haya Yousfi", "789", "Lb1267", "0964654765", "Haya" },
                    { 4, 20, "Eid@test.com", null, "Haya Eid", "101", "Lb1267", "0964654765", "HayaSy" },
                    { 5, 20, "lama@test.com", null, "Lama Boshi", "121", "Lb1267", "0964654765", "Lamaz" },
                    { 6, 20, "Hamzeh@test.com", null, "Hamze Badinjky", "141", "Lb1267", "0964654765", "hamzehS" },
                    { 7, 20, "Adam@test.com", null, "Adam Syria", "161", "Lb1267", "0964654765", "Adom" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CompanyContentId", "Description", "Image", "InfulonserId", "Name" },
                values: new object[,]
                {
                    { 29, null, "Namshi is a Dubai-based e-commerce firm which sells designer clothing. The company, which also provides shoes and accessories", null, 7, "NAMSHI" },
                    { 30, null, "Clothes Brand For Every Human Habeed", null, 6, "HABEED" }
                });

            migrationBuilder.InsertData(
                table: "CompanyContents",
                columns: new[] { "Id", "CompanyId", "ContentId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 },
                    { 4, 4, 1 },
                    { 5, 5, 1 },
                    { 6, 6, 2 },
                    { 7, 7, 2 },
                    { 8, 8, 2 },
                    { 9, 9, 2 },
                    { 10, 10, 2 },
                    { 11, 11, 3 },
                    { 12, 12, 3 },
                    { 13, 13, 3 },
                    { 14, 14, 3 },
                    { 15, 15, 3 },
                    { 16, 16, 4 },
                    { 17, 17, 4 },
                    { 18, 18, 4 },
                    { 19, 19, 4 },
                    { 20, 20, 4 },
                    { 21, 21, 5 },
                    { 22, 22, 5 },
                    { 23, 23, 5 },
                    { 24, 24, 6 },
                    { 25, 25, 6 },
                    { 26, 26, 7 },
                    { 27, 27, 7 },
                    { 28, 28, 7 }
                });

            migrationBuilder.InsertData(
                table: "CompanyInfulonsers",
                columns: new[] { "Id", "CompanyId", "Followed", "InfulonserId" },
                values: new object[,]
                {
                    { 1, 1, "company", 1 },
                    { 2, 2, "company", 1 },
                    { 3, 3, "company", 1 },
                    { 4, 4, "company", 1 },
                    { 5, 5, "company", 1 },
                    { 6, 11, "company", 1 },
                    { 7, 15, "company", 1 },
                    { 8, 22, "company", 1 },
                    { 9, 18, "company", 1 },
                    { 10, 24, "company", 1 },
                    { 11, 26, "company", 1 },
                    { 12, 27, "company", 1 }
                });

            migrationBuilder.InsertData(
                table: "CompanyInfulonsers",
                columns: new[] { "Id", "CompanyId", "Followed", "InfulonserId" },
                values: new object[,]
                {
                    { 13, 28, "company", 1 },
                    { 14, 1, "company", 7 },
                    { 15, 2, "company", 7 },
                    { 16, 5, "company", 7 },
                    { 17, 11, "company", 7 },
                    { 18, 12, "company", 7 },
                    { 19, 15, "company", 7 },
                    { 20, 26, "company", 7 },
                    { 21, 25, "company", 7 },
                    { 22, 22, "company", 7 },
                    { 23, 16, "company", 6 },
                    { 24, 17, "company", 6 },
                    { 25, 18, "company", 6 },
                    { 26, 19, "company", 6 },
                    { 27, 20, "company", 6 },
                    { 28, 21, "company", 6 },
                    { 29, 22, "company", 6 },
                    { 30, 23, "company", 6 },
                    { 31, 15, "company", 6 },
                    { 32, 6, "company", 2 },
                    { 33, 7, "company", 2 },
                    { 34, 8, "company", 2 },
                    { 35, 9, "company", 2 },
                    { 36, 10, "company", 2 },
                    { 37, 11, "company", 2 },
                    { 38, 12, "company", 2 },
                    { 39, 13, "company", 2 },
                    { 40, 14, "company", 2 },
                    { 41, 15, "company", 2 },
                    { 42, 21, "company", 3 },
                    { 43, 22, "company", 3 },
                    { 44, 23, "company", 3 },
                    { 45, 24, "company", 3 },
                    { 46, 25, "company", 4 },
                    { 47, 3, "company", 5 },
                    { 48, 10, "company", 5 },
                    { 49, 14, "company", 5 },
                    { 50, 18, "company", 5 },
                    { 51, 22, "company", 5 },
                    { 52, 24, "company", 5 },
                    { 53, 28, "company", 5 },
                    { 54, 1, "infulonser", 1 }
                });

            migrationBuilder.InsertData(
                table: "CompanyInfulonsers",
                columns: new[] { "Id", "CompanyId", "Followed", "InfulonserId" },
                values: new object[,]
                {
                    { 55, 1, "infulonser", 7 },
                    { 56, 2, "infulonser", 1 },
                    { 57, 3, "infulonser", 7 },
                    { 58, 4, "infulonser", 7 },
                    { 59, 5, "infulonser", 1 },
                    { 60, 6, "infulonser", 2 },
                    { 61, 7, "infulonser", 2 },
                    { 62, 8, "infulonser", 5 },
                    { 63, 9, "infulonser", 5 },
                    { 64, 10, "infulonser", 2 },
                    { 65, 11, "infulonser", 7 },
                    { 66, 12, "infulonser", 4 },
                    { 67, 13, "infulonser", 7 },
                    { 68, 14, "infulonser", 4 },
                    { 69, 15, "infulonser", 7 },
                    { 70, 16, "infulonser", 6 },
                    { 71, 17, "infulonser", 6 },
                    { 72, 18, "infulonser", 6 },
                    { 73, 19, "infulonser", 4 },
                    { 74, 20, "infulonser", 6 },
                    { 75, 20, "infulonser", 2 },
                    { 76, 20, "infulonser", 3 },
                    { 77, 21, "infulonser", 3 },
                    { 78, 22, "infulonser", 2 },
                    { 79, 23, "infulonser", 3 },
                    { 80, 26, "infulonser", 7 },
                    { 81, 27, "infulonser", 6 },
                    { 82, 28, "infulonser", 3 }
                });

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "CompanyId", "Password", "type" },
                values: new object[,]
                {
                    { 1, 1, "chat employee", "chat employee" },
                    { 2, 1, "Publishing Officer", "Publishing Officer" },
                    { 3, 1, "Editing Officer", "Editing Officer" },
                    { 4, 1, "Owner", "Owner" },
                    { 5, 2, "chat employee", "chat employee" },
                    { 6, 2, "Publishing Officer", "Publishing Officer" },
                    { 7, 2, "Editing Officer", "Editing Officer" },
                    { 8, 2, "Owner", "Owner" },
                    { 9, 3, "chat employee", "chat employee" },
                    { 10, 3, "Publishing Officer", "Publishing Officer" },
                    { 11, 3, "Editing Officer", "Editing Officer" },
                    { 12, 3, "Owner", "Owner" },
                    { 13, 4, "chat employee", "chat employee" },
                    { 14, 4, "Publishing Officer", "Publishing Officer" }
                });

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "CompanyId", "Password", "type" },
                values: new object[,]
                {
                    { 15, 4, "Editing Officer", "Editing Officer" },
                    { 16, 4, "Owner", "Owner" },
                    { 17, 5, "chat employee", "chat employee" },
                    { 18, 5, "Publishing Officer", "Publishing Officer" },
                    { 19, 5, "Editing Officer", "Editing Officer" },
                    { 20, 5, "Owner", "Owner" },
                    { 21, 6, "chat employee", "chat employee" },
                    { 22, 6, "Publishing Officer", "Publishing Officer" },
                    { 23, 6, "Editing Officer", "Editing Officer" },
                    { 24, 6, "Owner", "Owner" },
                    { 25, 7, "chat employee", "chat employee" },
                    { 26, 7, "Publishing Officer", "Publishing Officer" },
                    { 27, 7, "Editing Officer", "Editing Officer" },
                    { 28, 7, "Owner", "Owner" },
                    { 29, 8, "chat employee", "chat employee" },
                    { 30, 8, "Publishing Officer", "Publishing Officer" },
                    { 31, 8, "Editing Officer", "Editing Officer" },
                    { 32, 8, "Owner", "Owner" },
                    { 33, 9, "chat employee", "chat employee" },
                    { 34, 9, "Publishing Officer", "Publishing Officer" },
                    { 35, 9, "Editing Officer", "Editing Officer" },
                    { 36, 9, "Owner", "Owner" },
                    { 37, 10, "chat employee", "chat employee" },
                    { 38, 10, "Publishing Officer", "Publishing Officer" },
                    { 39, 10, "Editing Officer", "Editing Officer" },
                    { 40, 10, "Owner", "Owner" },
                    { 41, 11, "chat employee", "chat employee" },
                    { 42, 11, "Publishing Officer", "Publishing Officer" },
                    { 43, 11, "Editing Officer", "Editing Officer" },
                    { 44, 11, "Owner", "Owner" },
                    { 45, 12, "chat employee", "chat employee" },
                    { 46, 12, "Publishing Officer", "Publishing Officer" },
                    { 47, 12, "Editing Officer", "Editing Officer" },
                    { 48, 12, "Owner", "Owner" },
                    { 49, 13, "chat employee", "chat employee" },
                    { 50, 13, "Publishing Officer", "Publishing Officer" },
                    { 51, 13, "Editing Officer", "Editing Officer" },
                    { 52, 13, "Owner", "Owner" },
                    { 53, 14, "chat employee", "chat employee" },
                    { 54, 14, "Publishing Officer", "Publishing Officer" },
                    { 55, 14, "Editing Officer", "Editing Officer" },
                    { 56, 14, "Owner", "Owner" }
                });

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "CompanyId", "Password", "type" },
                values: new object[,]
                {
                    { 57, 15, "chat employee", "chat employee" },
                    { 58, 15, "Publishing Officer", "Publishing Officer" },
                    { 59, 15, "Editing Officer", "Editing Officer" },
                    { 60, 15, "Owner", "Owner" },
                    { 61, 16, "chat employee", "chat employee" },
                    { 62, 16, "Publishing Officer", "Publishing Officer" },
                    { 63, 16, "Editing Officer", "Editing Officer" },
                    { 64, 16, "Owner", "Owner" },
                    { 65, 17, "chat employee", "chat employee" },
                    { 66, 17, "Publishing Officer", "Publishing Officer" },
                    { 67, 17, "Editing Officer", "Editing Officer" },
                    { 68, 17, "Owner", "Owner" },
                    { 69, 18, "chat employee", "chat employee" },
                    { 70, 18, "Publishing Officer", "Publishing Officer" },
                    { 71, 18, "Editing Officer", "Editing Officer" },
                    { 72, 18, "Owner", "Owner" },
                    { 73, 19, "chat employee", "chat employee" },
                    { 74, 19, "Publishing Officer", "Publishing Officer" },
                    { 75, 19, "Editing Officer", "Editing Officer" },
                    { 76, 19, "Owner", "Owner" },
                    { 77, 20, "chat employee", "chat employee" },
                    { 78, 20, "Publishing Officer", "Publishing Officer" },
                    { 79, 20, "Editing Officer", "Editing Officer" },
                    { 80, 20, "Owner", "Owner" },
                    { 81, 21, "chat employee", "chat employee" },
                    { 82, 21, "Publishing Officer", "Publishing Officer" },
                    { 83, 21, "Editing Officer", "Editing Officer" },
                    { 84, 21, "Owner", "Owner" },
                    { 85, 22, "chat employee", "chat employee" },
                    { 86, 22, "Publishing Officer", "Publishing Officer" },
                    { 87, 22, "Editing Officer", "Editing Officer" },
                    { 88, 22, "Owner", "Owner" },
                    { 89, 23, "chat employee", "chat employee" },
                    { 90, 23, "Publishing Officer", "Publishing Officer" },
                    { 91, 23, "Editing Officer", "Editing Officer" },
                    { 92, 23, "Owner", "Owner" },
                    { 93, 24, "chat employee", "chat employee" },
                    { 94, 24, "Publishing Officer", "Publishing Officer" },
                    { 95, 24, "Editing Officer", "Editing Officer" },
                    { 96, 24, "Owner", "Owner" },
                    { 97, 25, "chat employee", "chat employee" },
                    { 98, 25, "Publishing Officer", "Publishing Officer" }
                });

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "CompanyId", "Password", "type" },
                values: new object[,]
                {
                    { 99, 25, "Editing Officer", "Editing Officer" },
                    { 100, 25, "Owner", "Owner" },
                    { 101, 26, "chat employee", "chat employee" },
                    { 102, 26, "Publishing Officer", "Publishing Officer" },
                    { 103, 26, "Editing Officer", "Editing Officer" },
                    { 104, 26, "Owner", "Owner" },
                    { 105, 27, "chat employee", "chat employee" },
                    { 106, 27, "Publishing Officer", "Publishing Officer" },
                    { 107, 27, "Editing Officer", "Editing Officer" },
                    { 108, 27, "Owner", "Owner" },
                    { 109, 28, "chat employee", "chat employee" },
                    { 110, 28, "Publishing Officer", "Publishing Officer" },
                    { 111, 28, "Editing Officer", "Editing Officer" },
                    { 112, 28, "Owner", "Owner" }
                });

            migrationBuilder.InsertData(
                table: "Conversations",
                columns: new[] { "Id", "CompanyId", "InfulonserId", "Start" },
                values: new object[] { 1, 1, 1, new DateTime(2022, 8, 18, 0, 11, 32, 773, DateTimeKind.Local).AddTicks(6677) });

            migrationBuilder.InsertData(
                table: "InfulonserContents",
                columns: new[] { "Id", "ContentId", "InfulonserId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 7 },
                    { 3, 2, 2 },
                    { 4, 2, 5 },
                    { 5, 3, 7 },
                    { 6, 3, 4 },
                    { 7, 4, 6 },
                    { 8, 5, 2 },
                    { 9, 5, 3 },
                    { 10, 6, 1 },
                    { 11, 6, 4 },
                    { 12, 7, 7 }
                });

            migrationBuilder.InsertData(
                table: "InfulonserFollowInfulonsers",
                columns: new[] { "Id", "FollowId", "FollowedId" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 2, 2, 1 },
                    { 3, 2, 3 },
                    { 4, 3, 4 },
                    { 5, 4, 5 },
                    { 6, 5, 4 },
                    { 7, 6, 7 },
                    { 8, 7, 6 },
                    { 9, 7, 1 }
                });

            migrationBuilder.InsertData(
                table: "InfulonserUsers",
                columns: new[] { "Id", "InfulonserId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 },
                    { 4, 5, 1 },
                    { 5, 6, 1 },
                    { 6, 7, 1 }
                });

            migrationBuilder.InsertData(
                table: "InfulonserUsers",
                columns: new[] { "Id", "InfulonserId", "UserId" },
                values: new object[,]
                {
                    { 7, 1, 2 },
                    { 8, 3, 2 },
                    { 9, 5, 2 },
                    { 10, 7, 2 },
                    { 11, 2, 3 },
                    { 12, 4, 3 },
                    { 13, 6, 3 },
                    { 14, 1, 4 },
                    { 15, 2, 4 },
                    { 16, 3, 4 },
                    { 17, 4, 5 },
                    { 18, 5, 5 },
                    { 19, 6, 5 },
                    { 20, 1, 6 },
                    { 21, 2, 6 },
                    { 22, 3, 6 },
                    { 23, 5, 6 },
                    { 24, 6, 6 },
                    { 25, 3, 7 },
                    { 26, 4, 7 },
                    { 27, 5, 7 },
                    { 28, 6, 7 },
                    { 29, 7, 7 }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "BrandId", "Description", "Image", "InfulonserId", "JobId", "dateTime" },
                values: new object[,]
                {
                    { 1, null, "Great product for sun protection", null, 1, null, new DateTime(2022, 8, 18, 0, 11, 32, 773, DateTimeKind.Local).AddTicks(9789) },
                    { 2, null, "interesting series", null, 1, null, new DateTime(2022, 8, 18, 0, 11, 32, 773, DateTimeKind.Local).AddTicks(9829) },
                    { 3, null, "Great sports products", null, 2, null, new DateTime(2022, 8, 18, 0, 11, 32, 773, DateTimeKind.Local).AddTicks(9851) },
                    { 4, null, "Excellent electronics", null, 2, null, new DateTime(2022, 8, 18, 0, 11, 32, 773, DateTimeKind.Local).AddTicks(9873) },
                    { 5, null, "Excellent mobiles", null, 3, null, new DateTime(2022, 8, 18, 0, 11, 32, 773, DateTimeKind.Local).AddTicks(9892) },
                    { 6, null, "Excellent  Laptop", null, 3, null, new DateTime(2022, 8, 18, 0, 11, 32, 773, DateTimeKind.Local).AddTicks(9916) },
                    { 7, null, "interesting series", null, 4, null, new DateTime(2022, 8, 18, 0, 11, 32, 773, DateTimeKind.Local).AddTicks(9936) },
                    { 8, null, "Gorgeous and comfortable clothes", null, 4, null, new DateTime(2022, 8, 18, 0, 11, 32, 773, DateTimeKind.Local).AddTicks(9956) },
                    { 9, null, "Great sports products", null, 5, null, new DateTime(2022, 8, 18, 0, 11, 32, 773, DateTimeKind.Local).AddTicks(9975) },
                    { 10, null, "Great sports equipment", null, 5, null, new DateTime(2022, 8, 18, 0, 11, 32, 773, DateTimeKind.Local).AddTicks(9998) },
                    { 11, null, "Great Fast Food", null, 6, null, new DateTime(2022, 8, 18, 0, 11, 32, 774, DateTimeKind.Local).AddTicks(18) },
                    { 12, null, "Excellent Food", null, 6, null, new DateTime(2022, 8, 18, 0, 11, 32, 774, DateTimeKind.Local).AddTicks(39) },
                    { 13, null, "Great product for sun protection", null, 7, null, new DateTime(2022, 8, 18, 0, 11, 32, 774, DateTimeKind.Local).AddTicks(59) },
                    { 14, null, "Gorgeous and comfortable clothes", null, 7, null, new DateTime(2022, 8, 18, 0, 11, 32, 774, DateTimeKind.Local).AddTicks(79) },
                    { 15, null, "Gorgeous Perfum", null, 7, null, new DateTime(2022, 8, 18, 0, 11, 32, 774, DateTimeKind.Local).AddTicks(100) }
                });

            migrationBuilder.InsertData(
                table: "UserCompanies",
                columns: new[] { "Id", "CompanyId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 },
                    { 4, 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "UserCompanies",
                columns: new[] { "Id", "CompanyId", "UserId" },
                values: new object[,]
                {
                    { 5, 5, 1 },
                    { 6, 6, 1 },
                    { 7, 7, 1 },
                    { 8, 8, 1 },
                    { 9, 9, 1 },
                    { 10, 10, 1 },
                    { 11, 11, 1 },
                    { 12, 12, 1 },
                    { 13, 13, 1 },
                    { 14, 14, 1 },
                    { 15, 15, 1 },
                    { 16, 16, 1 },
                    { 17, 17, 1 },
                    { 18, 18, 1 },
                    { 19, 19, 1 },
                    { 20, 20, 1 },
                    { 21, 21, 1 },
                    { 22, 22, 1 },
                    { 23, 23, 1 },
                    { 24, 24, 1 },
                    { 25, 25, 1 },
                    { 26, 26, 1 },
                    { 27, 27, 1 },
                    { 28, 28, 1 },
                    { 29, 1, 2 },
                    { 30, 2, 2 },
                    { 31, 3, 2 },
                    { 32, 4, 2 },
                    { 33, 5, 2 },
                    { 34, 24, 2 },
                    { 35, 25, 2 },
                    { 36, 21, 2 },
                    { 37, 22, 2 },
                    { 38, 23, 2 },
                    { 39, 6, 2 },
                    { 40, 7, 2 },
                    { 41, 8, 2 },
                    { 42, 9, 2 },
                    { 43, 10, 2 },
                    { 44, 11, 2 },
                    { 45, 12, 2 },
                    { 46, 13, 2 }
                });

            migrationBuilder.InsertData(
                table: "UserCompanies",
                columns: new[] { "Id", "CompanyId", "UserId" },
                values: new object[,]
                {
                    { 47, 14, 2 },
                    { 48, 15, 2 },
                    { 49, 26, 2 },
                    { 50, 27, 2 },
                    { 51, 28, 2 },
                    { 52, 16, 3 },
                    { 53, 17, 3 },
                    { 54, 18, 3 },
                    { 55, 19, 3 },
                    { 56, 20, 3 },
                    { 57, 24, 3 },
                    { 58, 25, 3 },
                    { 59, 11, 3 },
                    { 60, 12, 3 },
                    { 61, 13, 3 },
                    { 62, 14, 3 },
                    { 63, 15, 3 },
                    { 64, 6, 3 },
                    { 65, 7, 3 },
                    { 66, 8, 3 },
                    { 67, 9, 3 },
                    { 68, 10, 3 },
                    { 69, 1, 4 },
                    { 70, 2, 4 },
                    { 71, 3, 4 },
                    { 72, 4, 4 },
                    { 73, 5, 4 },
                    { 74, 24, 4 },
                    { 75, 25, 4 },
                    { 76, 6, 4 },
                    { 77, 7, 4 },
                    { 78, 8, 4 },
                    { 79, 9, 4 },
                    { 80, 10, 4 },
                    { 81, 21, 4 },
                    { 82, 22, 4 },
                    { 83, 23, 4 },
                    { 84, 11, 5 },
                    { 85, 12, 5 },
                    { 86, 13, 5 },
                    { 87, 14, 5 },
                    { 88, 15, 5 }
                });

            migrationBuilder.InsertData(
                table: "UserCompanies",
                columns: new[] { "Id", "CompanyId", "UserId" },
                values: new object[,]
                {
                    { 89, 24, 5 },
                    { 90, 25, 5 },
                    { 91, 6, 5 },
                    { 92, 7, 5 },
                    { 93, 8, 5 },
                    { 94, 9, 5 },
                    { 95, 10, 5 },
                    { 96, 22, 5 },
                    { 97, 23, 5 },
                    { 98, 24, 5 },
                    { 99, 1, 6 },
                    { 100, 2, 6 },
                    { 101, 3, 6 },
                    { 102, 4, 6 },
                    { 103, 5, 6 },
                    { 104, 6, 6 },
                    { 105, 7, 6 },
                    { 106, 8, 6 },
                    { 107, 9, 6 },
                    { 108, 10, 6 },
                    { 109, 11, 6 },
                    { 110, 12, 6 },
                    { 111, 13, 6 },
                    { 112, 14, 6 },
                    { 113, 15, 6 },
                    { 114, 16, 6 },
                    { 115, 17, 6 },
                    { 116, 18, 6 },
                    { 117, 19, 6 },
                    { 118, 20, 6 },
                    { 119, 21, 6 },
                    { 120, 22, 6 },
                    { 121, 23, 6 },
                    { 122, 24, 6 },
                    { 123, 25, 6 },
                    { 124, 26, 6 },
                    { 125, 27, 6 },
                    { 126, 28, 6 },
                    { 127, 21, 7 },
                    { 128, 22, 7 },
                    { 129, 23, 7 },
                    { 130, 11, 7 }
                });

            migrationBuilder.InsertData(
                table: "UserCompanies",
                columns: new[] { "Id", "CompanyId", "UserId" },
                values: new object[,]
                {
                    { 131, 12, 7 },
                    { 132, 13, 7 },
                    { 133, 14, 7 },
                    { 134, 15, 7 },
                    { 135, 24, 7 },
                    { 136, 25, 7 },
                    { 137, 6, 7 },
                    { 138, 7, 7 },
                    { 139, 8, 7 },
                    { 140, 9, 7 },
                    { 141, 10, 7 },
                    { 142, 16, 7 },
                    { 143, 17, 7 },
                    { 144, 18, 7 },
                    { 145, 19, 7 },
                    { 146, 20, 7 },
                    { 147, 1, 7 },
                    { 148, 2, 7 },
                    { 149, 3, 7 },
                    { 150, 4, 7 },
                    { 151, 5, 7 },
                    { 152, 26, 7 },
                    { 153, 27, 7 },
                    { 154, 28, 7 }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CompanyContentId", "Description", "Image", "InfulonserId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Juicy Beauty was first founded in 2012 in Syria, Damascus. Juicy Beauty was first introduced in Lebanon in 2018.Juicy Beauty is an example of innovation in form due to its display with the largest makeup color made of vibrant and pure pigments and in substancethanks to the exclusive formulas and the revolutionary texture of its makeup products.Behind each product is the excellent research of an expert scientific team that develops new technologies and original formulas.High quality and extreme safety in addition to creativity, taste, and a focus on detail.That’s how JUICY ensures the finest standards of excellence through products that are both gentle and highly effective: Makeup formulas are produced in Europe. The range is subjected to accurate and in-depth safety evaluation.Juicy Beauty is the definition of having fun with makeup, trying new things,and feeling free! Not sure where to start? Why not visit our branches that are all over lebanon and test our products!", null, null, "JUICY BEAUTY" },
                    { 2, 2, "Huda Beauty is a cosmetics line  the brand has a positive reputation on some of its products, such as the popular fake eyelashes series, as well as a collection of foundations, eyeshadows and some face palettes", null, null, "HUDA BEAUTY" },
                    { 3, 3, "Maybelline, is an American multinational cosmetics, skin care, fragrance, and personal care company, based in New York City. It was founded in Chicago in 1914", null, null, "MAYBELLINE" },
                    { 4, 4, "L'Oréal  is a French personal care company headquartered in Clichy, Hauts-de-Seinewith a registered office in Paris. It is the world's largest cosmetics company and has developed activities in the field concentrating on hair color, skin care, sun protection, make-up, perfume, and hair care.", null, null, "LOREAL" },
                    { 5, 5, "Collection ,Sephora offers beauty products including cosmetics, skincare, body, fragrance, nail color, beauty tools, body lotions and haircare.", null, null, "SEPHORA" },
                    { 6, 6, "Asics sponsors a variety of sports associations", null, null, "ASIC" },
                    { 7, 7, "Manufacturer of sports shoes and apparel. It was the largest sportswear manufacturer in Europe and the second largest after Nike in the world. Adidas products are traditionally distinguished by a three-line brand, which remains an element of the company's latest products", null, null, "ADDIDAS" },
                    { 8, 8, "The world’s largest athletic apparel company, Nike is best known for its footwear, apparel, and equipment. One of the most valuable brands among sport businesses,The company sponsors top athletes and sports teams around the world.", null, null, "NIKE" },
                    { 9, 9, "Puma, is a German multinational corporation that designs and manufactures athletic and casual footwear, apparel and accessories, which is headquartered in Herzogenaurach, Bavaria, Germany. Puma is the third largest sportswear manufacturer in the world", null, null, "PUMA" },
                    { 10, 10, "It is an American company that manufactures footwear and sportswear and is part of the Authentic Brands Group", null, null, "REEBOK" },
                    { 11, 11, "A clothing retailer, the company specializes in fast fashion, and its products include apparel, accessories, footwear, swimwear, cosmetics, and perfume. It is one of the largest clothing retailers in the world which also includes brands such as Bershka and Massimo Dutti.", null, null, "ZARA" },
                    { 12, 12, "Max Fashion is an Indian fashion brand under the banner of the Landmark Group in Dubai", null, null, "MAX" },
                    { 13, 13, "It is an Italian luxury fashion house specializing in ready-to-wear and haute couture, headquartered in Milan, Italy. Expanded to design raincoats, windbreakers, knitwear, leather goods, shoes, perfume, and accessories", null, null, "MONCLER" },
                    { 14, 14, "Lacoste S.A. is a French company. It sells clothing, footwear, sportswear, eyewear, leather goods, perfume, towels and watches", null, null, "LACOSTE" },
                    { 15, 15, "It is one of the most famous fashion companies in the world. The group enjoys a unified identity consisting of colours, authentic fashion and quality at democratic prices", null, null, "BENETTON" },
                    { 16, 16, "Kentucky Fried Chicken or KFC is a chain of fast food restaurants that specializes primarily in fried chicken.  It is the second largest chain of fast food restaurants in the world in terms of sales after McDonald's. Kentucky Fried Chicken has nearly twenty thousand branches spread over 123 countries and territories around the world.", null, null, "KFC" },
                    { 17, 17, "MCDONALD'S is the world's largest restaurant chain by revenue,McDonald's is best known for its hamburgers, cheeseburgers and french fries, although their menus include other items like chicken, fish, fruit, and salads", null, null, "MCDONALDS" },
                    { 18, 18, "Nestlé is a multinational company specializing in the production of canned foods, founded in Vevey, Switzerland.", null, null, "NESTLE" },
                    { 19, 19, "STARBUCKS is a specialty coffee retailer. It roasts, markets, and retails specialty coffee. The company, through its stores, offers several blends of coffee, handcrafted beverages, merchandise, and food items", null, null, "STARBUCKS" },
                    { 20, 20, "Pizza Hut is an American multinational restaurant chain and international franchise founded in 1958 in Wichita, Kansas by Dan and Frank Carney. They serve their signature pan pizza and other dishes including pasta, breadsticks and desserts.", null, null, "PIZZA HUT" },
                    { 21, 21, " Samsung Electronics is the world's largest electronics and information technology company.  Samsung Electronics is part of the Samsung Group, which is the largest conglomerate in South Korea and the global market leader with more than 60 products including semiconductors such as DRAM and flash memory, digital display devices such as liquid crystal TVs  LCD and plasma, consumer electronics such as DVD players, mobile phones, digital cameras and laser printers, household appliances such as refrigerators, microwaves and dishwashers.", null, null, "SAMSUNG" },
                    { 22, 22, "The Apple Corporation is an American multinational technology company specializing in consumer electronics, software and online services.  It is one of the top five American IT companies", null, null, "APPLE" },
                    { 23, 23, "The Korean LG Group this company is the second largest holding company, producing electronics, chemicals and telecommunications products.  from 80 countries", null, null, "LG" },
                    { 24, 24, "Netflix is   an American entertainment company that specializes in providing live broadcasting, video-on-demand, and mail-delivery of CDs. Netflix has expanded into the production of films and television shows, and online video distribution", null, null, "NETFLIX" },
                    { 25, 25, "Shahid is the first Arab platform to provide \"Video on Demand\" service in the Middle East, and it has been re-launched by the \"MBC\" media group.  It is worth noting that Shahid,the leading subscription video-on-demand platform, is considered the leading Arab broadcasting platform in the world and the home of original Arabic productions with world-class specifications.along with a live broadcast of a group of the most watched Arab TV channels", null, null, "SHAHID" },
                    { 26, 26, "DIOR Products Clothing, cosmetics, fashion accessories, jewelry, perfumes, watches", null, null, "DIOR" },
                    { 27, 27, "Chanel Its products cover clothes, fragrances, handbags and watches", null, null, "CHANNEL" },
                    { 28, 28, "Gucci offers a range of different luxury  Shoes, ready-to-wear apparel, watches, and jewelry are the other main , however they also sell other products such as perfume and home decor", null, null, "GUCCI" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ConversationId", "JobId", "MessageStatus", "SendTime", "Text" },
                values: new object[,]
                {
                    { 1, 1, null, false, new DateTime(2022, 8, 18, 0, 11, 32, 773, DateTimeKind.Local).AddTicks(6754), "hi thanke you very match for this it was nice one" },
                    { 2, 1, null, true, new DateTime(2022, 8, 18, 0, 11, 32, 773, DateTimeKind.Local).AddTicks(6777), "hi thanke you very match for this it was nice one" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "BrandId", "Description", "Image", "InfulonserId", "JobId", "dateTime" },
                values: new object[,]
                {
                    { 16, 1, "Excellent beauty products", null, null, null, new DateTime(2022, 8, 18, 0, 11, 32, 774, DateTimeKind.Local).AddTicks(120) },
                    { 17, 2, " Excellent beauty products", null, null, null, new DateTime(2022, 8, 18, 0, 11, 32, 774, DateTimeKind.Local).AddTicks(140) },
                    { 18, 3, "Excellent beauty products", null, null, null, new DateTime(2022, 8, 18, 0, 11, 32, 774, DateTimeKind.Local).AddTicks(163) },
                    { 19, 4, "Excellent beauty products", null, null, null, new DateTime(2022, 8, 18, 0, 11, 32, 774, DateTimeKind.Local).AddTicks(184) },
                    { 20, 5, "Excellent beauty products", null, null, null, new DateTime(2022, 8, 18, 0, 11, 32, 774, DateTimeKind.Local).AddTicks(204) },
                    { 21, 6, "Great sports products", null, null, null, new DateTime(2022, 8, 18, 0, 11, 32, 774, DateTimeKind.Local).AddTicks(223) },
                    { 22, 7, "Great sports products", null, null, null, new DateTime(2022, 8, 18, 0, 11, 32, 774, DateTimeKind.Local).AddTicks(243) },
                    { 23, 8, "Great sports products", null, null, null, new DateTime(2022, 8, 18, 0, 11, 32, 774, DateTimeKind.Local).AddTicks(335) },
                    { 24, 9, "Great sports products", null, null, null, new DateTime(2022, 8, 18, 0, 11, 32, 774, DateTimeKind.Local).AddTicks(357) },
                    { 25, 10, "Great sports products", null, null, null, new DateTime(2022, 8, 18, 0, 11, 32, 774, DateTimeKind.Local).AddTicks(377) },
                    { 26, 11, "Gorgeous and comfortable clothes", null, null, null, new DateTime(2022, 8, 18, 0, 11, 32, 774, DateTimeKind.Local).AddTicks(398) },
                    { 27, 12, "Gorgeous and comfortable clothes", null, null, null, new DateTime(2022, 8, 18, 0, 11, 32, 774, DateTimeKind.Local).AddTicks(418) },
                    { 28, 13, "Gorgeous and comfortable clothes", null, null, null, new DateTime(2022, 8, 18, 0, 11, 32, 774, DateTimeKind.Local).AddTicks(437) },
                    { 29, 14, "Gorgeous and comfortable clothes", null, null, null, new DateTime(2022, 8, 18, 0, 11, 32, 774, DateTimeKind.Local).AddTicks(457) },
                    { 30, 15, "Gorgeous and comfortable clothes", null, null, null, new DateTime(2022, 8, 18, 0, 11, 32, 774, DateTimeKind.Local).AddTicks(478) },
                    { 31, 16, "Great Fast Food", null, null, null, new DateTime(2022, 8, 18, 0, 11, 32, 774, DateTimeKind.Local).AddTicks(498) },
                    { 32, 17, "Great Fast Food", null, null, null, new DateTime(2022, 8, 18, 0, 11, 32, 774, DateTimeKind.Local).AddTicks(518) },
                    { 33, 18, "Great Drinks & Snaks", null, null, null, new DateTime(2022, 8, 18, 0, 11, 32, 774, DateTimeKind.Local).AddTicks(538) },
                    { 34, 19, "Great Drinks", null, null, null, new DateTime(2022, 8, 18, 0, 11, 32, 774, DateTimeKind.Local).AddTicks(561) },
                    { 35, 20, "Great Pizza", null, null, null, new DateTime(2022, 8, 18, 0, 11, 32, 774, DateTimeKind.Local).AddTicks(582) },
                    { 36, 21, "Fantastic portable devices", null, null, null, new DateTime(2022, 8, 18, 0, 11, 32, 774, DateTimeKind.Local).AddTicks(602) },
                    { 37, 22, "Fantastic portable devices", null, null, null, new DateTime(2022, 8, 18, 0, 11, 32, 774, DateTimeKind.Local).AddTicks(622) },
                    { 38, 23, "Cool electronics", null, null, null, new DateTime(2022, 8, 18, 0, 11, 32, 774, DateTimeKind.Local).AddTicks(642) },
                    { 39, 24, "interesting series", null, null, null, new DateTime(2022, 8, 18, 0, 11, 32, 774, DateTimeKind.Local).AddTicks(661) },
                    { 40, 25, "interesting series", null, null, null, new DateTime(2022, 8, 18, 0, 11, 32, 774, DateTimeKind.Local).AddTicks(681) },
                    { 41, 26, "interesting Perfum", null, null, null, new DateTime(2022, 8, 18, 0, 11, 32, 774, DateTimeKind.Local).AddTicks(701) },
                    { 42, 27, "interesting Perfum", null, null, null, new DateTime(2022, 8, 18, 0, 11, 32, 774, DateTimeKind.Local).AddTicks(721) },
                    { 43, 28, "interesting Perfum", null, null, null, new DateTime(2022, 8, 18, 0, 11, 32, 774, DateTimeKind.Local).AddTicks(740) }
                });

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
                    { 9, 1, "32434", "This some Text about found", null, "Tant", 700.0 },
                    { 10, 2, "33333", "This some Text about found", null, "Foundation", 600.0 },
                    { 11, 2, "33333", "This some Text about found", null, "CareKream", 300.0 },
                    { 12, 2, "33333", "This some Text about found", null, "Mascara", 1200.0 },
                    { 13, 3, "33333", "This some Text about found", null, "CareSun", 500.0 },
                    { 14, 3, "33333", "This some Text about found", null, "Plasher", 800.0 },
                    { 15, 3, "33333", "This some Text about found", null, "Tant", 300.0 },
                    { 16, 4, "32434", "This some Text about found", null, "CareSun", 400.0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "Code", "Description", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 17, 4, "32434", "This some Text about found", null, "Plasher", 600.0 },
                    { 18, 4, "32434", "This some Text about found", null, "Oclador", 178.0 },
                    { 19, 5, "32434", "This some Text about found", null, "Foundation", 350.0 },
                    { 20, 5, "32434", "This some Text about found", null, "CareKream", 290.0 },
                    { 21, 5, "32434", "This some Text about found", null, "CareSun", 400.0 },
                    { 22, 6, "44444", "This some Text about found", null, "Pajamas", 2000.0 },
                    { 23, 6, "44444", "This some Text about found", null, "Shoes", 1500.0 },
                    { 24, 6, "44444", "This some Text about found", null, "Bags", 1200.0 },
                    { 25, 7, "55555", "This some Text about found", null, "Pajamas", 2000.0 },
                    { 26, 7, "55555", "This some Text about found", null, "Shoes", 1500.0 },
                    { 27, 7, "55555", "This some Text about found", null, "Bags", 1200.0 },
                    { 28, 8, "44444", "This some Text about found", null, "Pajamas", 2000.0 },
                    { 29, 8, "44444", "This some Text about found", null, "Shoes", 1500.0 },
                    { 30, 8, "44444", "This some Text about found", null, "Bags", 1200.0 },
                    { 31, 9, "44444", "This some Text about found", null, "Pajamas", 2000.0 },
                    { 32, 9, "44444", "This some Text about found", null, "Shoes", 1500.0 },
                    { 33, 9, "44444", "This some Text about found", null, "Bags", 1200.0 },
                    { 34, 10, "44444", "This some Text about found", null, "Pajamas", 2000.0 },
                    { 35, 10, "44444", "This some Text about found", null, "Shoes", 1500.0 },
                    { 36, 10, "44444", "This some Text about found", null, "Bags", 1200.0 },
                    { 37, 11, "55555", "This some Text about found", null, "T Shirt", 800.0 },
                    { 38, 11, "55555", "This some Text about found", null, "Pants", 1000.0 },
                    { 39, 11, "55555", "This some Text about found", null, "Jacket", 1100.0 },
                    { 40, 12, "55555", "This some Text about found", null, "T Shirt", 800.0 },
                    { 41, 12, "55555", "This some Text about found", null, "Pants", 1000.0 },
                    { 42, 12, "55555", "This some Text about found", null, "Jacket", 1100.0 },
                    { 43, 13, "55555", "This some Text about found", null, "T Shirt", 800.0 },
                    { 44, 13, "55555", "This some Text about found", null, "Pants", 1000.0 },
                    { 45, 13, "55555", "This some Text about found", null, "Jacket", 1100.0 },
                    { 46, 14, "55555", "This some Text about found", null, "T Shirt", 800.0 },
                    { 47, 14, "55555", "This some Text about found", null, "Pants", 1000.0 },
                    { 48, 14, "55555", "This some Text about found", null, "Jacket", 1100.0 },
                    { 49, 15, "55555", "This some Text about found", null, "T Shirt", 800.0 },
                    { 50, 15, "55555", "This some Text about found", null, "Pants", 1000.0 },
                    { 51, 15, "55555", "This some Text about found", null, "Jacket", 1100.0 },
                    { 52, 16, "55555", "This some Text about found", null, "Fried", 100.0 },
                    { 53, 16, "55555", "This some Text about found", null, "Sandwich", 800.0 },
                    { 54, 16, "55555", "This some Text about found", null, "Fried chicken", 1000.0 },
                    { 55, 17, "55555", "This some Text about found", null, "Fried", 100.0 },
                    { 56, 17, "55555", "This some Text about found", null, "Sandwich", 800.0 },
                    { 57, 17, "55555", "This some Text about found", null, "Fried chicken", 1000.0 },
                    { 58, 18, "55555", "This some Text about found", null, "Melo", 500.0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "Code", "Description", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 59, 18, "55555", "This some Text about found", null, "3 in 1", 400.0 },
                    { 60, 18, "55555", "This some Text about found", null, "Biscuits", 200.0 },
                    { 61, 19, "55555", "This some Text about found", null, "Milk Shake", 500.0 },
                    { 62, 19, "55555", "This some Text about found", null, "Coffie", 400.0 },
                    { 63, 20, "55555", "This some Text about found", null, "Pizza Mushroom", 1000.0 },
                    { 64, 20, "55555", "This some Text about found", null, "Pizza 4 seasons", 1200.0 },
                    { 65, 21, "55555", "This some Text about found", null, "Mobile", 5000.0 },
                    { 66, 21, "55555", "This some Text about found", null, "Labtop", 8000.0 },
                    { 67, 22, "55555", "This some Text about found", null, "Mobile", 5000.0 },
                    { 68, 22, "55555", "This some Text about found", null, "Labtop", 8000.0 },
                    { 69, 23, "55555", "This some Text about found", null, "Washing Machine", 9000.0 },
                    { 70, 23, "55555", "This some Text about found", null, "TV", 6500.0 },
                    { 71, 24, "55555", "This some Text about found", null, "Game Og Throns", 200.0 },
                    { 72, 24, "55555", "This some Text about found", null, "Friends", 200.0 },
                    { 73, 25, "55555", "This some Text about found", null, "باب  الحارة", 200.0 },
                    { 74, 25, "55555", "This some Text about found", null, "الهيبة", 200.0 },
                    { 75, 26, "55555", "This some Text about found", null, "Dior", 900.0 },
                    { 76, 27, "55555", "This some Text about found", null, "Channel", 900.0 },
                    { 77, 28, "55555", "This some Text about found", null, "Gucci", 900.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_ProductId",
                table: "Baskets",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_UserPostId",
                table: "Baskets",
                column: "UserPostId");

            migrationBuilder.CreateIndex(
                name: "IX_Brands_CompanyContentId",
                table: "Brands",
                column: "CompanyContentId");

            migrationBuilder.CreateIndex(
                name: "IX_Brands_InfulonserId",
                table: "Brands",
                column: "InfulonserId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyContents_CompanyId",
                table: "CompanyContents",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyContents_ContentId",
                table: "CompanyContents",
                column: "ContentId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyInfulonsers_CompanyId",
                table: "CompanyInfulonsers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyInfulonsers_InfulonserId",
                table: "CompanyInfulonsers",
                column: "InfulonserId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyTypes_CompanyId",
                table: "CompanyTypes",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Conversations_CompanyId",
                table: "Conversations",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Conversations_InfulonserId",
                table: "Conversations",
                column: "InfulonserId");

            migrationBuilder.CreateIndex(
                name: "IX_InfulonserContents_ContentId",
                table: "InfulonserContents",
                column: "ContentId");

            migrationBuilder.CreateIndex(
                name: "IX_InfulonserContents_InfulonserId",
                table: "InfulonserContents",
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
                name: "IX_InfulonserUsers_InfulonserId",
                table: "InfulonserUsers",
                column: "InfulonserId");

            migrationBuilder.CreateIndex(
                name: "IX_InfulonserUsers_UserId",
                table: "InfulonserUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_BrandId",
                table: "Jobs",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_InfulonserId",
                table: "Jobs",
                column: "InfulonserId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ConversationId",
                table: "Messages",
                column: "ConversationId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_JobId",
                table: "Messages",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_PostInfulonsers_InfulonserId",
                table: "PostInfulonsers",
                column: "InfulonserId");

            migrationBuilder.CreateIndex(
                name: "IX_PostInfulonsers_PostId",
                table: "PostInfulonsers",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_BrandId",
                table: "Posts",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_InfulonserId",
                table: "Posts",
                column: "InfulonserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_JobId",
                table: "Posts",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCompanies_CompanyId",
                table: "UserCompanies",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCompanies_UserId",
                table: "UserCompanies",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPosts_PostId",
                table: "UserPosts",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPosts_UserId",
                table: "UserPosts",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Baskets");

            migrationBuilder.DropTable(
                name: "CompanyInfulonsers");

            migrationBuilder.DropTable(
                name: "CompanyTypes");

            migrationBuilder.DropTable(
                name: "InfulonserContents");

            migrationBuilder.DropTable(
                name: "InfulonserFollowInfulonsers");

            migrationBuilder.DropTable(
                name: "InfulonserUsers");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "PostInfulonsers");

            migrationBuilder.DropTable(
                name: "UserCompanies");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "UserPosts");

            migrationBuilder.DropTable(
                name: "Conversations");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "CompanyContents");

            migrationBuilder.DropTable(
                name: "Infulonsers");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Contents");
        }
    }
}
