﻿// <auto-generated />
using System;
using EF_2504.DAL.Concrete.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EF_2504.DAL.Migrations
{
    [DbContext(typeof(BookAppDbContext))]
    [Migration("20220426143720_mig3")]
    partial class mig3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EF_2504.DAL.Entities.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AuthorCreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 4, 26, 17, 37, 19, 95, DateTimeKind.Local).AddTicks(8113));

                    b.Property<string>("AuthorFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            AuthorCreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            AuthorFirstName = "Ferzan",
                            AuthorLastName = "Özpetek"
                        },
                        new
                        {
                            AuthorId = 2,
                            AuthorCreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            AuthorFirstName = "Serdar",
                            AuthorLastName = "Candaş"
                        },
                        new
                        {
                            AuthorId = 3,
                            AuthorCreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            AuthorFirstName = "Kübra",
                            AuthorLastName = "Sesiçok"
                        });
                });

            modelBuilder.Entity("EF_2504.DAL.Entities.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BookCreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 4, 26, 17, 37, 19, 162, DateTimeKind.Local).AddTicks(685));

                    b.Property<string>("BookImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("BookPrice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.HasKey("BookId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            BookCreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BookImageUrl = "http://kbimages1-a.akamaihd.net/Images/6faa402f-1a95-4897-93ff-8286cbe0e94f/255/400/False/image.jpg",
                            BookName = "Sefiller",
                            BookPrice = 120m
                        },
                        new
                        {
                            BookId = 2,
                            BookCreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BookImageUrl = "https://i.dr.com.tr/cache/600x600-0/originals/0000000186269-1.jpg",
                            BookName = "Kaşağı",
                            BookPrice = 90m
                        },
                        new
                        {
                            BookId = 3,
                            BookCreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BookImageUrl = "https://www.tdk.com.tr/images_buyuk/f14/A-dan-Z-ye-PHP_8614_1.jpg",
                            BookName = "A'dan Z'ye PHP",
                            BookPrice = 190m
                        });
                });

            modelBuilder.Entity("EF_2504.DAL.Entities.BookDetail", b =>
                {
                    b.Property<int>("BookDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BookDetailCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookDetailCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookDetailIsbn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("0000-0000-0000");

                    b.Property<int>("BookDetailYear")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(2022);

                    b.HasKey("BookDetailId");

                    b.ToTable("BookDetails");

                    b.HasData(
                        new
                        {
                            BookDetailId = 1,
                            BookDetailCity = "İstanbul",
                            BookDetailYear = 0
                        },
                        new
                        {
                            BookDetailId = 2,
                            BookDetailCity = "Ankara",
                            BookDetailYear = 0
                        },
                        new
                        {
                            BookDetailId = 3,
                            BookDetailCity = "İzmir",
                            BookDetailYear = 0
                        });
                });

            modelBuilder.Entity("EF_2504.DAL.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryDescription = "Roman türü kitaplar",
                            CategoryName = "Roman"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryDescription = "Yönetim türü kitaplar",
                            CategoryName = "Yönetim"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryDescription = "Bilişim türü kitaplar",
                            CategoryName = "Bilişim"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
