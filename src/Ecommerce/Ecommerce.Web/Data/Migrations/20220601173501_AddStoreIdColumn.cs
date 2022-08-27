using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.Web.Data.Migrations
{
    public partial class AddStoreIdColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2c688534-31c4-42cd-b896-d3270c2b4a59"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6ab0542f-52fd-43a2-ba28-d94df79e4d7c"));

            migrationBuilder.AddColumn<string>(
                name: "StoreId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("380e5b90-daf7-4adc-94fe-48c886c71211"), "637897233007548385", "Admin", "ADMIN" },
                    { new Guid("b7f3b715-3b6a-408a-946d-8b6088a3dafb"), "637897233007548414", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0b3b9edb-aba7-45a4-b31b-88f1235e0680"),
                column: "ConcurrencyStamp",
                value: "612639e7-4229-43b0-b760-1439fa436fcb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0c096510-ce94-44c9-a870-a625120debbb"),
                column: "ConcurrencyStamp",
                value: "9d2f6a5e-a108-4736-8221-12ebd0e59b84");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("21c20e80-103e-47cd-bed1-40ae0abc637b"),
                column: "ConcurrencyStamp",
                value: "33dc89e9-683f-42b9-989a-2d76418c5e29");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97e98faa-1917-4c69-8ba9-2ba91d9d8e68"),
                column: "ConcurrencyStamp",
                value: "4ad6db34-9041-47db-9712-6fb008c5e0e6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("db6fa3f2-6ee6-4a3b-ac6c-9fb746857a56"),
                column: "ConcurrencyStamp",
                value: "447ad08a-256f-432f-afbf-f1574bbe5e1d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e7f746e7-8b57-4484-8c7f-195e24bf78e4"),
                column: "ConcurrencyStamp",
                value: "38215fa9-0c9c-4eac-b10e-5f2b3151bb2f");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("380e5b90-daf7-4adc-94fe-48c886c71211"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b7f3b715-3b6a-408a-946d-8b6088a3dafb"));

            migrationBuilder.DropColumn(
                name: "StoreId",
                table: "AspNetUsers");

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
    }
}
