using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI_01.Migrations
{
    public partial class RefactorDBContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthors_Authors_AuthorId",
                table: "BookAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthors_Books_BookId",
                table: "BookAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publishers_PubId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_RefreshTokens_Users_UserId",
                table: "RefreshTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Books_BookId",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Stores_StoreId",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Publishers_PubId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stores",
                table: "Stores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sales",
                table: "Sales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RefreshTokens",
                table: "RefreshTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Publishers",
                table: "Publishers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Jobs",
                table: "Jobs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookAuthors",
                table: "BookAuthors");

            migrationBuilder.DropIndex(
                name: "IX_BookAuthors_AuthorId",
                table: "BookAuthors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "BookAuthorId",
                table: "BookAuthors");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Stores",
                newName: "Store");

            migrationBuilder.RenameTable(
                name: "Sales",
                newName: "Sale");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "Role");

            migrationBuilder.RenameTable(
                name: "RefreshTokens",
                newName: "RefreshToken");

            migrationBuilder.RenameTable(
                name: "Publishers",
                newName: "Publisher");

            migrationBuilder.RenameTable(
                name: "Jobs",
                newName: "Job");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "Book");

            migrationBuilder.RenameTable(
                name: "BookAuthors",
                newName: "BookAuthor");

            migrationBuilder.RenameTable(
                name: "Authors",
                newName: "Author");

            migrationBuilder.RenameColumn(
                name: "Source",
                table: "User",
                newName: "source");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "User",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "User",
                newName: "role_id");

            migrationBuilder.RenameColumn(
                name: "PubId",
                table: "User",
                newName: "pub_id");

            migrationBuilder.RenameColumn(
                name: "MiddleName",
                table: "User",
                newName: "middle_name");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "User",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "HireDate",
                table: "User",
                newName: "hire_date");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "User",
                newName: "first_name");

            migrationBuilder.RenameColumn(
                name: "EmailAddress",
                table: "User",
                newName: "email_address");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "User",
                newName: "user_id");

            migrationBuilder.RenameIndex(
                name: "IX_Users_RoleId",
                table: "User",
                newName: "IX_User_role_id");

            migrationBuilder.RenameIndex(
                name: "IX_Users_PubId",
                table: "User",
                newName: "IX_User_pub_id");

            migrationBuilder.RenameColumn(
                name: "Zip",
                table: "Store",
                newName: "zip");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Store",
                newName: "state");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Store",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "StoreName",
                table: "Store",
                newName: "store_name");

            migrationBuilder.RenameColumn(
                name: "StoreAddress",
                table: "Store",
                newName: "store_address");

            migrationBuilder.RenameColumn(
                name: "StoreId",
                table: "Store",
                newName: "store_id");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Sale",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "StoreId",
                table: "Sale",
                newName: "store_id");

            migrationBuilder.RenameColumn(
                name: "PayTerms",
                table: "Sale",
                newName: "pay_terms");

            migrationBuilder.RenameColumn(
                name: "OrderNum",
                table: "Sale",
                newName: "order_num");

            migrationBuilder.RenameColumn(
                name: "OrderDate",
                table: "Sale",
                newName: "order_date");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "Sale",
                newName: "book_id");

            migrationBuilder.RenameColumn(
                name: "SaleId",
                table: "Sale",
                newName: "sale_id");

            migrationBuilder.RenameIndex(
                name: "IX_Sales_StoreId",
                table: "Sale",
                newName: "IX_Sale_store_id");

            migrationBuilder.RenameIndex(
                name: "IX_Sales_BookId",
                table: "Sale",
                newName: "IX_Sale_book_id");

            migrationBuilder.RenameColumn(
                name: "RoleDesc",
                table: "Role",
                newName: "role_desc");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "Role",
                newName: "role_id");

            migrationBuilder.RenameColumn(
                name: "Token",
                table: "RefreshToken",
                newName: "token");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "RefreshToken",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "ExpiryDate",
                table: "RefreshToken",
                newName: "expiry_date");

            migrationBuilder.RenameColumn(
                name: "RefreshTokenId",
                table: "RefreshToken",
                newName: "token_id");

            migrationBuilder.RenameIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshToken",
                newName: "IX_RefreshToken_user_id");

            migrationBuilder.RenameColumn(
                name: "PublisherName",
                table: "Publisher",
                newName: "publisher_name");

            migrationBuilder.RenameColumn(
                name: "PublisherId",
                table: "Publisher",
                newName: "pub_id");

            migrationBuilder.RenameColumn(
                name: "JobDesc",
                table: "Job",
                newName: "job_desc");

            migrationBuilder.RenameColumn(
                name: "JobId",
                table: "Job",
                newName: "job_id");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Book",
                newName: "type");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Book",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Royalty",
                table: "Book",
                newName: "royalty");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Book",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Notes",
                table: "Book",
                newName: "notes");

            migrationBuilder.RenameColumn(
                name: "Advance",
                table: "Book",
                newName: "advance");

            migrationBuilder.RenameColumn(
                name: "YtdSales",
                table: "Book",
                newName: "ytd_sales");

            migrationBuilder.RenameColumn(
                name: "PublishedDate",
                table: "Book",
                newName: "published_date");

            migrationBuilder.RenameColumn(
                name: "PubId",
                table: "Book",
                newName: "pub_id");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "Book",
                newName: "book_id");

            migrationBuilder.RenameIndex(
                name: "IX_Books_PubId",
                table: "Book",
                newName: "IX_Book_pub_id");

            migrationBuilder.RenameColumn(
                name: "RoyalityPercentage",
                table: "BookAuthor",
                newName: "royality_percentage");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "BookAuthor",
                newName: "book_id");

            migrationBuilder.RenameColumn(
                name: "AuthorOrder",
                table: "BookAuthor",
                newName: "author_order");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "BookAuthor",
                newName: "author_id");

            migrationBuilder.RenameIndex(
                name: "IX_BookAuthors_BookId",
                table: "BookAuthor",
                newName: "IX_BookAuthor_book_id");

            migrationBuilder.RenameColumn(
                name: "Zip",
                table: "Author",
                newName: "zip");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Author",
                newName: "state");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Author",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Author",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Author",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Author",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Author",
                newName: "first_name");

            migrationBuilder.RenameColumn(
                name: "EmailAddress",
                table: "Author",
                newName: "email_address");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "Author",
                newName: "author_id");

            migrationBuilder.AlterColumn<string>(
                name: "source",
                table: "User",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "User",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "role_id",
                table: "User",
                type: "smallint",
                nullable: false,
                defaultValueSql: "((1))",
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<int>(
                name: "pub_id",
                table: "User",
                type: "int",
                nullable: false,
                defaultValueSql: "((1))",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "middle_name",
                table: "User",
                type: "char(1)",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "last_name",
                table: "User",
                type: "varchar(30)",
                unicode: false,
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "hire_date",
                table: "User",
                type: "datetime",
                nullable: true,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "first_name",
                table: "User",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "email_address",
                table: "User",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "zip",
                table: "Store",
                type: "char(5)",
                unicode: false,
                fixedLength: true,
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "state",
                table: "Store",
                type: "char(2)",
                unicode: false,
                fixedLength: true,
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "city",
                table: "Store",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "store_name",
                table: "Store",
                type: "varchar(40)",
                unicode: false,
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "store_address",
                table: "Store",
                type: "varchar(40)",
                unicode: false,
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "store_id",
                table: "Store",
                type: "char(4)",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "store_id",
                table: "Sale",
                type: "char(4)",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "pay_terms",
                table: "Sale",
                type: "varchar(12)",
                unicode: false,
                maxLength: 12,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "order_num",
                table: "Sale",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "order_date",
                table: "Sale",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "role_desc",
                table: "Role",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValueSql: "('New Position - title not formalized yet')",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "token",
                table: "RefreshToken",
                type: "varchar(200)",
                unicode: false,
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "expiry_date",
                table: "RefreshToken",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "publisher_name",
                table: "Publisher",
                type: "varchar(40)",
                unicode: false,
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "Publisher",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "country",
                table: "Publisher",
                type: "varchar(30)",
                unicode: false,
                maxLength: 30,
                nullable: true,
                defaultValueSql: "('USA')");

            migrationBuilder.AddColumn<string>(
                name: "state",
                table: "Publisher",
                type: "char(2)",
                unicode: false,
                fixedLength: true,
                maxLength: 2,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "job_desc",
                table: "Job",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValueSql: "('New Position - title not formalized yet')",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "type",
                table: "Book",
                type: "char(12)",
                unicode: false,
                fixedLength: true,
                maxLength: 12,
                nullable: false,
                defaultValueSql: "('UNDECIDED')",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "title",
                table: "Book",
                type: "varchar(80)",
                unicode: false,
                maxLength: 80,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "price",
                table: "Book",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "notes",
                table: "Book",
                type: "varchar(200)",
                unicode: false,
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "advance",
                table: "Book",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "published_date",
                table: "Book",
                type: "datetime",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "author_id",
                table: "BookAuthor",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "zip",
                table: "Author",
                type: "char(5)",
                unicode: false,
                fixedLength: true,
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "state",
                table: "Author",
                type: "char(2)",
                unicode: false,
                fixedLength: true,
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "phone",
                table: "Author",
                type: "char(12)",
                unicode: false,
                fixedLength: true,
                maxLength: 12,
                nullable: false,
                defaultValueSql: "('UNKNOWN')",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "city",
                table: "Author",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "address",
                table: "Author",
                type: "varchar(40)",
                unicode: false,
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "last_name",
                table: "Author",
                type: "varchar(40)",
                unicode: false,
                maxLength: 40,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "first_name",
                table: "Author",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "email_address",
                table: "Author",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_id_2",
                table: "User",
                column: "user_id")
                .Annotation("SqlServer:Clustered", false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Store",
                table: "Store",
                column: "store_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sale",
                table: "Sale",
                column: "sale_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Role",
                table: "Role",
                column: "role_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RefreshToken",
                table: "RefreshToken",
                column: "token_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Publishe__2515F222DDC013AD",
                table: "Publisher",
                column: "pub_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Job",
                table: "Job",
                column: "job_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book",
                table: "Book",
                column: "book_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookAuthor",
                table: "BookAuthor",
                columns: new[] { "author_id", "book_id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Author",
                table: "Author",
                column: "author_id");

            migrationBuilder.AddForeignKey(
                name: "FK__Book__pub_id__6166761E",
                table: "Book",
                column: "pub_id",
                principalTable: "Publisher",
                principalColumn: "pub_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__BookAutho__autho__43D61337",
                table: "BookAuthor",
                column: "author_id",
                principalTable: "Author",
                principalColumn: "author_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__BookAutho__book___42E1EEFE",
                table: "BookAuthor",
                column: "book_id",
                principalTable: "Book",
                principalColumn: "book_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__RefreshTo__user___60FC61CA",
                table: "RefreshToken",
                column: "user_id",
                principalTable: "User",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__Sale2__book_id__756D6ECB",
                table: "Sale",
                column: "book_id",
                principalTable: "Book",
                principalColumn: "book_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__Sale2__store_id__76619304",
                table: "Sale",
                column: "store_id",
                principalTable: "Store",
                principalColumn: "store_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__User__role_id__6E565CE8",
                table: "User",
                column: "role_id",
                principalTable: "Role",
                principalColumn: "role_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__User2__pub_id__60083D91",
                table: "User",
                column: "pub_id",
                principalTable: "Publisher",
                principalColumn: "pub_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Book__pub_id__6166761E",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK__BookAutho__autho__43D61337",
                table: "BookAuthor");

            migrationBuilder.DropForeignKey(
                name: "FK__BookAutho__book___42E1EEFE",
                table: "BookAuthor");

            migrationBuilder.DropForeignKey(
                name: "FK__RefreshTo__user___60FC61CA",
                table: "RefreshToken");

            migrationBuilder.DropForeignKey(
                name: "FK__Sale2__book_id__756D6ECB",
                table: "Sale");

            migrationBuilder.DropForeignKey(
                name: "FK__Sale2__store_id__76619304",
                table: "Sale");

            migrationBuilder.DropForeignKey(
                name: "FK__User__role_id__6E565CE8",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK__User2__pub_id__60083D91",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_id_2",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Store",
                table: "Store");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sale",
                table: "Sale");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Role",
                table: "Role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RefreshToken",
                table: "RefreshToken");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Publishe__2515F222DDC013AD",
                table: "Publisher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Job",
                table: "Job");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookAuthor",
                table: "BookAuthor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Book",
                table: "Book");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Author",
                table: "Author");

            migrationBuilder.DropColumn(
                name: "city",
                table: "Publisher");

            migrationBuilder.DropColumn(
                name: "country",
                table: "Publisher");

            migrationBuilder.DropColumn(
                name: "state",
                table: "Publisher");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Store",
                newName: "Stores");

            migrationBuilder.RenameTable(
                name: "Sale",
                newName: "Sales");

            migrationBuilder.RenameTable(
                name: "Role",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "RefreshToken",
                newName: "RefreshTokens");

            migrationBuilder.RenameTable(
                name: "Publisher",
                newName: "Publishers");

            migrationBuilder.RenameTable(
                name: "Job",
                newName: "Jobs");

            migrationBuilder.RenameTable(
                name: "BookAuthor",
                newName: "BookAuthors");

            migrationBuilder.RenameTable(
                name: "Book",
                newName: "Books");

            migrationBuilder.RenameTable(
                name: "Author",
                newName: "Authors");

            migrationBuilder.RenameColumn(
                name: "source",
                table: "Users",
                newName: "Source");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "role_id",
                table: "Users",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "pub_id",
                table: "Users",
                newName: "PubId");

            migrationBuilder.RenameColumn(
                name: "middle_name",
                table: "Users",
                newName: "MiddleName");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "Users",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "hire_date",
                table: "Users",
                newName: "HireDate");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "Users",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "email_address",
                table: "Users",
                newName: "EmailAddress");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_User_role_id",
                table: "Users",
                newName: "IX_Users_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_User_pub_id",
                table: "Users",
                newName: "IX_Users_PubId");

            migrationBuilder.RenameColumn(
                name: "zip",
                table: "Stores",
                newName: "Zip");

            migrationBuilder.RenameColumn(
                name: "state",
                table: "Stores",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "Stores",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "store_name",
                table: "Stores",
                newName: "StoreName");

            migrationBuilder.RenameColumn(
                name: "store_address",
                table: "Stores",
                newName: "StoreAddress");

            migrationBuilder.RenameColumn(
                name: "store_id",
                table: "Stores",
                newName: "StoreId");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "Sales",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "store_id",
                table: "Sales",
                newName: "StoreId");

            migrationBuilder.RenameColumn(
                name: "pay_terms",
                table: "Sales",
                newName: "PayTerms");

            migrationBuilder.RenameColumn(
                name: "order_num",
                table: "Sales",
                newName: "OrderNum");

            migrationBuilder.RenameColumn(
                name: "order_date",
                table: "Sales",
                newName: "OrderDate");

            migrationBuilder.RenameColumn(
                name: "book_id",
                table: "Sales",
                newName: "BookId");

            migrationBuilder.RenameColumn(
                name: "sale_id",
                table: "Sales",
                newName: "SaleId");

            migrationBuilder.RenameIndex(
                name: "IX_Sale_store_id",
                table: "Sales",
                newName: "IX_Sales_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_Sale_book_id",
                table: "Sales",
                newName: "IX_Sales_BookId");

            migrationBuilder.RenameColumn(
                name: "role_desc",
                table: "Roles",
                newName: "RoleDesc");

            migrationBuilder.RenameColumn(
                name: "role_id",
                table: "Roles",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "token",
                table: "RefreshTokens",
                newName: "Token");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "RefreshTokens",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "expiry_date",
                table: "RefreshTokens",
                newName: "ExpiryDate");

            migrationBuilder.RenameColumn(
                name: "token_id",
                table: "RefreshTokens",
                newName: "RefreshTokenId");

            migrationBuilder.RenameIndex(
                name: "IX_RefreshToken_user_id",
                table: "RefreshTokens",
                newName: "IX_RefreshTokens_UserId");

            migrationBuilder.RenameColumn(
                name: "publisher_name",
                table: "Publishers",
                newName: "PublisherName");

            migrationBuilder.RenameColumn(
                name: "pub_id",
                table: "Publishers",
                newName: "PublisherId");

            migrationBuilder.RenameColumn(
                name: "job_desc",
                table: "Jobs",
                newName: "JobDesc");

            migrationBuilder.RenameColumn(
                name: "job_id",
                table: "Jobs",
                newName: "JobId");

            migrationBuilder.RenameColumn(
                name: "royality_percentage",
                table: "BookAuthors",
                newName: "RoyalityPercentage");

            migrationBuilder.RenameColumn(
                name: "author_order",
                table: "BookAuthors",
                newName: "AuthorOrder");

            migrationBuilder.RenameColumn(
                name: "book_id",
                table: "BookAuthors",
                newName: "BookId");

            migrationBuilder.RenameColumn(
                name: "author_id",
                table: "BookAuthors",
                newName: "AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_BookAuthor_book_id",
                table: "BookAuthors",
                newName: "IX_BookAuthors_BookId");

            migrationBuilder.RenameColumn(
                name: "type",
                table: "Books",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Books",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "royalty",
                table: "Books",
                newName: "Royalty");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Books",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "notes",
                table: "Books",
                newName: "Notes");

            migrationBuilder.RenameColumn(
                name: "advance",
                table: "Books",
                newName: "Advance");

            migrationBuilder.RenameColumn(
                name: "ytd_sales",
                table: "Books",
                newName: "YtdSales");

            migrationBuilder.RenameColumn(
                name: "published_date",
                table: "Books",
                newName: "PublishedDate");

            migrationBuilder.RenameColumn(
                name: "pub_id",
                table: "Books",
                newName: "PubId");

            migrationBuilder.RenameColumn(
                name: "book_id",
                table: "Books",
                newName: "BookId");

            migrationBuilder.RenameIndex(
                name: "IX_Book_pub_id",
                table: "Books",
                newName: "IX_Books_PubId");

            migrationBuilder.RenameColumn(
                name: "zip",
                table: "Authors",
                newName: "Zip");

            migrationBuilder.RenameColumn(
                name: "state",
                table: "Authors",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Authors",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "Authors",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "Authors",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "Authors",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "Authors",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "email_address",
                table: "Authors",
                newName: "EmailAddress");

            migrationBuilder.RenameColumn(
                name: "author_id",
                table: "Authors",
                newName: "AuthorId");

            migrationBuilder.AlterColumn<string>(
                name: "Source",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<short>(
                name: "RoleId",
                table: "Users",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint",
                oldDefaultValueSql: "((1))");

            migrationBuilder.AlterColumn<int>(
                name: "PubId",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "((1))");

            migrationBuilder.AlterColumn<string>(
                name: "MiddleName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(1)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldUnicode: false,
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "HireDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Zip",
                table: "Stores",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(5)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 5,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Stores",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(2)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Stores",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StoreName",
                table: "Stores",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(40)",
                oldUnicode: false,
                oldMaxLength: 40,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StoreAddress",
                table: "Stores",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(40)",
                oldUnicode: false,
                oldMaxLength: 40,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StoreId",
                table: "Stores",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(4)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "StoreId",
                table: "Sales",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(4)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "PayTerms",
                table: "Sales",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(12)",
                oldUnicode: false,
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<string>(
                name: "OrderNum",
                table: "Sales",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Sales",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<string>(
                name: "RoleDesc",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldDefaultValueSql: "('New Position - title not formalized yet')");

            migrationBuilder.AlterColumn<string>(
                name: "Token",
                table: "RefreshTokens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldUnicode: false,
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpiryDate",
                table: "RefreshTokens",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<string>(
                name: "PublisherName",
                table: "Publishers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(40)",
                oldUnicode: false,
                oldMaxLength: 40,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "JobDesc",
                table: "Jobs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldDefaultValueSql: "('New Position - title not formalized yet')");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "BookAuthors",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "BookAuthorId",
                table: "BookAuthors",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(12)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 12,
                oldDefaultValueSql: "('UNDECIDED')");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(80)",
                oldUnicode: false,
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Books",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldUnicode: false,
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Advance",
                table: "Books",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishedDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<string>(
                name: "Zip",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(5)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 5,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(2)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(12)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 12,
                oldDefaultValueSql: "('UNKNOWN')");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(40)",
                oldUnicode: false,
                oldMaxLength: 40,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(40)",
                oldUnicode: false,
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stores",
                table: "Stores",
                column: "StoreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sales",
                table: "Sales",
                column: "SaleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RefreshTokens",
                table: "RefreshTokens",
                column: "RefreshTokenId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Publishers",
                table: "Publishers",
                column: "PublisherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Jobs",
                table: "Jobs",
                column: "JobId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookAuthors",
                table: "BookAuthors",
                column: "BookAuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthors_AuthorId",
                table: "BookAuthors",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthors_Authors_AuthorId",
                table: "BookAuthors",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthors_Books_BookId",
                table: "BookAuthors",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publishers_PubId",
                table: "Books",
                column: "PubId",
                principalTable: "Publishers",
                principalColumn: "PublisherId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RefreshTokens_Users_UserId",
                table: "RefreshTokens",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Books_BookId",
                table: "Sales",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Stores_StoreId",
                table: "Sales",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Publishers_PubId",
                table: "Users",
                column: "PubId",
                principalTable: "Publishers",
                principalColumn: "PublisherId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
