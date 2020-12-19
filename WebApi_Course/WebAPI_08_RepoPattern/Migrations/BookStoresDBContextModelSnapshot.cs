﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI_08_RepoPattern.Models;

namespace WebAPI_08_RepoPattern.Migrations
{
    [DbContext(typeof(BookStoresDBContext))]
    partial class BookStoresDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("WebAPI_05_DB_First.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("author_id")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("address");

                    b.Property<string>("City")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("city");

                    b.Property<string>("EmailAddress")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email_address");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("last_name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("char(12)")
                        .HasColumnName("phone")
                        .HasDefaultValueSql("('UNKNOWN')")
                        .IsFixedLength(true);

                    b.Property<string>("State")
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("char(2)")
                        .HasColumnName("state")
                        .IsFixedLength(true);

                    b.Property<string>("Zip")
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("char(5)")
                        .HasColumnName("zip")
                        .IsFixedLength(true);

                    b.HasKey("AuthorId");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("WebAPI_05_DB_First.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("book_id")
                        .UseIdentityColumn();

                    b.Property<decimal?>("Advance")
                        .HasColumnType("money")
                        .HasColumnName("advance");

                    b.Property<string>("Notes")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("notes");

                    b.Property<decimal?>("Price")
                        .HasColumnType("money")
                        .HasColumnName("price");

                    b.Property<int>("PubId")
                        .HasColumnType("int")
                        .HasColumnName("pub_id");

                    b.Property<DateTime>("PublishedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("published_date")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int?>("Royalty")
                        .HasColumnType("int")
                        .HasColumnName("royalty");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnType("varchar(80)")
                        .HasColumnName("title");

                    b.Property<string>("Type")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("char(12)")
                        .HasColumnName("type")
                        .HasDefaultValueSql("('UNDECIDED')")
                        .IsFixedLength(true);

                    b.Property<int?>("YtdSales")
                        .HasColumnType("int")
                        .HasColumnName("ytd_sales");

                    b.HasKey("BookId");

                    b.HasIndex("PubId");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("WebAPI_05_DB_First.Models.BookAuthor", b =>
                {
                    b.Property<int>("AuthorId")
                        .HasColumnType("int")
                        .HasColumnName("author_id");

                    b.Property<int>("BookId")
                        .HasColumnType("int")
                        .HasColumnName("book_id");

                    b.Property<byte?>("AuthorOrder")
                        .HasColumnType("tinyint")
                        .HasColumnName("author_order");

                    b.Property<int?>("RoyalityPercentage")
                        .HasColumnType("int")
                        .HasColumnName("royality_percentage");

                    b.HasKey("AuthorId", "BookId");

                    b.HasIndex("BookId");

                    b.ToTable("BookAuthor");
                });

            modelBuilder.Entity("WebAPI_05_DB_First.Models.Job", b =>
                {
                    b.Property<short>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasColumnName("job_id")
                        .UseIdentityColumn();

                    b.Property<string>("JobDesc")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("job_desc")
                        .HasDefaultValueSql("('New Position - title not formalized yet')");

                    b.HasKey("JobId");

                    b.ToTable("Job");
                });

            modelBuilder.Entity("WebAPI_05_DB_First.Models.Publisher", b =>
                {
                    b.Property<int>("PubId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("pub_id")
                        .UseIdentityColumn();

                    b.Property<string>("City")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("city");

                    b.Property<string>("Country")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("country")
                        .HasDefaultValueSql("('USA')");

                    b.Property<string>("PublisherName")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("publisher_name");

                    b.Property<string>("State")
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("char(2)")
                        .HasColumnName("state")
                        .IsFixedLength(true);

                    b.HasKey("PubId")
                        .HasName("PK__Publishe__2515F222DDC013AD");

                    b.ToTable("Publisher");
                });

            modelBuilder.Entity("WebAPI_05_DB_First.Models.RefreshToken", b =>
                {
                    b.Property<int>("TokenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("token_id")
                        .UseIdentityColumn();

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime")
                        .HasColumnName("expiry_date");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("token");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("TokenId");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshToken");
                });

            modelBuilder.Entity("WebAPI_05_DB_First.Models.Role", b =>
                {
                    b.Property<short>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .UseIdentityColumn();

                    b.Property<string>("RoleDesc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("WebAPI_05_DB_First.Models.Sale", b =>
                {
                    b.Property<int>("SaleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("sale_id")
                        .UseIdentityColumn();

                    b.Property<int>("BookId")
                        .HasColumnType("int")
                        .HasColumnName("book_id");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime")
                        .HasColumnName("order_date");

                    b.Property<string>("OrderNum")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("order_num");

                    b.Property<string>("PayTerms")
                        .IsRequired()
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("varchar(12)")
                        .HasColumnName("pay_terms");

                    b.Property<short>("Quantity")
                        .HasColumnType("smallint")
                        .HasColumnName("quantity");

                    b.Property<string>("StoreId")
                        .IsRequired()
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .HasColumnName("store_id")
                        .IsFixedLength(true);

                    b.HasKey("SaleId");

                    b.HasIndex("BookId");

                    b.HasIndex("StoreId");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("WebAPI_05_DB_First.Models.Store", b =>
                {
                    b.Property<string>("StoreId")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .HasColumnName("store_id")
                        .IsFixedLength(true);

                    b.Property<string>("City")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("city");

                    b.Property<string>("State")
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("char(2)")
                        .HasColumnName("state")
                        .IsFixedLength(true);

                    b.Property<string>("StoreAddress")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("store_address");

                    b.Property<string>("StoreName")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("store_name");

                    b.Property<string>("Zip")
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("char(5)")
                        .HasColumnName("zip")
                        .IsFixedLength(true);

                    b.HasKey("StoreId");

                    b.ToTable("Store");
                });

            modelBuilder.Entity("WebAPI_05_DB_First.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("int")
                        .HasColumnName("user_id")
                        .UseIdentityColumn();

                    b.Property<string>("EmailAddress")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email_address");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("first_name");

                    b.Property<DateTime>("HireDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("hire_date")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<short>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasColumnName("job_id")
                        .HasDefaultValueSql("((1))");

                    b.Property<byte?>("JobLevel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint")
                        .HasColumnName("job_level")
                        .HasDefaultValueSql("((10))");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("last_name");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("middle_name")
                        .IsFixedLength(true);

                    b.Property<string>("Password")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("password");

                    b.Property<int>("PubId")
                        .HasColumnType("int")
                        .HasColumnName("pub_id");

                    b.Property<short?>("RoleId")
                        .HasColumnType("smallint");

                    b.HasKey("UserId")
                        .HasName("PK_user_id")
                        .IsClustered(false);

                    b.HasIndex("JobId");

                    b.HasIndex("PubId");

                    b.HasIndex("RoleId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("WebAPI_05_DB_First.Models.Book", b =>
                {
                    b.HasOne("WebAPI_05_DB_First.Models.Publisher", "Pub")
                        .WithMany("Books")
                        .HasForeignKey("PubId")
                        .HasConstraintName("FK__Book__pub_id__6166761E")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pub");
                });

            modelBuilder.Entity("WebAPI_05_DB_First.Models.BookAuthor", b =>
                {
                    b.HasOne("WebAPI_05_DB_First.Models.Author", "Author")
                        .WithMany("BookAuthors")
                        .HasForeignKey("AuthorId")
                        .HasConstraintName("FK__BookAutho__autho__43D61337")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI_05_DB_First.Models.Book", "Book")
                        .WithMany("BookAuthors")
                        .HasForeignKey("BookId")
                        .HasConstraintName("FK__BookAutho__book___42E1EEFE")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("WebAPI_05_DB_First.Models.RefreshToken", b =>
                {
                    b.HasOne("WebAPI_05_DB_First.Models.User", "User")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__RefreshTo__user___60FC61CA")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebAPI_05_DB_First.Models.Sale", b =>
                {
                    b.HasOne("WebAPI_05_DB_First.Models.Book", "Book")
                        .WithMany("Sales")
                        .HasForeignKey("BookId")
                        .HasConstraintName("FK__Sale2__book_id__756D6ECB")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI_05_DB_First.Models.Store", "Store")
                        .WithMany("Sales")
                        .HasForeignKey("StoreId")
                        .HasConstraintName("FK__Sale2__store_id__76619304")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("WebAPI_05_DB_First.Models.User", b =>
                {
                    b.HasOne("WebAPI_05_DB_First.Models.Job", "Job")
                        .WithMany("Users")
                        .HasForeignKey("JobId")
                        .HasConstraintName("FK__Users__job_id__114A936A")
                        .IsRequired();

                    b.HasOne("WebAPI_05_DB_First.Models.Publisher", "Pub")
                        .WithMany("Users")
                        .HasForeignKey("PubId")
                        .HasConstraintName("FK__Users__pub_id__607251E5")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI_05_DB_First.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");

                    b.Navigation("Job");

                    b.Navigation("Pub");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("WebAPI_05_DB_First.Models.Author", b =>
                {
                    b.Navigation("BookAuthors");
                });

            modelBuilder.Entity("WebAPI_05_DB_First.Models.Book", b =>
                {
                    b.Navigation("BookAuthors");

                    b.Navigation("Sales");
                });

            modelBuilder.Entity("WebAPI_05_DB_First.Models.Job", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("WebAPI_05_DB_First.Models.Publisher", b =>
                {
                    b.Navigation("Books");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("WebAPI_05_DB_First.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("WebAPI_05_DB_First.Models.Store", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("WebAPI_05_DB_First.Models.User", b =>
                {
                    b.Navigation("RefreshTokens");
                });
#pragma warning restore 612, 618
        }
    }
}