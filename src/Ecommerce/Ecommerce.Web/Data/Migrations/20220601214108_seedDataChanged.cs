using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.Web.Data.Migrations
{
    public partial class seedDataChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0b42eb8c-a7fd-46aa-a88c-8d656b016115"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9858), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9858) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("136e59e2-2046-460f-ad0e-60b75f3748c9"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9860), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7a61cf49-d11a-494d-95ca-c649ed215773"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9827), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d0059e3-816c-44e1-8e36-adb7c74e1c7c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9862), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9863) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7e2c655f-5e84-48c7-bda1-ad178a7be899"),
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9865), "Files/pd-6.jpg", new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c405483e-b35c-4c4e-9e7e-387b5527f0b7"),
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9867), "Files/pd-6.jpg", new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9867) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d6dcf59a-0cf7-4c22-aff5-38cd0223aca0"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9830), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9831) });

            migrationBuilder.UpdateData(
                table: "EmailMessages",
                keyColumn: "Id",
                keyValue: new Guid("093e78d3-df09-435a-834f-8b53a01b82ff"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(209), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(209) });

            migrationBuilder.UpdateData(
                table: "EmailMessages",
                keyColumn: "Id",
                keyValue: new Guid("4050a16e-35f4-4696-b1a5-93c3fce68293"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(202), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(202) });

            migrationBuilder.UpdateData(
                table: "EmailMessages",
                keyColumn: "Id",
                keyValue: new Guid("4bd3bcfe-8084-49d6-8d04-50a4b59808f5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(205), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(205) });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("0ac9c4cd-003d-4bce-b5bc-732f025a57df"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(168), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(169) });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("1fa9d85a-1f28-4a16-a6ab-83cd29082a9d"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(180), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(180) });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("3ca1f739-7559-4a50-b4e3-8e8d8c86d482"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(175), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(175) });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("76e3dac5-facf-471d-af6c-ba5eb733f0d8"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(176), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(177) });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("9249ed3f-50d1-4f62-8d2f-9e047770ea6c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(183), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("97081fb9-f963-4125-aee3-ae7deaecb0ec"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(170), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(171) });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("b5ede1aa-d435-4817-b11d-55a518ad338f"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(178), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(179) });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("beb721e0-0880-47b0-8a4e-298214b89134"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(182), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(182) });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("e2390a67-27f8-439f-9c62-3ecb09dca511"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(173), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(173) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("0221e486-e1fb-4f70-bb50-b527d1f28aa9"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9910), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("168528cc-7ba4-452d-b4bf-d8032b3c2ef7"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9903), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9904) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("23fcef43-c376-42bf-aeb9-a7814bd389b1"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9951), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9951) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("30b27db0-5cfb-4191-87f2-31055a93bcf9"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9944), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9944) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("35eb699e-2178-4aa9-aa35-9da2f042f5aa"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9908), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("39002937-6e1b-4aae-8c44-48f4f6110b4b"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9917), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("39343150-0ebd-4034-b593-2260a85959bb"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9949), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("3ea2bf49-689e-4835-afaf-0e6634bc116e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9937), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("48ecb090-d6e6-456e-ae46-3bac53c6940d"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9916), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9916) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("4c78c682-3db8-475e-adbc-acf6ef43cef7"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9924), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9925) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("4ff8ed54-c165-40e9-ab72-41badce8bf96"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9921), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9921) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("6ba7ec7d-76ed-4e4b-a5bd-f720c829e524"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9940), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9941) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("85142851-d4db-4e6d-b79c-34f42a844c72"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9933), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("8f6722d3-465d-4179-82df-45437c3616b6"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9930), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9930) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("9b545b2c-7e36-41ac-b39a-052cd61c8d4c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9906), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("a0fc5bd0-c61b-4245-912c-592f364119ee"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9912), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9912) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("a4a74c94-afe8-4b2b-8b52-3de87ce926c3"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9939), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("b10e0200-8dd7-4363-a910-dd8951015917"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9928), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9928) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("bb16a155-3b52-4068-a639-ead927c7eb18"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9948), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9948) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("c46e2768-2dee-456e-b4a9-395980d959b9"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9932), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9932) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("cd51ede2-86ed-4be8-90a7-a793533180a9"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9914), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("cf96e6bd-ed46-440f-b7a6-74478e6c0f1c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9926), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9926) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("cf9c16f2-f231-4333-8f03-80eb2e0ad668"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9922), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9923) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("e055e80e-6894-43e9-bce3-3ee45c044b3e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9946), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9946) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("e8378dea-aa5f-4687-ad57-59c7beb7dd78"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9919), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9919) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("ec75d4e0-6988-4e50-968b-a090b90dbaaf"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9942), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9942) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("f5e85072-f168-47c5-9c9c-f49980f0c88e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9935), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9936) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0564dc12-ca23-4508-8f53-8a4c5aefe1a9"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9786), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0c7dbebf-c240-405b-9883-1606ec29da00"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9789), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9789) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("17a7dff9-34fd-44e6-98c2-aa9dd60392ef"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9783), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9783) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3384cc0b-0030-4972-9454-159d47149677"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9799), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7f6a2181-c381-4e6f-9c14-d9fc2c85b4f2"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9791), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9791) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d9791cd-737c-4de8-bdfd-acf51a1dbb83"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9801), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9801) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c272683a-c8d9-4e9d-b876-16f1e6f0d557"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9797), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9797) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c8fe1651-fd04-4c52-a3c1-634ad6d0e413"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9795), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9795) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("da35a95d-6862-45e1-8f10-6c0a5e1200d0"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9803), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9803) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("0238037a-2cd5-4ea9-b757-837c94abdc6d"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(99), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(99) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("2f006d01-c324-47ae-bbbb-ea2ea344f5ae"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(133), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(133) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("30f3e4f8-40d4-41fc-9b93-8c4c2975a2e9"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(136), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(137) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("371094d8-040a-43b1-9607-dee0dfbe9d35"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(142), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(142) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("3dc3e3e3-30ab-4046-bed6-faeacf2dfefb"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(138), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(138) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("4ada5267-eda9-444e-a5de-e1777af82f93"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(125), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(126) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("57e4fca9-5b0f-413f-bee4-55867f974086"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(149), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("71567962-5dd2-4b5b-a847-db236ec93c5e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(96), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(97) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("75f84234-474b-4194-beec-976df6849477"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(129), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("7b483263-77dd-427b-b8e6-50fe415054b8"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(147), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(147) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("92007882-8650-47e6-84c0-1044ca243dd5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(144), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(144) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("9f672271-69a9-4e14-ba9e-ce19d14fbae0"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(127), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(128) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("b5f9ff0c-5f2b-4688-a017-b1efea777bfd"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(134), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(135) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("ccff21d2-f3dc-4708-b9f5-dbb431330df8"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(131), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(131) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("ce002d91-8887-4119-8139-cf16594ca59d"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(140), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("deebb58a-9ca3-42dc-bf2e-c802e34ee6c9"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(124), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(124) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("dfd8ec9f-6728-42f5-9ca1-827a5a363a47"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(145), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(146) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("f02c65f1-e7bd-4188-916f-6318f0793d09"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(121), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(122) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("090734b5-5dcf-4b90-bf7a-14e0293ebc3c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(70), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(70) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("20a6a53c-6d75-4203-bd58-5d1f333630e4"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9979), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9980) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("32eb7b51-cbab-4037-a1c0-7751e59af006"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(75), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(75) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("3b7f4f89-4fd9-4a0e-a44e-5a978b984f9e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(72), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(73) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("58eb49f6-2650-4932-85b2-5cf2ab709d0a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9977), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9977) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("64d4449e-7736-4a1b-af87-19faf732d498"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9971), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("69003aac-dbd8-4cf7-a3fc-468e873b501f"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9974), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("6da2e12e-ed26-4710-b09b-5a467f00b370"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(77), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("eb38af2c-ed79-4dd2-a954-da8c0714b411"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(79), new DateTime(2022, 6, 2, 3, 41, 7, 586, DateTimeKind.Local).AddTicks(79) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("2936df93-54c3-4ff7-b2e1-00cc32b86c49"),
                columns: new[] { "CreatedAt", "Handle", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9758), "shopAmar", new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9759) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("a36b6614-5254-4fb9-9253-f2cca4b4739e"),
                columns: new[] { "CreatedAt", "Handle", "StoreUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9762), "store", "www.PeraOnk.com", new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"),
                columns: new[] { "CreatedAt", "Handle", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9752), "amarShop", new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9753) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("e8173b5c-ec25-4f48-a008-0597c99aed32"),
                columns: new[] { "CreatedAt", "Handle", "StoreUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9765), "HlwWorld", "www.earth.com", new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "SubscriptionPlans",
                keyColumn: "Id",
                keyValue: new Guid("0720c8e2-f298-40de-840f-ac63556f45ee"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9581), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "SubscriptionPlans",
                keyColumn: "Id",
                keyValue: new Guid("3882468c-202f-492f-a2e2-8d27c8f47add"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9556), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "SubscriptionPlans",
                keyColumn: "Id",
                keyValue: new Guid("5988b4b6-ea74-40b8-a4e6-692dcadc1d6c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9583), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "SubscriptionPlans",
                keyColumn: "Id",
                keyValue: new Guid("6e27c9b0-dcf7-48d8-a3fc-53b001614d94"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9585), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9585) });

            migrationBuilder.UpdateData(
                table: "SubscriptionPlans",
                keyColumn: "Id",
                keyValue: new Guid("9cd3bd23-76dd-435f-b9ee-533f403ab0c9"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9571), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9572) });

            migrationBuilder.UpdateData(
                table: "SubscriptionPlans",
                keyColumn: "Id",
                keyValue: new Guid("f7e16f23-215f-4e2c-bd43-ef3811c94b25"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9580), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "SubscriptionPlans",
                keyColumn: "Id",
                keyValue: new Guid("f926ccba-0124-4219-845f-085d49240523"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9573), new DateTime(2022, 6, 2, 3, 41, 7, 585, DateTimeKind.Local).AddTicks(9574) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0b42eb8c-a7fd-46aa-a88c-8d656b016115"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7498), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7498) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("136e59e2-2046-460f-ad0e-60b75f3748c9"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7501), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7502) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7a61cf49-d11a-494d-95ca-c649ed215773"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7491), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7491) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d0059e3-816c-44e1-8e36-adb7c74e1c7c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7505), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7505) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7e2c655f-5e84-48c7-bda1-ad178a7be899"),
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7508), "/EcommerceTheme/img/product/discount/pd-6.jpg", new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7509) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c405483e-b35c-4c4e-9e7e-387b5527f0b7"),
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7511), "/EcommerceTheme/img/product/discount/default-image.jpg", new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7512) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d6dcf59a-0cf7-4c22-aff5-38cd0223aca0"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7494), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7495) });

            migrationBuilder.UpdateData(
                table: "EmailMessages",
                keyColumn: "Id",
                keyValue: new Guid("093e78d3-df09-435a-834f-8b53a01b82ff"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7832), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7832) });

            migrationBuilder.UpdateData(
                table: "EmailMessages",
                keyColumn: "Id",
                keyValue: new Guid("4050a16e-35f4-4696-b1a5-93c3fce68293"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7824), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7825) });

            migrationBuilder.UpdateData(
                table: "EmailMessages",
                keyColumn: "Id",
                keyValue: new Guid("4bd3bcfe-8084-49d6-8d04-50a4b59808f5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7829), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("0ac9c4cd-003d-4bce-b5bc-732f025a57df"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7774), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("1fa9d85a-1f28-4a16-a6ab-83cd29082a9d"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7793), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7794) });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("3ca1f739-7559-4a50-b4e3-8e8d8c86d482"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7782), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7782) });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("76e3dac5-facf-471d-af6c-ba5eb733f0d8"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7786), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7786) });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("9249ed3f-50d1-4f62-8d2f-9e047770ea6c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7800), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("97081fb9-f963-4125-aee3-ae7deaecb0ec"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7777), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7777) });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("b5ede1aa-d435-4817-b11d-55a518ad338f"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7791), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7791) });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("beb721e0-0880-47b0-8a4e-298214b89134"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7795), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("e2390a67-27f8-439f-9c62-3ecb09dca511"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7779), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("0221e486-e1fb-4f70-bb50-b527d1f28aa9"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7566), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7566) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("168528cc-7ba4-452d-b4bf-d8032b3c2ef7"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7557), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7558) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("23fcef43-c376-42bf-aeb9-a7814bd389b1"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7627), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7628) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("30b27db0-5cfb-4191-87f2-31055a93bcf9"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7617), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7617) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("35eb699e-2178-4aa9-aa35-9da2f042f5aa"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7563), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7564) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("39002937-6e1b-4aae-8c44-48f4f6110b4b"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7576), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7576) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("39343150-0ebd-4034-b593-2260a85959bb"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7625), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("3ea2bf49-689e-4835-afaf-0e6634bc116e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7606), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7606) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("48ecb090-d6e6-456e-ae46-3bac53c6940d"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7573), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7574) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("4c78c682-3db8-475e-adbc-acf6ef43cef7"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7588), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("4ff8ed54-c165-40e9-ab72-41badce8bf96"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7583), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("6ba7ec7d-76ed-4e4b-a5bd-f720c829e524"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7612), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7612) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("85142851-d4db-4e6d-b79c-34f42a844c72"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7600), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7601) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("8f6722d3-465d-4179-82df-45437c3616b6"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7595), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7596) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("9b545b2c-7e36-41ac-b39a-052cd61c8d4c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7560), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7561) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("a0fc5bd0-c61b-4245-912c-592f364119ee"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7568), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7569) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("a4a74c94-afe8-4b2b-8b52-3de87ce926c3"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7609), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("b10e0200-8dd7-4363-a910-dd8951015917"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7593), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7594) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("bb16a155-3b52-4068-a639-ead927c7eb18"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7622), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7623) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("c46e2768-2dee-456e-b4a9-395980d959b9"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7598), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7598) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("cd51ede2-86ed-4be8-90a7-a793533180a9"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7571), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7571) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("cf96e6bd-ed46-440f-b7a6-74478e6c0f1c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7591), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("cf9c16f2-f231-4333-8f03-80eb2e0ad668"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7585), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7586) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("e055e80e-6894-43e9-bce3-3ee45c044b3e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7619), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("e8378dea-aa5f-4687-ad57-59c7beb7dd78"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7579), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("ec75d4e0-6988-4e50-968b-a090b90dbaaf"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7615), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7615) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("f5e85072-f168-47c5-9c9c-f49980f0c88e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7603), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7603) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0564dc12-ca23-4508-8f53-8a4c5aefe1a9"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7432), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7432) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0c7dbebf-c240-405b-9883-1606ec29da00"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7435), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7435) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("17a7dff9-34fd-44e6-98c2-aa9dd60392ef"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7428), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7429) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3384cc0b-0030-4972-9454-159d47149677"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7455), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7455) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7f6a2181-c381-4e6f-9c14-d9fc2c85b4f2"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7438), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7438) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d9791cd-737c-4de8-bdfd-acf51a1dbb83"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7458), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7458) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c272683a-c8d9-4e9d-b876-16f1e6f0d557"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7452), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7453) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c8fe1651-fd04-4c52-a3c1-634ad6d0e413"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7441), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7441) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("da35a95d-6862-45e1-8f10-6c0a5e1200d0"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7461), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7461) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("0238037a-2cd5-4ea9-b757-837c94abdc6d"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7709), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7709) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("2f006d01-c324-47ae-bbbb-ea2ea344f5ae"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7728), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("30f3e4f8-40d4-41fc-9b93-8c4c2975a2e9"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7733), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7734) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("371094d8-040a-43b1-9607-dee0dfbe9d35"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7741), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("3dc3e3e3-30ab-4046-bed6-faeacf2dfefb"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7736), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7736) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("4ada5267-eda9-444e-a5de-e1777af82f93"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7716), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("57e4fca9-5b0f-413f-bee4-55867f974086"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7751), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7751) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("71567962-5dd2-4b5b-a847-db236ec93c5e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7706), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7707) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("75f84234-474b-4194-beec-976df6849477"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7723), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("7b483263-77dd-427b-b8e6-50fe415054b8"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7748), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("92007882-8650-47e6-84c0-1044ca243dd5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7743), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("9f672271-69a9-4e14-ba9e-ce19d14fbae0"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7720), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("b5f9ff0c-5f2b-4688-a017-b1efea777bfd"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7731), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7731) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("ccff21d2-f3dc-4708-b9f5-dbb431330df8"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7726), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7726) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("ce002d91-8887-4119-8139-cf16594ca59d"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7738), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("deebb58a-9ca3-42dc-bf2e-c802e34ee6c9"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7714), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7714) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("dfd8ec9f-6728-42f5-9ca1-827a5a363a47"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7746), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7746) });

            migrationBuilder.UpdateData(
                table: "ReviewImages",
                keyColumn: "Id",
                keyValue: new Guid("f02c65f1-e7bd-4188-916f-6318f0793d09"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7711), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7712) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("090734b5-5dcf-4b90-bf7a-14e0293ebc3c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7672), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("20a6a53c-6d75-4203-bd58-5d1f333630e4"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7663), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("32eb7b51-cbab-4037-a1c0-7751e59af006"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7678), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("3b7f4f89-4fd9-4a0e-a44e-5a978b984f9e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("58eb49f6-2650-4932-85b2-5cf2ab709d0a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7660), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("64d4449e-7736-4a1b-af87-19faf732d498"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7653), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7653) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("69003aac-dbd8-4cf7-a3fc-468e873b501f"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7656), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7657) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("6da2e12e-ed26-4710-b09b-5a467f00b370"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7681), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7682) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("eb38af2c-ed79-4dd2-a954-da8c0714b411"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7684), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("2936df93-54c3-4ff7-b2e1-00cc32b86c49"),
                columns: new[] { "CreatedAt", "Handle", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7389), "DokanAmar", new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("a36b6614-5254-4fb9-9253-f2cca4b4739e"),
                columns: new[] { "CreatedAt", "Handle", "StoreUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7394), "DokanAmar_", "www.PeraNaiChill.com", new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7394) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"),
                columns: new[] { "CreatedAt", "Handle", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7382), "amarDokan", new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("e8173b5c-ec25-4f48-a008-0597c99aed32"),
                columns: new[] { "CreatedAt", "Handle", "StoreUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7402), "DokanAmar69", "www.vai-vai.com", new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7402) });

            migrationBuilder.UpdateData(
                table: "SubscriptionPlans",
                keyColumn: "Id",
                keyValue: new Guid("0720c8e2-f298-40de-840f-ac63556f45ee"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7222), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7223) });

            migrationBuilder.UpdateData(
                table: "SubscriptionPlans",
                keyColumn: "Id",
                keyValue: new Guid("3882468c-202f-492f-a2e2-8d27c8f47add"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7198), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7210) });

            migrationBuilder.UpdateData(
                table: "SubscriptionPlans",
                keyColumn: "Id",
                keyValue: new Guid("5988b4b6-ea74-40b8-a4e6-692dcadc1d6c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7224), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7225) });

            migrationBuilder.UpdateData(
                table: "SubscriptionPlans",
                keyColumn: "Id",
                keyValue: new Guid("6e27c9b0-dcf7-48d8-a3fc-53b001614d94"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7228), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7228) });

            migrationBuilder.UpdateData(
                table: "SubscriptionPlans",
                keyColumn: "Id",
                keyValue: new Guid("9cd3bd23-76dd-435f-b9ee-533f403ab0c9"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7214), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7215) });

            migrationBuilder.UpdateData(
                table: "SubscriptionPlans",
                keyColumn: "Id",
                keyValue: new Guid("f7e16f23-215f-4e2c-bd43-ef3811c94b25"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7220), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "SubscriptionPlans",
                keyColumn: "Id",
                keyValue: new Guid("f926ccba-0124-4219-845f-085d49240523"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7218), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7218) });
        }
    }
}
