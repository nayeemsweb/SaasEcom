using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.Web.Data.Migrations
{
    public partial class StoreCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateSequence<int>(
                name: "OrderNumbers",
                schema: "dbo",
                startValue: 1000L);

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StoreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactForms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactForms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailMessages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StoreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NotificationType = table.Column<int>(type: "int", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceiverName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceiverEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SendTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmailStatus = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailMessages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StoreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderNumber = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR dbo.OrderNumbers"),
                    OrderStatus = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountedPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ActiveStatus = table.Column<bool>(type: "bit", nullable: false),
                    Featured = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    StoreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeleteQueue = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductsDeleteQueue",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StoreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TriggeredOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsDeleteQueue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSubscriptionNotifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    StoreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSubscriptionNotifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Handle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StoreName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StoreUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoreLogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoreBannerUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperatingIndustry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoreTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoreDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoreEmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OptionalPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookPageHandle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstagramAccountHandle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApartmentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DetailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HostTrigger = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    SubscriptionPlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionPlans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlanName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlanPrice = table.Column<long>(type: "bigint", nullable: false),
                    ProductUploadLimit = table.Column<int>(type: "int", nullable: false),
                    StorageLimit = table.Column<double>(type: "float", nullable: false),
                    PlanColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublicPlan = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wishlists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StoreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderedProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductQuantity = table.Column<int>(type: "int", nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderedProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderedProducts_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inventories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Stars = table.Column<int>(type: "int", nullable: false),
                    ReviewMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReviewImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReviewImages_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "EmailMessages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "EmailStatus", "Message", "NotificationType", "ReceiverEmail", "ReceiverName", "SendTime", "StoreId", "Subject", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("093e78d3-df09-435a-834f-8b53a01b82ff"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7832), new Guid("00000000-0000-0000-0000-000000000000"), 1, "Dash Product is out of stock", 4, "rifat@gmail.com", "Rifat", new DateTime(2022, 5, 20, 15, 45, 0, 0, DateTimeKind.Unspecified), new Guid("644de43f-1762-466d-a251-ff3995fe43ca"), "Product StockOut", new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7832), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4050a16e-35f4-4696-b1a5-93c3fce68293"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7824), new Guid("00000000-0000-0000-0000-000000000000"), 1, "Please confirm your account by <a href='https://localhost:7191/Account/ConfirmEmail?userId=97087166-d73e-45d9-fcb5-08da187a20f1&amp;code=Q2ZESjhLVFh6U0g2bHMxQ21JRlBxQjhUY1NjOWF3eFJWVldTWHBtd3VhNmtTNG8xcmo0NGVYVWxHY2VUbEplK1pIclJVUnlWZVhlTVh3NlpicVN5N1B2UTNTOVp5NGhJdWd5bzhWc3FjYUFtMm1hNk9JbjdPRzEveXZSYkFOdkVDU2RrbnZDa0dicHM0NWdUVk5raXZDczI3aVlzQWJHTFcwY1B0MVh2R2ZUdUZ1bURNd0wvMzhrdFNUa0JQdDVPaXM5T1IyWVJrbU8rem4wZWIyU1Z2WlpseDFEZGJobmowZ20xUXNEbE10U3JHdHhOdy80bFJsdkxUbWpCWVNJazR3MlN6QT09&amp;returnUrl=%2F'>clicking here</a>.", 2, "lamia@gmail.com", "Lamia", new DateTime(2022, 5, 20, 13, 45, 0, 0, DateTimeKind.Unspecified), new Guid("691de45c-e852-4b05-ad05-2ef411d77be6"), "Email Confirmation", new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7825), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4bd3bcfe-8084-49d6-8d04-50a4b59808f5"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7829), new Guid("00000000-0000-0000-0000-000000000000"), 1, "Please Check just Placed Order", 5, "nabila@gmail.com", "Nabila", new DateTime(2022, 5, 20, 14, 45, 0, 0, DateTimeKind.Unspecified), new Guid("2fb18a16-24cf-49a3-9d81-1a6fa5ab92f8"), "New Order Notification", new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7829), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ActiveStatus", "CreatedAt", "CreatedBy", "Description", "DiscountedPrice", "Name", "StoreId", "UnitPrice", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0564dc12-ca23-4508-8f53-8a4c5aefe1a9"), true, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7432), new Guid("00000000-0000-0000-0000-000000000000"), "Forget about description, firstly eat all of those.", 200m, "JackFruit", new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"), 230m, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7432), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0c7dbebf-c240-405b-9883-1606ec29da00"), true, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7435), new Guid("00000000-0000-0000-0000-000000000000"), "Forget about description, firstly eat all of those.", 200m, "APPLE", new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"), 230m, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7435), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("17a7dff9-34fd-44e6-98c2-aa9dd60392ef"), true, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7428), new Guid("00000000-0000-0000-0000-000000000000"), "Forget about description, firstly eat all of those.", 200m, "Mango", new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"), 230m, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7429), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3384cc0b-0030-4972-9454-159d47149677"), true, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7455), new Guid("00000000-0000-0000-0000-000000000000"), "Forget about description, firstly eat all of those.", 200m, "BLACK BERRY", new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"), 230m, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7455), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7f6a2181-c381-4e6f-9c14-d9fc2c85b4f2"), true, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7438), new Guid("00000000-0000-0000-0000-000000000000"), "Forget about description, firstly eat all of those.", 200m, "BANANA", new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"), 230m, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7438), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9d9791cd-737c-4de8-bdfd-acf51a1dbb83"), true, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7458), new Guid("00000000-0000-0000-0000-000000000000"), "Forget about description, firstly eat all of those.", 200m, "CUSTARD APPLE", new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"), 230m, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7458), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c272683a-c8d9-4e9d-b876-16f1e6f0d557"), true, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7452), new Guid("00000000-0000-0000-0000-000000000000"), "Forget about description, firstly eat all of those.", 200m, "BLACK BERRY", new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"), 230m, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7453), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c8fe1651-fd04-4c52-a3c1-634ad6d0e413"), true, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7441), new Guid("00000000-0000-0000-0000-000000000000"), "Forget about description, firstly eat all of those.", 200m, "BLACK BERRY", new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"), 230m, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7441), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("da35a95d-6862-45e1-8f10-6c0a5e1200d0"), true, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7461), new Guid("00000000-0000-0000-0000-000000000000"), "Forget about description, firstly eat all of those.", 200m, "DATE", new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"), 230m, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7461), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "Id", "ApartmentAddress", "City", "Country", "CreatedAt", "CreatedBy", "DetailAddress", "FacebookPageHandle", "Handle", "InstagramAccountHandle", "OperatingIndustry", "OptionalPhoneNumber", "PostalCode", "PrimaryPhoneNumber", "StoreBannerUrl", "StoreDescription", "StoreEmailAddress", "StoreLogoUrl", "StoreName", "StoreTitle", "StoreUrl", "SubscriptionPlanId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("2936df93-54c3-4ff7-b2e1-00cc32b86c49"), "107, Prem Goli, Jatrabari.", "Dhaka", "Bangladesh", new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7389), new Guid("00000000-0000-0000-0000-000000000000"), "Nil akhash", "www.facebook.com/vai123", "DokanAmar", "www.instagram.com/vai123", "Electronics", "+880123456789", "1236", "+880123456789", "Files/Screenshot_28.png", "Fresh food", "vai_vai@gmail.com", "Files/online-shopLogojpg.jpg", "Vai Vai Mudir dokan", "Baki cheye lojja diben na", "www.vai-vai.com", new Guid("0720c8e2-f298-40de-840f-ac63556f45ee"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7390), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a36b6614-5254-4fb9-9253-f2cca4b4739e"), "107, Prem Goli, Jatrabari.", "Dhaka", "Bangladesh", new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7394), new Guid("00000000-0000-0000-0000-000000000000"), "Nil akhash", "www.facebook.com/PeraNaiChill", "DokanAmar_", "www.instagram.com/PeraNaiChill", "Food", "+880123456789", "1236", "+880123456789", "Files/Screenshot_28.png", "Ai khany valo valo khabar pawa jay", "chill@gmail.com", "Files/online-shopLogojpg.jpg", "Pera Nai Chill 2", "Ekdin to morei jabo", "www.PeraNaiChill.com", new Guid("9cd3bd23-76dd-435f-b9ee-533f403ab0c9"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7394), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"), "107, Prem Goli, Jatrabari.", "Dhaka", "Bangladesh", new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7382), new Guid("00000000-0000-0000-0000-000000000000"), "Nil akhash", "www.facebook.com/PeraNaiChill", "amarDokan", "www.instagram.com/PeraNaiChill", "Food", "+880123456789", "1236", "+880123456789", "Files/Screenshot_28.png", "Ai khany valo valo khabar pawa jay", "chill@gmail.com", "Files/online-shopLogojpg.jpg", "Pera Nai Chill", "Ekdin to morei jabo", "www.PeraNaiChill.com", new Guid("3882468c-202f-492f-a2e2-8d27c8f47add"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7383), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e8173b5c-ec25-4f48-a008-0597c99aed32"), "107, Prem Goli, Jatrabari.", "Dhaka", "Bangladesh", new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7402), new Guid("00000000-0000-0000-0000-000000000000"), "Nil akhash", "www.facebook.com/vai123", "DokanAmar69", "www.instagram.com/vai123", "Electronics", "+880123456789", "1236", "+880123456789", "Files/Screenshot_28.png", "Fresh food", "vai_vai@gmail.com", "Files/online-shopLogojpg.jpg", "Vai Vai Mudir dokan 2", "Baki cheye lojja diben na", "www.vai-vai.com", new Guid("3882468c-202f-492f-a2e2-8d27c8f47add"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7402), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "SubscriptionPlans",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "PlanColor", "PlanName", "PlanPrice", "ProductUploadLimit", "PublicPlan", "StorageLimit", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0720c8e2-f298-40de-840f-ac63556f45ee"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7222), new Guid("00000000-0000-0000-0000-000000000000"), "#b81a34", "Gold", 30000L, 5000, true, 5120.0, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7223), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3882468c-202f-492f-a2e2-8d27c8f47add"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7198), new Guid("00000000-0000-0000-0000-000000000000"), "#32a852", "Free", 0L, 30, true, 64.0, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7210), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5988b4b6-ea74-40b8-a4e6-692dcadc1d6c"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7224), new Guid("00000000-0000-0000-0000-000000000000"), "#8de010", "Diamond", 50000L, 10000, true, 10240.0, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7225), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("6e27c9b0-dcf7-48d8-a3fc-53b001614d94"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7228), new Guid("00000000-0000-0000-0000-000000000000"), "#e01010", "Platinum", 1000000L, 100000, true, 102400.0, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7228), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9cd3bd23-76dd-435f-b9ee-533f403ab0c9"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7214), new Guid("00000000-0000-0000-0000-000000000000"), "#1a93b8", "Starter", 1000L, 100, true, 128.0, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7215), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f7e16f23-215f-4e2c-bd43-ef3811c94b25"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7220), new Guid("00000000-0000-0000-0000-000000000000"), "#981ab8", "Silver", 10000L, 1000, true, 1024.0, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7220), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f926ccba-0124-4219-845f-085d49240523"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7218), new Guid("00000000-0000-0000-0000-000000000000"), "#1a2cb8", "Bronze", 3000L, 500, true, 512.0, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7218), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "ImageUrl", "Name", "StoreId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0b42eb8c-a7fd-46aa-a88c-8d656b016115"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7498), new Guid("00000000-0000-0000-0000-000000000000"), "This is category description", "Files/bongobondhu.jpg", "Seasonal Food", new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7498), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("136e59e2-2046-460f-ad0e-60b75f3748c9"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7501), new Guid("00000000-0000-0000-0000-000000000000"), "This is category description", "Files/bongobondhu1.jpg", "Phone", new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7502), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7a61cf49-d11a-494d-95ca-c649ed215773"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7491), new Guid("00000000-0000-0000-0000-000000000000"), "This is category description", "Files/bongobondhu.jpg", "Food", new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7491), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7d0059e3-816c-44e1-8e36-adb7c74e1c7c"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7505), new Guid("00000000-0000-0000-0000-000000000000"), "This is category description", "Files/bongobondhu.jpg", "Cloths", new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7505), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7e2c655f-5e84-48c7-bda1-ad178a7be899"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7508), new Guid("00000000-0000-0000-0000-000000000000"), "This is category description", "/EcommerceTheme/img/product/discount/pd-6.jpg", "Gadgets", new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7509), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c405483e-b35c-4c4e-9e7e-387b5527f0b7"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7511), new Guid("00000000-0000-0000-0000-000000000000"), "This is a default Category", "/EcommerceTheme/img/product/discount/default-image.jpg", "default", new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7512), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d6dcf59a-0cf7-4c22-aff5-38cd0223aca0"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7494), new Guid("00000000-0000-0000-0000-000000000000"), "This is category description", "Files/bongobondhu1.jpg", "Vegetable", new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7495), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ProductId", "Quantity", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0ac9c4cd-003d-4bce-b5bc-732f025a57df"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7774), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("17a7dff9-34fd-44e6-98c2-aa9dd60392ef"), 23, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7774), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1fa9d85a-1f28-4a16-a6ab-83cd29082a9d"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7793), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("3384cc0b-0030-4972-9454-159d47149677"), 68, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7794), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3ca1f739-7559-4a50-b4e3-8e8d8c86d482"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7782), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("7f6a2181-c381-4e6f-9c14-d9fc2c85b4f2"), 7, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7782), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("76e3dac5-facf-471d-af6c-ba5eb733f0d8"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7786), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c8fe1651-fd04-4c52-a3c1-634ad6d0e413"), 45, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7786), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9249ed3f-50d1-4f62-8d2f-9e047770ea6c"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7800), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("da35a95d-6862-45e1-8f10-6c0a5e1200d0"), 94, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7800), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("97081fb9-f963-4125-aee3-ae7deaecb0ec"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7777), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0564dc12-ca23-4508-8f53-8a4c5aefe1a9"), 4, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7777), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b5ede1aa-d435-4817-b11d-55a518ad338f"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7791), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c272683a-c8d9-4e9d-b876-16f1e6f0d557"), 235, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7791), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("beb721e0-0880-47b0-8a4e-298214b89134"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7795), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9d9791cd-737c-4de8-bdfd-acf51a1dbb83"), 90, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7796), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e2390a67-27f8-439f-9c62-3ecb09dca511"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7779), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0c7dbebf-c240-405b-9883-1606ec29da00"), 6, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7779), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ProductId", "UpdatedAt", "UpdatedBy", "Url" },
                values: new object[,]
                {
                    { new Guid("0221e486-e1fb-4f70-bb50-b527d1f28aa9"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7566), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0564dc12-ca23-4508-8f53-8a4c5aefe1a9"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7566), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg" },
                    { new Guid("168528cc-7ba4-452d-b4bf-d8032b3c2ef7"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7557), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("17a7dff9-34fd-44e6-98c2-aa9dd60392ef"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7558), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg" },
                    { new Guid("23fcef43-c376-42bf-aeb9-a7814bd389b1"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7627), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("da35a95d-6862-45e1-8f10-6c0a5e1200d0"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7628), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg" },
                    { new Guid("30b27db0-5cfb-4191-87f2-31055a93bcf9"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7617), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9d9791cd-737c-4de8-bdfd-acf51a1dbb83"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7617), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg" },
                    { new Guid("35eb699e-2178-4aa9-aa35-9da2f042f5aa"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7563), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("17a7dff9-34fd-44e6-98c2-aa9dd60392ef"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7564), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg" },
                    { new Guid("39002937-6e1b-4aae-8c44-48f4f6110b4b"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7576), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0c7dbebf-c240-405b-9883-1606ec29da00"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7576), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg" },
                    { new Guid("39343150-0ebd-4034-b593-2260a85959bb"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7625), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("da35a95d-6862-45e1-8f10-6c0a5e1200d0"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7625), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg" },
                    { new Guid("3ea2bf49-689e-4835-afaf-0e6634bc116e"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7606), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("3384cc0b-0030-4972-9454-159d47149677"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7606), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg" },
                    { new Guid("48ecb090-d6e6-456e-ae46-3bac53c6940d"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7573), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0c7dbebf-c240-405b-9883-1606ec29da00"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7574), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg" },
                    { new Guid("4c78c682-3db8-475e-adbc-acf6ef43cef7"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7588), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("7f6a2181-c381-4e6f-9c14-d9fc2c85b4f2"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7588), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg" },
                    { new Guid("4ff8ed54-c165-40e9-ab72-41badce8bf96"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7583), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("7f6a2181-c381-4e6f-9c14-d9fc2c85b4f2"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7583), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg" },
                    { new Guid("6ba7ec7d-76ed-4e4b-a5bd-f720c829e524"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7612), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("3384cc0b-0030-4972-9454-159d47149677"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7612), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg" },
                    { new Guid("85142851-d4db-4e6d-b79c-34f42a844c72"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7600), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c272683a-c8d9-4e9d-b876-16f1e6f0d557"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7601), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg" },
                    { new Guid("8f6722d3-465d-4179-82df-45437c3616b6"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7595), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c8fe1651-fd04-4c52-a3c1-634ad6d0e413"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7596), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg" },
                    { new Guid("9b545b2c-7e36-41ac-b39a-052cd61c8d4c"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7560), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("17a7dff9-34fd-44e6-98c2-aa9dd60392ef"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7561), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg" },
                    { new Guid("a0fc5bd0-c61b-4245-912c-592f364119ee"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7568), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0564dc12-ca23-4508-8f53-8a4c5aefe1a9"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7569), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg" },
                    { new Guid("a4a74c94-afe8-4b2b-8b52-3de87ce926c3"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7609), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("3384cc0b-0030-4972-9454-159d47149677"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7610), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg" },
                    { new Guid("b10e0200-8dd7-4363-a910-dd8951015917"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7593), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c8fe1651-fd04-4c52-a3c1-634ad6d0e413"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7594), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg" },
                    { new Guid("bb16a155-3b52-4068-a639-ead927c7eb18"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7622), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("da35a95d-6862-45e1-8f10-6c0a5e1200d0"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7623), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg" },
                    { new Guid("c46e2768-2dee-456e-b4a9-395980d959b9"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7598), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c272683a-c8d9-4e9d-b876-16f1e6f0d557"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7598), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg" },
                    { new Guid("cd51ede2-86ed-4be8-90a7-a793533180a9"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7571), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0564dc12-ca23-4508-8f53-8a4c5aefe1a9"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7571), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg" },
                    { new Guid("cf96e6bd-ed46-440f-b7a6-74478e6c0f1c"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7591), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c8fe1651-fd04-4c52-a3c1-634ad6d0e413"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7591), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg" },
                    { new Guid("cf9c16f2-f231-4333-8f03-80eb2e0ad668"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7585), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("7f6a2181-c381-4e6f-9c14-d9fc2c85b4f2"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7586), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg" },
                    { new Guid("e055e80e-6894-43e9-bce3-3ee45c044b3e"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7619), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9d9791cd-737c-4de8-bdfd-acf51a1dbb83"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7620), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg" },
                    { new Guid("e8378dea-aa5f-4687-ad57-59c7beb7dd78"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7579), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0c7dbebf-c240-405b-9883-1606ec29da00"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7580), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg" },
                    { new Guid("ec75d4e0-6988-4e50-968b-a090b90dbaaf"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7615), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9d9791cd-737c-4de8-bdfd-acf51a1dbb83"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7615), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg" }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ProductId", "UpdatedAt", "UpdatedBy", "Url" },
                values: new object[] { new Guid("f5e85072-f168-47c5-9c9c-f49980f0c88e"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7603), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c272683a-c8d9-4e9d-b876-16f1e6f0d557"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7603), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ProductId", "ReviewMessage", "Stars", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { new Guid("090734b5-5dcf-4b90-bf7a-14e0293ebc3c"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7672), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c8fe1651-fd04-4c52-a3c1-634ad6d0e413"), "This product is awesome...", 6, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7673), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("539ebcc8-48d0-4ae2-bce3-8a805cde9d7e") },
                    { new Guid("20a6a53c-6d75-4203-bd58-5d1f333630e4"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7663), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("7f6a2181-c381-4e6f-9c14-d9fc2c85b4f2"), "This product is awesome...", 75, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7663), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("539ebcc8-48d0-4ae2-bce3-8a805cde9d7e") },
                    { new Guid("32eb7b51-cbab-4037-a1c0-7751e59af006"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7678), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("3384cc0b-0030-4972-9454-159d47149677"), "This product is awesome...", 74, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7679), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("539ebcc8-48d0-4ae2-bce3-8a805cde9d7e") },
                    { new Guid("3b7f4f89-4fd9-4a0e-a44e-5a978b984f9e"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7675), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c272683a-c8d9-4e9d-b876-16f1e6f0d557"), "This product is awesome...", 48, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7676), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("539ebcc8-48d0-4ae2-bce3-8a805cde9d7e") },
                    { new Guid("58eb49f6-2650-4932-85b2-5cf2ab709d0a"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7660), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0c7dbebf-c240-405b-9883-1606ec29da00"), "This product is awesome...", 95, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7660), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("539ebcc8-48d0-4ae2-bce3-8a805cde9d7e") },
                    { new Guid("64d4449e-7736-4a1b-af87-19faf732d498"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7653), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("17a7dff9-34fd-44e6-98c2-aa9dd60392ef"), "This product is awesome...", 51, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7653), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("539ebcc8-48d0-4ae2-bce3-8a805cde9d7e") },
                    { new Guid("69003aac-dbd8-4cf7-a3fc-468e873b501f"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7656), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0564dc12-ca23-4508-8f53-8a4c5aefe1a9"), "This product is awesome...", 45, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7657), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("539ebcc8-48d0-4ae2-bce3-8a805cde9d7e") },
                    { new Guid("6da2e12e-ed26-4710-b09b-5a467f00b370"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7681), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9d9791cd-737c-4de8-bdfd-acf51a1dbb83"), "This product is awesome...", 95, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7682), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("539ebcc8-48d0-4ae2-bce3-8a805cde9d7e") },
                    { new Guid("eb38af2c-ed79-4dd2-a954-da8c0714b411"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7684), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("da35a95d-6862-45e1-8f10-6c0a5e1200d0"), "This product is awesome...", 6, new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7685), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("539ebcc8-48d0-4ae2-bce3-8a805cde9d7e") }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("7a61cf49-d11a-494d-95ca-c649ed215773"), new Guid("0564dc12-ca23-4508-8f53-8a4c5aefe1a9") },
                    { new Guid("7a61cf49-d11a-494d-95ca-c649ed215773"), new Guid("0c7dbebf-c240-405b-9883-1606ec29da00") },
                    { new Guid("7a61cf49-d11a-494d-95ca-c649ed215773"), new Guid("17a7dff9-34fd-44e6-98c2-aa9dd60392ef") },
                    { new Guid("0b42eb8c-a7fd-46aa-a88c-8d656b016115"), new Guid("7f6a2181-c381-4e6f-9c14-d9fc2c85b4f2") },
                    { new Guid("7a61cf49-d11a-494d-95ca-c649ed215773"), new Guid("7f6a2181-c381-4e6f-9c14-d9fc2c85b4f2") },
                    { new Guid("d6dcf59a-0cf7-4c22-aff5-38cd0223aca0"), new Guid("7f6a2181-c381-4e6f-9c14-d9fc2c85b4f2") }
                });

            migrationBuilder.InsertData(
                table: "ReviewImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "ReviewId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0238037a-2cd5-4ea9-b757-837c94abdc6d"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7709), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg", new Guid("64d4449e-7736-4a1b-af87-19faf732d498"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7709), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2f006d01-c324-47ae-bbbb-ea2ea344f5ae"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7728), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg", new Guid("090734b5-5dcf-4b90-bf7a-14e0293ebc3c"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7729), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("30f3e4f8-40d4-41fc-9b93-8c4c2975a2e9"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7733), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg", new Guid("3b7f4f89-4fd9-4a0e-a44e-5a978b984f9e"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7734), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("371094d8-040a-43b1-9607-dee0dfbe9d35"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7741), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg", new Guid("32eb7b51-cbab-4037-a1c0-7751e59af006"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7741), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3dc3e3e3-30ab-4046-bed6-faeacf2dfefb"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7736), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg", new Guid("3b7f4f89-4fd9-4a0e-a44e-5a978b984f9e"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7736), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4ada5267-eda9-444e-a5de-e1777af82f93"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7716), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg", new Guid("58eb49f6-2650-4932-85b2-5cf2ab709d0a"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7717), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("57e4fca9-5b0f-413f-bee4-55867f974086"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7751), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg", new Guid("eb38af2c-ed79-4dd2-a954-da8c0714b411"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7751), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("71567962-5dd2-4b5b-a847-db236ec93c5e"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7706), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg", new Guid("64d4449e-7736-4a1b-af87-19faf732d498"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7707), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("75f84234-474b-4194-beec-976df6849477"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7723), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg", new Guid("20a6a53c-6d75-4203-bd58-5d1f333630e4"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7724), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7b483263-77dd-427b-b8e6-50fe415054b8"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7748), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg", new Guid("eb38af2c-ed79-4dd2-a954-da8c0714b411"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7749), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("92007882-8650-47e6-84c0-1044ca243dd5"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7743), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg", new Guid("6da2e12e-ed26-4710-b09b-5a467f00b370"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7744), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9f672271-69a9-4e14-ba9e-ce19d14fbae0"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7720), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg", new Guid("58eb49f6-2650-4932-85b2-5cf2ab709d0a"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7720), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b5f9ff0c-5f2b-4688-a017-b1efea777bfd"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7731), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg", new Guid("090734b5-5dcf-4b90-bf7a-14e0293ebc3c"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7731), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ccff21d2-f3dc-4708-b9f5-dbb431330df8"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7726), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg", new Guid("20a6a53c-6d75-4203-bd58-5d1f333630e4"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7726), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ce002d91-8887-4119-8139-cf16594ca59d"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7738), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg", new Guid("32eb7b51-cbab-4037-a1c0-7751e59af006"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7739), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("deebb58a-9ca3-42dc-bf2e-c802e34ee6c9"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7714), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg", new Guid("69003aac-dbd8-4cf7-a3fc-468e873b501f"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7714), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("dfd8ec9f-6728-42f5-9ca1-827a5a363a47"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7746), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg", new Guid("6da2e12e-ed26-4710-b09b-5a467f00b370"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7746), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f02c65f1-e7bd-4188-916f-6318f0793d09"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7711), new Guid("00000000-0000-0000-0000-000000000000"), "Files/andrew-seaman-14HyRO75p24-unsplash.jpg", new Guid("69003aac-dbd8-4cf7-a3fc-468e873b501f"), new DateTime(2022, 6, 1, 20, 45, 14, 619, DateTimeKind.Local).AddTicks(7712), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_StoreId",
                table: "Categories",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_ProductId",
                table: "Inventories",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderedProducts_OrderId",
                table: "OrderedProducts",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewImages_ReviewId",
                table: "ReviewImages",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "ContactForms");

            migrationBuilder.DropTable(
                name: "EmailMessages");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "OrderedProducts");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "ProductsDeleteQueue");

            migrationBuilder.DropTable(
                name: "ProductSubscriptionNotifications");

            migrationBuilder.DropTable(
                name: "ReviewImages");

            migrationBuilder.DropTable(
                name: "SubscriptionPlans");

            migrationBuilder.DropTable(
                name: "Wishlists");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropSequence(
                name: "OrderNumbers",
                schema: "dbo");
        }
    }
}
