using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarfulApi.Migrations
{
    public partial class addnullablecompanyContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brands_CompanyContents_CompanyContentId",
                table: "Brands");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyContentId",
                table: "Brands",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Email" },
                values: new object[] { "JUICY BEAUTY is the place where you can talk about makeup. You can go there for advice from the brand’s makeup artists and cosmetics experts. You can play with new colors and, with the 50 products on display, experiment with new looks and effective makeup products that are tailored to your needs", "JUICYBEAUTY@test.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Email", "Name", "Password", "TelePhone" },
                values: new object[] { "Huda Beauty is a cosmetics line  the brand has a positive reputation on some of its products, such as the popular fake eyelashes series, as well as a collection of foundations, eyeshadows and some face palettes", "hudabeauty@test.com", "HUDA BEAUTY", "12123", "4232543" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "Description", "Email", "Image", "Name", "Password", "Phone", "TelePhone" },
                values: new object[,]
                {
                    { 3, "From Streat", "Maybelline, is an American multinational cosmetics, skin care, fragrance, and personal care company, based in New York City. It was founded in Chicago in 1914", "MAYBELLINE@test.com", null, "MAYBELLINE", "12123", "0921423432", "4232543" },
                    { 4, "From Streat", "L'Oréal  is a French personal care company headquartered in Clichy, Hauts-de-Seinewith a registered office in Paris. It is the world's largest cosmetics company and has developed activities in the field concentrating on hair color, skin care, sun protection, make-up, perfume, and hair care.", "LOREAL@test.com", null, "LOREAL", "12123", "0921423432", "4232543" },
                    { 5, "From Streat", "Collection ,Sephora offers beauty products including cosmetics, skincare, body, fragrance, nail color, beauty tools, body lotions and haircare.", "SEPHORA@test.com", null, "SEPHORA", "12123", "0921423432", "4232543" },
                    { 6, "From Streat", "Asics sponsors a variety of sports associations", "Asics@test.com", null, "ASIC", "111222", "0921423432", "223554" },
                    { 7, "From Streat", "Manufacturer of sports shoes and apparel. It was the largest sportswear manufacturer in Europe and the second largest after Nike in the world. Adidas products are traditionally distinguished by a three-line brand, which remains an element of the company's latest products", "ADDIDAS@test.com", null, "ADDIDAS", "111222", "0921423432", "223554" },
                    { 8, "From Streat", "The world’s largest athletic apparel company, Nike is best known for its footwear, apparel, and equipment. One of the most valuable brands among sport businesses,The company sponsors top athletes and sports teams around the world.", "NIKE@test.com", null, "NIKE", "111222", "0921423432", "223554" },
                    { 9, "From Streat", "Puma, is a German multinational corporation that designs and manufactures athletic and casual footwear, apparel and accessories, which is headquartered in Herzogenaurach, Bavaria, Germany. Puma is the third largest sportswear manufacturer in the world", "PUMA@test.com", null, "PUMA", "111222", "0921423432", "223554" },
                    { 10, "Reebok International Limited (/ˈriːbɒk/) is an American fitness footwear and clothing manufacturer that is a part of Authentic Brands Group.", "Asics sponsors a variety of sports associations", "REEBOK@test.com", null, "REEBOK", "111222", "0921423432", "223554" },
                    { 11, "From Streat", "A clothing retailer, the company specializes in fast fashion, and its products include apparel, accessories, footwear, swimwear, cosmetics, and perfume. It is one of the largest clothing retailers in the world which also includes brands such as Bershka and Massimo Dutti.", "ZARA@test.com", null, "ZARA", "111222", "0921423432", "223554" },
                    { 12, "From Streat", "Max Fashion is an Indian fashion brand under the banner of the Landmark Group in Dubai", "MAX@test.com", null, "MAX", "111222", "0921423432", "223554" },
                    { 13, "From Streat", "It is an Italian luxury fashion house specializing in ready-to-wear and haute couture, headquartered in Milan, Italy. Expanded to design raincoats, windbreakers, knitwear, leather goods, shoes, perfume, and accessories", "MONCLER@test.com", null, "MONCLER", "111222", "0921423432", "223554" },
                    { 14, "From Streat", "Lacoste S.A. is a French company. It sells clothing, footwear, sportswear, eyewear, leather goods, perfume, towels and watches", "LACOSTE@test.com", null, "LACOSTE", "111222", "0921423432", "223554" },
                    { 15, "From Streat", "It is one of the most famous fashion companies in the world. The group enjoys a unified identity consisting of colours, authentic fashion and quality at democratic prices", "BENETTON@test.com", null, "BENETTON", "111222", "0921423432", "223554" },
                    { 16, "Louisville, KentuckyFrom Streat", "Kentucky Fried Chicken or KFC is a chain of fast food restaurants that specializes primarily in fried chicken.  It is the second largest chain of fast food restaurants in the world in terms of sales after McDonald's. Kentucky Fried Chicken has nearly twenty thousand branches spread over 123 countries and territories around the world.", "KFC@test.com", null, "KFC", "111222", "0921423432", "223554" },
                    { 17, "From Streat", "MCDONALD'S is the world's largest restaurant chain by revenue,McDonald's is best known for its hamburgers, cheeseburgers and french fries, although their menus include other items like chicken, fish, fruit, and salads", "MCDONALDS@test.com", null, "MCDONALDS", "111222", "0921423432", "223554" },
                    { 18, "From Streat", "Nestlé is a multinational company specializing in the production of canned foods, founded in Vevey, Switzerland.", "NESTLE@test.com", null, "NESTLE", "111222", "0921423432", "223554" },
                    { 19, "From Streat", "STARBUCKS is a specialty coffee retailer. It roasts, markets, and retails specialty coffee. The company, through its stores, offers several blends of coffee, handcrafted beverages, merchandise, and food items", "STARBUCKS@test.com", null, "STARBUCKS", "111222", "0921423432", "223554" },
                    { 20, "From Streat", "Pizza Hut is an American multinational restaurant chain and international franchise founded in 1958 in Wichita, Kansas by Dan and Frank Carney. They serve their signature pan pizza and other dishes including pasta, breadsticks and desserts.", "PIZZAHUT@test.com", null, "PIZZA HUT", "111222", "0921423432", "223554" },
                    { 21, "Suwon, South Korea", " Samsung Electronics is the world's largest electronics and information technology company.  Samsung Electronics is part of the Samsung Group, which is the largest conglomerate in South Korea and the global market leader with more than 60 products including semiconductors such as DRAM and flash memory, digital display devices such as liquid crystal TVs  LCD and plasma, consumer electronics such as DVD players, mobile phones, digital cameras and laser printers, household appliances such as refrigerators, microwaves and dishwashers.", "SAMSUNG@test.com", null, "SAMSUNG", "111222", "0921423432", "223554" },
                    { 22, "Cupertino, California, United States", "The Apple Corporation is an American multinational technology company specializing in consumer electronics, software and online services.  It is one of the top five American IT companies", "APPLE@test.com", null, "APPLE", "111222", "0921423432", "223554" },
                    { 23, "South Korea", "The Korean LG Group this company is the second largest holding company, producing electronics, chemicals and telecommunications products.  from 80 countries", "LG@test.com", null, "LG", "111222", "0921423432", "223554" },
                    { 24, " Los Gatos, California", "Netflix is   an American entertainment company that specializes in providing live broadcasting, video-on-demand, and mail-delivery of CDs. Netflix has expanded into the production of films and television shows, and online video distribution", "NETFLIX@test.com", null, "NETFLIX", "111222", "0921423432", "223554" },
                    { 25, "From Streat", "Shahid is the first Arab platform to provide \"Video on Demand\" service in the Middle East, and it has been re-launched by the \"MBC\" media group.  It is worth noting that Shahid,the leading subscription video-on-demand platform, is considered the leading Arab broadcasting platform in the world and the home of original Arabic productions with world-class specifications.along with a live broadcast of a group of the most watched Arab TV channels", "SHAHID@test.com", null, "SHAHID", "111222", "0921423432", "223554" },
                    { 26, "From Streat", "DIOR Products Clothing, cosmetics, fashion accessories, jewelry, perfumes, watches", "DIOR@test.com", null, "DIOR", "111222", "0921423432", "223554" },
                    { 27, "From Streat", "Chanel Its products cover clothes, fragrances, handbags and watches", "CHANNEL@test.com", null, "CHANNEL", "111222", "0921423432", "223554" },
                    { 28, "From Streat", "Gucci offers a range of different luxury  Shoes, ready-to-wear apparel, watches, and jewelry are the other main , however they also sell other products such as perfume and home decor", "Gucci@test.com", null, "GUCCI", "111222", "0921423432", "223554" }
                });

            migrationBuilder.UpdateData(
                table: "CompanyContents",
                keyColumn: "Id",
                keyValue: 2,
                column: "ContentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "InfulonserId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CompanyId", "Followed" },
                values: new object[] { 2, "company" });

            migrationBuilder.InsertData(
                table: "CompanyInfulonsers",
                columns: new[] { "Id", "CompanyId", "Followed", "InfulonserId" },
                values: new object[,]
                {
                    { 54, 1, "infulonser", 1 },
                    { 56, 2, "infulonser", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "All About MakeUp");

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 3, "All About Clothes", "Clothes" },
                    { 4, "All About Food", "Food" },
                    { 5, "All About electronics", "Electronics" },
                    { 6, "All About Movies & Series", "Platforms" },
                    { 7, "All About Perfumes", "Perfumes" }
                });

            migrationBuilder.UpdateData(
                table: "Conversations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Start",
                value: new DateTime(2022, 8, 15, 14, 17, 18, 513, DateTimeKind.Local).AddTicks(2825));

            migrationBuilder.InsertData(
                table: "InfulonserContents",
                columns: new[] { "Id", "ContentId", "InfulonserId" },
                values: new object[] { 3, 2, 2 });

            migrationBuilder.UpdateData(
                table: "InfulonserFollowInfulonsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FollowId", "FollowedId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "InfulonserFollowInfulonsers",
                columns: new[] { "Id", "FollowId", "FollowedId" },
                values: new object[] { 2, 2, 1 });

            migrationBuilder.InsertData(
                table: "Infulonsers",
                columns: new[] { "Id", "Address", "Description", "Email", "Image", "Name", "Password", "Paypal", "Phone", "UserName" },
                values: new object[,]
                {
                    { 3, "Dubai/Los Angeles", "You Tuber/Content Creator", "Ossy@test.com", null, "Ossy Marwah", "1111", "dskjffff", "0965465760", "Ossy" },
                    { 4, "DUBAI", "Critic/You Tuber", "barhom@test.com", null, "Ibrahim Almarrawi", "1111", "dskjffff", "0965465760", "barhom" },
                    { 5, "Dubia,United Arab Emirates", "foodblogger/cars/travel", "feras@test.com", null, "Feras Abo Shaar", "1111", "dskjffff", "0965465760", "Feras" },
                    { 6, "Dubia/London", "The Guy Who Drove Your Dream Car", "kareem@test.com", null, "Kareem Deeb", "1111", "dskjffff", "0965465760", "Deeb" },
                    { 7, "Syria", "journalist & Presenter @mbc1", "Leen@test.com", null, "Leen AbouShaar", "1111", "dskjffff", "0965465760", "Leen" }
                });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 8, 15, 14, 17, 18, 513, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 8, 15, 14, 17, 18, 513, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "dateTime",
                value: new DateTime(2022, 8, 15, 14, 17, 18, 513, DateTimeKind.Local).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "dateTime",
                value: new DateTime(2022, 8, 15, 14, 17, 18, 513, DateTimeKind.Local).AddTicks(3106));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "dateTime",
                value: new DateTime(2022, 8, 15, 14, 17, 18, 513, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "dateTime",
                value: new DateTime(2022, 8, 15, 14, 17, 18, 513, DateTimeKind.Local).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "dateTime",
                value: new DateTime(2022, 8, 15, 14, 17, 18, 513, DateTimeKind.Local).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "dateTime",
                value: new DateTime(2022, 8, 15, 14, 17, 18, 513, DateTimeKind.Local).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "dateTime",
                value: new DateTime(2022, 8, 15, 14, 17, 18, 513, DateTimeKind.Local).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "dateTime",
                value: new DateTime(2022, 8, 15, 14, 17, 18, 513, DateTimeKind.Local).AddTicks(3227));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Name", "UserName" },
                values: new object[] { "Hadel@test.com", "Hafel Dabbas", "hadel2000" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Name", "UserName" },
                values: new object[] { "Asia@test.com", "Asia", "Asel" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Name", "UserName" },
                values: new object[] { "yousfi@test.com", "Haya Yousfi", "Haya" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "Image", "Name", "Password", "Paypal", "Phone", "UserName" },
                values: new object[,]
                {
                    { 4, 20, "Eid@test.com", null, "Haya Eid", "789", "Lb1267", "0964654765", "HayaSy" },
                    { 5, 20, "lama@test.com", null, "Lama Boshi", "789", "Lb1267", "0964654765", "Lamaz" },
                    { 6, 20, "Hamzeh@test.com", null, "Hamze Badinjky", "789", "Lb1267", "0964654765", "hamzehS" },
                    { 7, 20, "Adam@test.com", null, "Adam Syria", "789", "Lb1267", "0964654765", "Adom" }
                });

            migrationBuilder.InsertData(
                table: "CompanyContents",
                columns: new[] { "Id", "CompanyId", "ContentId" },
                values: new object[,]
                {
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
                    { 3, 3, "company", 1 },
                    { 4, 4, "company", 1 },
                    { 5, 5, "company", 1 },
                    { 6, 11, "company", 1 },
                    { 7, 15, "company", 1 },
                    { 8, 22, "company", 1 },
                    { 9, 18, "company", 1 },
                    { 10, 24, "company", 1 },
                    { 11, 26, "company", 1 },
                    { 12, 27, "company", 1 },
                    { 13, 28, "company", 1 },
                    { 14, 1, "company", 7 },
                    { 15, 2, "company", 7 },
                    { 16, 5, "company", 7 },
                    { 17, 11, "company", 7 },
                    { 18, 12, "company", 7 }
                });

            migrationBuilder.InsertData(
                table: "CompanyInfulonsers",
                columns: new[] { "Id", "CompanyId", "Followed", "InfulonserId" },
                values: new object[,]
                {
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
                    { 55, 1, "infulonser", 7 },
                    { 57, 3, "infulonser", 7 },
                    { 58, 4, "infulonser", 7 },
                    { 59, 5, "infulonser", 1 },
                    { 60, 6, "infulonser", 2 },
                    { 61, 7, "infulonser", 2 },
                    { 62, 8, "infulonser", 5 }
                });

            migrationBuilder.InsertData(
                table: "CompanyInfulonsers",
                columns: new[] { "Id", "CompanyId", "Followed", "InfulonserId" },
                values: new object[,]
                {
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

            migrationBuilder.UpdateData(
                table: "InfulonserContents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ContentId", "InfulonserId" },
                values: new object[] { 1, 7 });

            migrationBuilder.InsertData(
                table: "InfulonserContents",
                columns: new[] { "Id", "ContentId", "InfulonserId" },
                values: new object[,]
                {
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
                    { 3, 2, 3 },
                    { 4, 3, 4 },
                    { 5, 4, 5 },
                    { 6, 5, 4 },
                    { 7, 6, 7 },
                    { 8, 7, 6 },
                    { 9, 7, 1 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_CompanyContents_CompanyContentId",
                table: "Brands",
                column: "CompanyContentId",
                principalTable: "CompanyContents",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brands_CompanyContents_CompanyContentId",
                table: "Brands");

            migrationBuilder.DeleteData(
                table: "CompanyContents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CompanyContents",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CompanyContents",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CompanyContents",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CompanyContents",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CompanyContents",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CompanyContents",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CompanyContents",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CompanyContents",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CompanyContents",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CompanyContents",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CompanyContents",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CompanyContents",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CompanyContents",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CompanyContents",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CompanyContents",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CompanyContents",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CompanyContents",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CompanyContents",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CompanyContents",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "CompanyContents",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "CompanyContents",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "CompanyContents",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "CompanyContents",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "CompanyContents",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "CompanyContents",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "InfulonserContents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "InfulonserContents",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "InfulonserContents",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "InfulonserContents",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "InfulonserContents",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "InfulonserContents",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "InfulonserContents",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "InfulonserContents",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "InfulonserContents",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "InfulonserContents",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "InfulonserFollowInfulonsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "InfulonserFollowInfulonsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "InfulonserFollowInfulonsers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "InfulonserFollowInfulonsers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "InfulonserFollowInfulonsers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "InfulonserFollowInfulonsers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "InfulonserFollowInfulonsers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "InfulonserFollowInfulonsers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Infulonsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Infulonsers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Infulonsers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Infulonsers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Infulonsers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyContentId",
                table: "Brands",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Email" },
                values: new object[] { "MakeUp For Weman", "company1@test.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Email", "Name", "Password", "TelePhone" },
                values: new object[] { "Asics sponsors a variety of sports associations", "Asics@test.com", "ASIC", "111222", "223554" });

            migrationBuilder.UpdateData(
                table: "CompanyContents",
                keyColumn: "Id",
                keyValue: 2,
                column: "ContentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "InfulonserId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CompanyInfulonsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CompanyId", "Followed" },
                values: new object[] { 1, "infulonser" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Just for Weman");

            migrationBuilder.UpdateData(
                table: "Conversations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Start",
                value: new DateTime(2022, 8, 8, 10, 50, 47, 208, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "InfulonserContents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ContentId", "InfulonserId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "InfulonserFollowInfulonsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FollowId", "FollowedId" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 8, 8, 10, 50, 47, 208, DateTimeKind.Local).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 8, 8, 10, 50, 47, 208, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "dateTime",
                value: new DateTime(2022, 8, 8, 10, 50, 47, 208, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "dateTime",
                value: new DateTime(2022, 8, 8, 10, 50, 47, 208, DateTimeKind.Local).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "dateTime",
                value: new DateTime(2022, 8, 8, 10, 50, 47, 208, DateTimeKind.Local).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "dateTime",
                value: new DateTime(2022, 8, 8, 10, 50, 47, 208, DateTimeKind.Local).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "dateTime",
                value: new DateTime(2022, 8, 8, 10, 50, 47, 208, DateTimeKind.Local).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "dateTime",
                value: new DateTime(2022, 8, 8, 10, 50, 47, 208, DateTimeKind.Local).AddTicks(4972));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "dateTime",
                value: new DateTime(2022, 8, 8, 10, 50, 47, 208, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "dateTime",
                value: new DateTime(2022, 8, 8, 10, 50, 47, 208, DateTimeKind.Local).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Name", "UserName" },
                values: new object[] { "user1@test.com", "Noor", "NonoSy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Name", "UserName" },
                values: new object[] { "user2@test.com", "Ahamad", "hamodaSy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Name", "UserName" },
                values: new object[] { "user3@test.com", "Tala", "totoSy" });

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_CompanyContents_CompanyContentId",
                table: "Brands",
                column: "CompanyContentId",
                principalTable: "CompanyContents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
