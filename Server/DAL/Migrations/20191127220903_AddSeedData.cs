using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("ad65906b-6856-44b4-8400-8880419bcffe"), "Category 1" },
                    { new Guid("0195579a-6c52-4759-9360-49957bad6991"), "Category 2" },
                    { new Guid("5c6be1bc-8975-43a8-862f-4a9292c0392d"), "Category 3" },
                    { new Guid("8f55e482-6f79-4aeb-959b-c4d5d24322b7"), "Category 4" },
                    { new Guid("a60bc115-d71f-4bc7-ac49-91da79dabb09"), "Category 5" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Title" },
                values: new object[,]
                {
                    { new Guid("f785a54a-6125-4ae5-86e1-18019ed6f23f"), new Guid("ad65906b-6856-44b4-8400-8880419bcffe"), "Product 1" },
                    { new Guid("7406fc96-a78f-4194-bf1f-26e1b77cc4b2"), new Guid("ad65906b-6856-44b4-8400-8880419bcffe"), "Product 2" },
                    { new Guid("5ec671a8-24eb-4e5b-aecb-02d05a3c361e"), new Guid("5c6be1bc-8975-43a8-862f-4a9292c0392d"), "Product 3" },
                    { new Guid("03bdf287-90d4-446c-a08f-bfdaf7a3452a"), new Guid("8f55e482-6f79-4aeb-959b-c4d5d24322b7"), "Product 4" },
                    { new Guid("dd879da5-bf98-4d60-9885-0e258316fa6c"), new Guid("8f55e482-6f79-4aeb-959b-c4d5d24322b7"), "Product 5" },
                    { new Guid("2cf0047b-3cbe-4cc6-aa8b-d692b13c121f"), new Guid("8f55e482-6f79-4aeb-959b-c4d5d24322b7"), "Product 6" },
                    { new Guid("00fa52ea-c324-44ee-a0b7-765f75e674d6"), new Guid("a60bc115-d71f-4bc7-ac49-91da79dabb09"), "Product 7" },
                    { new Guid("5edaed8f-d8a2-48a3-a0f0-1c7c52b39eac"), new Guid("a60bc115-d71f-4bc7-ac49-91da79dabb09"), "Product 8" },
                    { new Guid("3735c6c6-f9b1-4249-9a3b-794da2d408d4"), new Guid("a60bc115-d71f-4bc7-ac49-91da79dabb09"), "Product 9" },
                    { new Guid("56bf4b57-3ebd-4436-a821-6c0575f85686"), new Guid("a60bc115-d71f-4bc7-ac49-91da79dabb09"), "Product 10" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0195579a-6c52-4759-9360-49957bad6991"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00fa52ea-c324-44ee-a0b7-765f75e674d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("03bdf287-90d4-446c-a08f-bfdaf7a3452a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2cf0047b-3cbe-4cc6-aa8b-d692b13c121f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3735c6c6-f9b1-4249-9a3b-794da2d408d4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("56bf4b57-3ebd-4436-a821-6c0575f85686"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5ec671a8-24eb-4e5b-aecb-02d05a3c361e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5edaed8f-d8a2-48a3-a0f0-1c7c52b39eac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7406fc96-a78f-4194-bf1f-26e1b77cc4b2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dd879da5-bf98-4d60-9885-0e258316fa6c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f785a54a-6125-4ae5-86e1-18019ed6f23f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5c6be1bc-8975-43a8-862f-4a9292c0392d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8f55e482-6f79-4aeb-959b-c4d5d24322b7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a60bc115-d71f-4bc7-ac49-91da79dabb09"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ad65906b-6856-44b4-8400-8880419bcffe"));
        }
    }
}
