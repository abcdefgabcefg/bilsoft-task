using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class ExpendSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Title" },
                values: new object[,]
                {
                    { new Guid("709fe3c4-52d0-4236-8674-706dce869c46"), new Guid("a60bc115-d71f-4bc7-ac49-91da79dabb09"), "Product 11" },
                    { new Guid("044ad6a4-1f95-45e6-af1f-4a3db6e565ac"), new Guid("a60bc115-d71f-4bc7-ac49-91da79dabb09"), "Product 12" },
                    { new Guid("dce5b3ad-dc96-48f2-91fa-61a4a8142611"), new Guid("a60bc115-d71f-4bc7-ac49-91da79dabb09"), "Product 13" },
                    { new Guid("9c356c4b-9a06-4d0a-ac8a-b12c6b985d09"), new Guid("a60bc115-d71f-4bc7-ac49-91da79dabb09"), "Product 14" },
                    { new Guid("0cfb0a0a-f739-428c-9533-ed2668dd5f3b"), new Guid("a60bc115-d71f-4bc7-ac49-91da79dabb09"), "Product 15" },
                    { new Guid("5f6cb301-69e8-492a-b39b-256bc3f54435"), new Guid("a60bc115-d71f-4bc7-ac49-91da79dabb09"), "Product 16" },
                    { new Guid("61f8b135-67ea-4e80-a0de-1b8949637500"), new Guid("a60bc115-d71f-4bc7-ac49-91da79dabb09"), "Product 17" },
                    { new Guid("90f74aa5-40c8-424e-88b9-b5ba9bfc7028"), new Guid("a60bc115-d71f-4bc7-ac49-91da79dabb09"), "Product 18" },
                    { new Guid("f2945837-ef09-4c24-86da-6607cf948c37"), new Guid("a60bc115-d71f-4bc7-ac49-91da79dabb09"), "Product 19" },
                    { new Guid("a697dc57-f02b-4bae-8b38-c778b85e4498"), new Guid("a60bc115-d71f-4bc7-ac49-91da79dabb09"), "Product 20" },
                    { new Guid("c2a47173-ecbd-42f7-9616-e3ca93eeadd0"), new Guid("a60bc115-d71f-4bc7-ac49-91da79dabb09"), "Product 20" },
                    { new Guid("08c432ff-2eca-40e3-919d-0549a26cf221"), new Guid("a60bc115-d71f-4bc7-ac49-91da79dabb09"), "Product 20" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("044ad6a4-1f95-45e6-af1f-4a3db6e565ac"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("08c432ff-2eca-40e3-919d-0549a26cf221"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0cfb0a0a-f739-428c-9533-ed2668dd5f3b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5f6cb301-69e8-492a-b39b-256bc3f54435"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("61f8b135-67ea-4e80-a0de-1b8949637500"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("709fe3c4-52d0-4236-8674-706dce869c46"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("90f74aa5-40c8-424e-88b9-b5ba9bfc7028"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9c356c4b-9a06-4d0a-ac8a-b12c6b985d09"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a697dc57-f02b-4bae-8b38-c778b85e4498"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c2a47173-ecbd-42f7-9616-e3ca93eeadd0"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("dce5b3ad-dc96-48f2-91fa-61a4a8142611"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f2945837-ef09-4c24-86da-6607cf948c37"));
        }
    }
}
