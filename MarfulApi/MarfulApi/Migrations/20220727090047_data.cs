using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarfulApi.Migrations
{
    public partial class data : Migration
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
                    CompanyContentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Brands_CompanyContents_CompanyContentId",
                        column: x => x.CompanyContentId,
                        principalTable: "CompanyContents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    { 1, "From Streat", "MakeUp For Weman", "company1@test.com", null, "JUICY BEAUTY", "12123", "0921423432", "4232543" },
                    { 2, "From Streat", "Asics sponsors a variety of sports associations", "Asics@test.com", null, "ASIC", "111222", "0921423432", "223554" }
                });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Just for Weman", "MackeUp" },
                    { 2, "All About sports", "Sports" }
                });

            migrationBuilder.InsertData(
                table: "Infulonsers",
                columns: new[] { "Id", "Address", "Description", "Email", "Image", "Name", "Password", "Paypal", "Phone", "UserName" },
                values: new object[,]
                {
                    { 1, "USA LA", "Noor Stars, the first Arabic YouTuber to reach 10 million subscribers, was born in Iraq and grew up in Syria. Having spent her childhood in Damascus, she moved to Turkey for 3 years before moving to the United States with her mother and siblings. She completed her secondary education and university degree, specialising in business administration. Since her channel’s creation in 2014, Noor has posted over 550 videos on her channel, with over 18 million subscribers and 2 billion views in total. She was part of the Maybelline New York's Web series which was named Ramadan stars with Noor Stars and the web series won YouTube's The Lantern award 2019. Noor is best known for her content related to beauty, comics and vlogs.", "info@test.com", null, "NoorStars", "0000", "dskjfhjh", "0965465760", "NoorStars" },
                    { 2, "USA LA", "Joshua Patterson is an actor, known for ER (1994), 7th Heaven (1996) and Weird Science (1994).", "Joshua@test.com", null, "Joshua Patterson", "1111", "dskjffff", "0965465760", "Joshua" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "Image", "Name", "Password", "Paypal", "Phone", "UserName" },
                values: new object[,]
                {
                    { 1, 20, "user1@test.com", null, "Noor", "123", "Lb1267", "0964654765", "NonoSy" },
                    { 2, 20, "user2@test.com", null, "Ahamad", "456", "Lb1267", "0964654765", "hamodaSy" },
                    { 3, 20, "user3@test.com", null, "Tala", "789", "Lb1267", "0964654765", "totoSy" }
                });

            migrationBuilder.InsertData(
                table: "CompanyContents",
                columns: new[] { "Id", "CompanyId", "ContentId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "CompanyInfulonsers",
                columns: new[] { "Id", "CompanyId", "Followed", "InfulonserId" },
                values: new object[] { 1, 1, "company", 2 });

            migrationBuilder.InsertData(
                table: "Conversations",
                columns: new[] { "Id", "CompanyId", "InfulonserId", "Start" },
                values: new object[] { 1, 1, 1, new DateTime(2022, 7, 27, 12, 0, 46, 744, DateTimeKind.Local).AddTicks(9514) });

            migrationBuilder.InsertData(
                table: "InfulonserContents",
                columns: new[] { "Id", "ContentId", "InfulonserId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "InfulonserFollowInfulonsers",
                columns: new[] { "Id", "FollowId", "FollowedId" },
                values: new object[] { 1, 2, 1 });

            migrationBuilder.InsertData(
                table: "InfulonserUsers",
                columns: new[] { "Id", "InfulonserId", "UserId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "BrandId", "Description", "Image", "InfulonserId", "JobId", "dateTime" },
                values: new object[,]
                {
                    { 1, null, " test for infulonser post", null, 1, null, new DateTime(2022, 7, 27, 12, 0, 46, 744, DateTimeKind.Local).AddTicks(9629) },
                    { 2, null, " test another post for infulonser", null, 1, null, new DateTime(2022, 7, 27, 12, 0, 46, 744, DateTimeKind.Local).AddTicks(9642) }
                });

            migrationBuilder.InsertData(
                table: "UserCompanies",
                columns: new[] { "Id", "CompanyId", "UserId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CompanyContentId", "Description", "Image", "InfulonserId", "Name" },
                values: new object[] { 1, 1, "Juicy Beauty was first founded in 2012 in Syria, Damascus. Juicy Beauty was first introduced in Lebanon in 2018.Juicy Beauty is an example of innovation in form due to its display with the largest makeup color made of vibrant and pure pigments and in substancethanks to the exclusive formulas and the revolutionary texture of its makeup products.Behind each product is the excellent research of an expert scientific team that develops new technologies and original formulas.High quality and extreme safety in addition to creativity, taste, and a focus on detail.That’s how JUICY ensures the finest standards of excellence through products that are both gentle and highly effective: Makeup formulas are produced in Europe. The range is subjected to accurate and in-depth safety evaluation.Juicy Beauty is the definition of having fun with makeup, trying new things,and feeling free! Not sure where to start? Why not visit our branches that are all over lebanon and test our products!", null, null, "JUICY BEAUTY" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ConversationId", "JobId", "MessageStatus", "SendTime", "Text" },
                values: new object[,]
                {
                    { 1, 1, null, false, new DateTime(2022, 7, 27, 12, 0, 46, 744, DateTimeKind.Local).AddTicks(9573), "hi thanke you very match for this it was nice one" },
                    { 2, 1, null, true, new DateTime(2022, 7, 27, 12, 0, 46, 744, DateTimeKind.Local).AddTicks(9585), "hi thanke you very match for this it was nice one" }
                });

            migrationBuilder.InsertData(
                table: "UserPosts",
                columns: new[] { "Id", "InterAction", "PostId", "UserId" },
                values: new object[,]
                {
                    { 1, true, 1, 1 },
                    { 2, false, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "BrandId", "Description", "Image", "InfulonserId", "JobId", "dateTime" },
                values: new object[,]
                {
                    { 3, 1, " test for company post", null, null, null, new DateTime(2022, 7, 27, 12, 0, 46, 744, DateTimeKind.Local).AddTicks(9689) },
                    { 4, 1, " test another post for company", null, null, null, new DateTime(2022, 7, 27, 12, 0, 46, 744, DateTimeKind.Local).AddTicks(9701) }
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
                    { 9, 1, "32434", "This some Text about found", null, "Tant", 700.0 }
                });

            migrationBuilder.InsertData(
                table: "UserPosts",
                columns: new[] { "Id", "InterAction", "PostId", "UserId" },
                values: new object[] { 3, true, 4, 1 });

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
