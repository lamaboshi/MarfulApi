﻿// <auto-generated />
using System;
using MarfulApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MarfulApi.Migrations
{
    [DbContext(typeof(MarfulDbContext))]
    partial class MarfulDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.4.22229.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MarfulApi.Model.Basket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.Property<int>("UserPostId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserPostId");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("MarfulApi.Model.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CompanyContentId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("InfulonserId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyContentId");

                    b.HasIndex("InfulonserId");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyContentId = 1,
                            Description = "Juicy Beauty was first founded in 2012 in Syria, Damascus. Juicy Beauty was first introduced in Lebanon in 2018.Juicy Beauty is an example of innovation in form due to its display with the largest makeup color made of vibrant and pure pigments and in substancethanks to the exclusive formulas and the revolutionary texture of its makeup products.Behind each product is the excellent research of an expert scientific team that develops new technologies and original formulas.High quality and extreme safety in addition to creativity, taste, and a focus on detail.That’s how JUICY ensures the finest standards of excellence through products that are both gentle and highly effective: Makeup formulas are produced in Europe. The range is subjected to accurate and in-depth safety evaluation.Juicy Beauty is the definition of having fun with makeup, trying new things,and feeling free! Not sure where to start? Why not visit our branches that are all over lebanon and test our products!",
                            Name = "JUICY BEAUTY"
                        });
                });

            modelBuilder.Entity("MarfulApi.Model.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelePhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "From Streat",
                            Description = "MakeUp For Weman",
                            Email = "Test@test.com",
                            Name = "JUICY BEAUTY",
                            Phone = "0921423432",
                            TelePhone = "4232543"
                        });
                });

            modelBuilder.Entity("MarfulApi.Model.CompanyContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("ContentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ContentId");

                    b.ToTable("CompanyContents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyId = 1,
                            ContentId = 1
                        });
                });

            modelBuilder.Entity("MarfulApi.Model.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Just for Weman",
                            Name = "MackeUp"
                        });
                });

            modelBuilder.Entity("MarfulApi.Model.Conversation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("InfulonserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("InfulonserId");

                    b.ToTable("Conversations");
                });

            modelBuilder.Entity("MarfulApi.Model.Infulonser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Paypal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Infulonsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "USA LA",
                            Description = "fdsfsgfd",
                            Email = "test@test.com",
                            Name = "NoorStars",
                            Password = "0000",
                            Paypal = "dskjfhjh",
                            Phone = "0965465760",
                            UserName = "NoorStars"
                        });
                });

            modelBuilder.Entity("MarfulApi.Model.InfulonserContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ContentId")
                        .HasColumnType("int");

                    b.Property<int>("InfulonserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContentId");

                    b.HasIndex("InfulonserId");

                    b.ToTable("InfulonserContents");
                });

            modelBuilder.Entity("MarfulApi.Model.InfulonserUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("InfulonserId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InfulonserId");

                    b.HasIndex("UserId");

                    b.ToTable("InfulonserUsers");
                });

            modelBuilder.Entity("MarfulApi.Model.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InfulonserId")
                        .HasColumnType("int");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("InfulonserId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("MarfulApi.Model.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ConversationId")
                        .HasColumnType("int");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SendTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ConversationId");

                    b.HasIndex("JobId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("MarfulApi.Model.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("InfulonserId")
                        .HasColumnType("int");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("InfulonserId");

                    b.HasIndex("JobId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("MarfulApi.Model.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            BrandId = 1,
                            Code = "32434",
                            Description = "This some Text about found",
                            Name = "Foundation",
                            Price = 350.0
                        },
                        new
                        {
                            Id = 4,
                            BrandId = 1,
                            Code = "32434",
                            Description = "This some Text about found",
                            Name = "CareKream",
                            Price = 290.0
                        },
                        new
                        {
                            Id = 5,
                            BrandId = 1,
                            Code = "32434",
                            Description = "This some Text about found",
                            Name = "CareSun",
                            Price = 400.0
                        },
                        new
                        {
                            Id = 6,
                            BrandId = 1,
                            Code = "32434",
                            Description = "This some Text about found",
                            Name = "Plasher",
                            Price = 600.0
                        },
                        new
                        {
                            Id = 7,
                            BrandId = 1,
                            Code = "32434",
                            Description = "This some Text about found",
                            Name = "Oclador",
                            Price = 178.0
                        },
                        new
                        {
                            Id = 8,
                            BrandId = 1,
                            Code = "32434",
                            Description = "This some Text about found",
                            Name = "Mascara",
                            Price = 1300.0
                        },
                        new
                        {
                            Id = 9,
                            BrandId = 1,
                            Code = "32434",
                            Description = "This some Text about found",
                            Name = "Tant",
                            Price = 700.0
                        });
                });

            modelBuilder.Entity("MarfulApi.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Paypal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 20,
                            Email = "test@test.com",
                            Name = "Noor",
                            Password = "0000",
                            Paypal = "Lb1267",
                            Phone = "0964654765",
                            UserName = "NonoSy"
                        },
                        new
                        {
                            Id = 2,
                            Age = 20,
                            Email = "test@test.com",
                            Name = "Ahamad",
                            Password = "0000",
                            Paypal = "Lb1267",
                            Phone = "0964654765",
                            UserName = "hamodaSy"
                        },
                        new
                        {
                            Id = 3,
                            Age = 20,
                            Email = "test@test.com",
                            Name = "Tala",
                            Password = "0000",
                            Paypal = "Lb1267",
                            Phone = "0964654765",
                            UserName = "totoSy"
                        });
                });

            modelBuilder.Entity("MarfulApi.Model.UserCompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("UserId");

                    b.ToTable("UserCompanies");
                });

            modelBuilder.Entity("MarfulApi.Model.UserPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("InterAction")
                        .HasColumnType("bit");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("UserPosts");
                });

            modelBuilder.Entity("MarfulApi.Model.Basket", b =>
                {
                    b.HasOne("MarfulApi.Model.Product", "Product")
                        .WithMany("Baskets")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MarfulApi.Model.UserPost", "UserPost")
                        .WithMany("Basket")
                        .HasForeignKey("UserPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("UserPost");
                });

            modelBuilder.Entity("MarfulApi.Model.Brand", b =>
                {
                    b.HasOne("MarfulApi.Model.CompanyContent", "CompanyContent")
                        .WithMany("Brand")
                        .HasForeignKey("CompanyContentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MarfulApi.Model.Infulonser", "Infulonser")
                        .WithMany("Brand")
                        .HasForeignKey("InfulonserId");

                    b.Navigation("CompanyContent");

                    b.Navigation("Infulonser");
                });

            modelBuilder.Entity("MarfulApi.Model.CompanyContent", b =>
                {
                    b.HasOne("MarfulApi.Model.Company", "Company")
                        .WithMany("CompanyContent")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MarfulApi.Model.Content", "Content")
                        .WithMany("CompanyContent")
                        .HasForeignKey("ContentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Content");
                });

            modelBuilder.Entity("MarfulApi.Model.Conversation", b =>
                {
                    b.HasOne("MarfulApi.Model.Company", "Company")
                        .WithMany("conversation")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MarfulApi.Model.Infulonser", "Infulonser")
                        .WithMany("Conversation")
                        .HasForeignKey("InfulonserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Infulonser");
                });

            modelBuilder.Entity("MarfulApi.Model.InfulonserContent", b =>
                {
                    b.HasOne("MarfulApi.Model.Content", "Content")
                        .WithMany("InfulonserContent")
                        .HasForeignKey("ContentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MarfulApi.Model.Infulonser", "Infulonser")
                        .WithMany("infulonserContent")
                        .HasForeignKey("InfulonserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Content");

                    b.Navigation("Infulonser");
                });

            modelBuilder.Entity("MarfulApi.Model.InfulonserUser", b =>
                {
                    b.HasOne("MarfulApi.Model.Infulonser", "Infulonser")
                        .WithMany("infulonserUser")
                        .HasForeignKey("InfulonserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MarfulApi.Model.User", "User")
                        .WithMany("infulonserUser")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Infulonser");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MarfulApi.Model.Job", b =>
                {
                    b.HasOne("MarfulApi.Model.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MarfulApi.Model.Infulonser", "Infulonser")
                        .WithMany("Jobs")
                        .HasForeignKey("InfulonserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Infulonser");
                });

            modelBuilder.Entity("MarfulApi.Model.Message", b =>
                {
                    b.HasOne("MarfulApi.Model.Conversation", "Conversation")
                        .WithMany("Message")
                        .HasForeignKey("ConversationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MarfulApi.Model.Job", "Job")
                        .WithMany("Messages")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Conversation");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("MarfulApi.Model.Post", b =>
                {
                    b.HasOne("MarfulApi.Model.Brand", "Brand")
                        .WithMany("Post")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MarfulApi.Model.Infulonser", "Infulonser")
                        .WithMany("Posts")
                        .HasForeignKey("InfulonserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MarfulApi.Model.Job", "Job")
                        .WithMany("Post")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Infulonser");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("MarfulApi.Model.Product", b =>
                {
                    b.HasOne("MarfulApi.Model.Brand", "Brand")
                        .WithMany("Product")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("MarfulApi.Model.UserCompany", b =>
                {
                    b.HasOne("MarfulApi.Model.Company", "Company")
                        .WithMany("UserCompanie")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MarfulApi.Model.User", "User")
                        .WithMany("UserCompany")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MarfulApi.Model.UserPost", b =>
                {
                    b.HasOne("MarfulApi.Model.Post", "Post")
                        .WithMany("UserPost")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MarfulApi.Model.User", "User")
                        .WithMany("UserPost")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MarfulApi.Model.Brand", b =>
                {
                    b.Navigation("Post");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("MarfulApi.Model.Company", b =>
                {
                    b.Navigation("CompanyContent");

                    b.Navigation("UserCompanie");

                    b.Navigation("conversation");
                });

            modelBuilder.Entity("MarfulApi.Model.CompanyContent", b =>
                {
                    b.Navigation("Brand");
                });

            modelBuilder.Entity("MarfulApi.Model.Content", b =>
                {
                    b.Navigation("CompanyContent");

                    b.Navigation("InfulonserContent");
                });

            modelBuilder.Entity("MarfulApi.Model.Conversation", b =>
                {
                    b.Navigation("Message");
                });

            modelBuilder.Entity("MarfulApi.Model.Infulonser", b =>
                {
                    b.Navigation("Brand");

                    b.Navigation("Conversation");

                    b.Navigation("Jobs");

                    b.Navigation("Posts");

                    b.Navigation("infulonserContent");

                    b.Navigation("infulonserUser");
                });

            modelBuilder.Entity("MarfulApi.Model.Job", b =>
                {
                    b.Navigation("Messages");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("MarfulApi.Model.Post", b =>
                {
                    b.Navigation("UserPost");
                });

            modelBuilder.Entity("MarfulApi.Model.Product", b =>
                {
                    b.Navigation("Baskets");
                });

            modelBuilder.Entity("MarfulApi.Model.User", b =>
                {
                    b.Navigation("UserCompany");

                    b.Navigation("UserPost");

                    b.Navigation("infulonserUser");
                });

            modelBuilder.Entity("MarfulApi.Model.UserPost", b =>
                {
                    b.Navigation("Basket");
                });
#pragma warning restore 612, 618
        }
    }
}
