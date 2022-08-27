using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.Web.Data.Migrations
{
    public partial class CustomerRoleSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6fd54e4a-cb60-4010-b111-a0a5fe6aa81b"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("2c688534-31c4-42cd-b896-d3270c2b4a59"), "637897195877085776", "Customer", "CUSTOMER" },
                    { new Guid("6ab0542f-52fd-43a2-ba28-d94df79e4d7c"), "637897195877085718", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0b3b9edb-aba7-45a4-b31b-88f1235e0680"),
                column: "ConcurrencyStamp",
                value: "10eb7b54-5352-4efe-a53f-b0fcf770e009");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0c096510-ce94-44c9-a870-a625120debbb"),
                column: "ConcurrencyStamp",
                value: "71ca41e0-7274-4cf0-b5f1-712de9d69a89");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("21c20e80-103e-47cd-bed1-40ae0abc637b"),
                column: "ConcurrencyStamp",
                value: "2fa7fcbb-4889-46f8-b7a0-febdc59ea2cb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97e98faa-1917-4c69-8ba9-2ba91d9d8e68"),
                column: "ConcurrencyStamp",
                value: "2974f5e3-1c92-44ee-9db7-fbe93fcabdb1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("db6fa3f2-6ee6-4a3b-ac6c-9fb746857a56"),
                column: "ConcurrencyStamp",
                value: "6881dd2a-78cd-4ef6-ba20-d87403bad72c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e7f746e7-8b57-4484-8c7f-195e24bf78e4"),
                column: "ConcurrencyStamp",
                value: "25f78961-66d3-4881-9cba-2f394e2e1dce");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2c688534-31c4-42cd-b896-d3270c2b4a59"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6ab0542f-52fd-43a2-ba28-d94df79e4d7c"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("6fd54e4a-cb60-4010-b111-a0a5fe6aa81b"), "637897132056581690", "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0b3b9edb-aba7-45a4-b31b-88f1235e0680"),
                column: "ConcurrencyStamp",
                value: "5a20fc7b-2f22-4ec8-8919-ac270094010e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0c096510-ce94-44c9-a870-a625120debbb"),
                column: "ConcurrencyStamp",
                value: "d18f9058-69e5-4acf-a5f4-92ca465b5b3b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("21c20e80-103e-47cd-bed1-40ae0abc637b"),
                column: "ConcurrencyStamp",
                value: "10f52b15-d009-4a39-bfee-788f2ce07e2d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97e98faa-1917-4c69-8ba9-2ba91d9d8e68"),
                column: "ConcurrencyStamp",
                value: "9ff2bcf8-cbef-4ddf-b3ba-1caa190ccce9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("db6fa3f2-6ee6-4a3b-ac6c-9fb746857a56"),
                column: "ConcurrencyStamp",
                value: "4727484c-7a8d-4be7-b2e6-99d644c219ee");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e7f746e7-8b57-4484-8c7f-195e24bf78e4"),
                column: "ConcurrencyStamp",
                value: "6b31f378-399a-4fc0-a074-9944b42fd8dc");
        }
    }
}
