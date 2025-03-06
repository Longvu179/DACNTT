using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MobiSell.Migrations
{
    /// <inheritdoc />
    public partial class NewDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DayCreate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vouchers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    DiscountPercentage = table.Column<double>(type: "float", nullable: true),
                    DiscountAmount = table.Column<double>(type: "float", nullable: true),
                    MinOrderAmount = table.Column<double>(type: "float", nullable: true),
                    MaxDiscountAmount = table.Column<double>(type: "float", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vouchers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Total = table.Column<int>(type: "int", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Order_ItemId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    Chip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LxWxHxW = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Display = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontCamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RearCamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Battery = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Charger = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Accessories = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quality = table.Column<int>(type: "int", nullable: false),
                    Sold = table.Column<int>(type: "int", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    DayCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DayUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ReceiverName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceiverNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShippingAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoucherId = table.Column<int>(type: "int", nullable: true),
                    TotalQuantity = table.Column<int>(type: "int", nullable: false),
                    DiscountPrice = table.Column<double>(type: "float", nullable: false),
                    OrderTotal = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Payment = table.Column<int>(type: "int", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CancelDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_Vouchers_VoucherId",
                        column: x => x.VoucherId,
                        principalTable: "Vouchers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Product_Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Images_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product_SKUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SKU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RAM_ROM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefaultPrice = table.Column<double>(type: "float", nullable: false),
                    DiscountPercentage = table.Column<double>(type: "float", nullable: false),
                    FinalPrice = table.Column<double>(type: "float", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Sold = table.Column<int>(type: "int", nullable: false),
                    Default = table.Column<bool>(type: "bit", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_SKUs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_SKUs_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WishLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WishLists_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WishLists_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cart_Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    Product_SKUId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    IsSelected = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cart_Items_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cart_Items_Product_SKUs_Product_SKUId",
                        column: x => x.Product_SKUId,
                        principalTable: "Product_SKUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order_Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Product_SKUId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Items_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Items_Product_SKUs_Product_SKUId",
                        column: x => x.Product_SKUId,
                        principalTable: "Product_SKUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "DayCreate", "Description", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(167), "", "Apple" },
                    { 2, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(181), "", "Samsung" },
                    { 3, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(182), "", "Oppo" },
                    { 4, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(183), "", "Xiaomi" },
                    { 5, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(184), "", "Vivo" },
                    { 6, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(185), "", "Huawei" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Accessories", "Battery", "BrandId", "Charger", "Chip", "DayCreate", "DayUpdate", "Description", "Display", "FrontCamera", "IsAvailable", "LxWxHxW", "Name", "Quality", "RearCamera", "Size", "Sold" },
                values: new object[,]
                {
                    { 1, "", "33 giờ", 1, "20W", "Apple A18 Pro 6 nhân", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(392), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(393), "", "OLED", "12 MP", true, "Dài 163 mm - Ngang 77.6 mm - Dày 8.25 mm - Nặng 227 g", "Iphone 16 Pro max", 10, "Chính 48 MP & Phụ 48 MP, 12 MP", "6.9\"", 0 },
                    { 2, "", "27 giờ", 1, "20W", "Apple A18 Pro 6 nhân", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(396), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(396), "", "OLED", "12 MP", true, "Dài 149.6 mm - Ngang 71.5 mm - Dày 8.25 mm - Nặng 199 g", "Iphone 16 Pro", 10, "Chính 48 MP & Phụ 48 MP, 12 MP", "6.3\"", 0 },
                    { 3, "", "22 giờ", 1, "20W", "Apple A18 6 nhân", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(399), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(399), "", "OLED", "12 MP", true, "Dài 147.6 mm - Ngang 71.6 mm - Dày 7.8 mm - Nặng 170 g", "Iphone 16", 10, "Chính 48 MP & Phụ 12 MP", "6.1\"", 0 },
                    { 4, "", "27 giờ", 1, "20W", "Apple A18 6 nhân", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(401), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(402), "", "OLED", "12 MP", true, "Dài 160.9 mm - Ngang 77.8 mm - Dày 7.8 mm - Nặng 199 g", "Iphone 16 Plus", 10, "Chính 48 MP & Phụ 48 MP, 12 MP", "6.7\"", 0 },
                    { 5, "", "4422 mAh", 1, "20W", "Apple A17 Pro 6 nhân", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(405), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(405), "", "OLED", "12 MP", true, "Dài 159.9 mm - Ngang 76.7 mm - Dày 8.25 mm - Nặng 221 g", "Iphone 15 Pro max", 10, "Chính 48 MP & Phụ 48 MP, 12 MP", "6.7\"", 0 },
                    { 6, "", "4325 mAh", 1, "20W", "Apple A15 Bionic", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(407), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(408), "", "OLED", "12 MP", true, "Dài 160.8 mm - Ngang 78.1 mm - Dày 7.8 mm - Nặng 203 g", "Iphone 14 Plus", 10, "2 camera 12 MP", "6.7\"", 0 },
                    { 7, "", "3349 mAh", 1, "20W", "Apple A16 Bionic", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(410), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(410), "", "OLED", "12 MP", true, "Dài 147.6 mm - Ngang 71.6 mm - Dày 7.8 mm - Nặng 171 g", "Iphone 15", 10, "Chính 48 MP & Phụ 12 MP", "6.1\"", 0 },
                    { 8, "", "3279 mAh", 1, "20W", "Apple A15 Bionic", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(412), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(413), "", "OLED", "12 MP", true, "Dài 146.7 mm - Ngang 71.5 mm - Dày 7.8 mm - Nặng 172 g", "Iphone 14", 10, "2 camera 12 MP", "6.1\"", 0 },
                    { 9, "", "3240 mAh", 1, "20W", "Apple GPU 4 nhân ", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(415), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(415), "", "OLED", "12 MP", true, "Dài 146.7 mm - Ngang 71.5 mm - Dày 7.65 mm - Nặng 173 g", "Iphone 13", 10, "2 camera 12 MP", "6.1\"", 0 },
                    { 10, "", "2815 mAh", 1, "20W", "Apple A14 Bionic", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(441), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(441), "", "OLED", "12 MP", true, "Dài 146.7 mm - Ngang 71.5 mm - Dày 7.4 mm - Nặng 164 g", "Iphone 12", 10, "2 camera 12 MP", "6.1\"", 0 },
                    { 11, "", "4000 mAh", 2, "25W", "Qualcomm Snapdragon 8 Elite For Galaxy 8 nhân", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(443), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(444), "", "Dynamic AMOLED 2X", "12 MP", true, "Dài 146.9 mm - Ngang 70.5 mm - Dày 7.2 mm - Nặng 162 g", "Samsung Galaxy S25 5G", 10, "Chính 50 MP & Phụ 12 MP, 10 MP", "6.2\"", 0 },
                    { 12, "", "5000 mAh", 2, "45W", "Qualcomm Snapdragon 8 Elite For Galaxy 8 nhân", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(447), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(447), "", "Dynamic AMOLED 2X", "12 MP", true, "Dài 162.8 mm - Ngang 77.6 mm - Dày 8.2 mm - Nặng 218 g", "Samsung Galaxy S25 Ultra 5G", 10, "Chính 200 MP & Phụ 50 MP, 50 MP, 10 MP", "6.9\"", 0 },
                    { 13, "", "5000 mAh", 2, "45W", "Snapdragon 8 Gen 3 for Galaxy", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(449), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(450), "", "Dynamic AMOLED 2X", "12 MP", true, "Dài 162.3 mm - Ngang 79 mm - Dày 8.6 mm - Nặng 232 g", "Samsung Galaxy S24 Ultra 5G", 10, "Chính 200 MP & Phụ 50 MP, 12 MP, 10 MP", "6.8\"", 0 },
                    { 14, "", "5000 mAh", 2, "25W", "MediaTek Dimensity 6300 5G 8 nhân", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(452), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(452), "", "Super AMOLED", "13 MP", true, "Dài 164.4 mm - Ngang 77.9 mm - Dày 7.9 mm - Nặng 192 g", "Samsung Galaxy A16 5G", 10, "Chính 50 MP & Phụ 5 MP, 2 MP", "6.7\"", 0 },
                    { 15, "", "5000 mAh", 2, "25W", "MediaTek Helio G85", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(454), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(455), "", "PLS LCD", "8 MP", true, "Dài 167.3 mm - Ngang 77.3 mm - Dày 8 mm - Nặng 189 g", "Samsung Galaxy A06", 10, "Chính 50 MP & Phụ 2 MP", "6.7\"", 0 },
                    { 16, "", "4400 mAh", 2, "25W", "Snapdragon 8 Gen 3 for Galaxy", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(457), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(457), "", "Dynamic AMOLED 2X", "10 MP & 4 MP", true, "Dài 153.5 mm - Ngang 132.6 mm (khi mở) | 68.1 mm (khi gập) - Dày 5.6 mm (khi mở) | 12.1 mm (khi gập) - Nặng 239 g", "Samsung Galaxy Z Fold6 5G", 10, "Chính 50 MP & Phụ 12 MP, 10 MP", "Chính 7.6\" & Phụ 6.3\"", 0 },
                    { 17, "", "5000 mAh", 2, "25W", "Exynos 1380 8 nhân", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(460), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(460), "", "Super AMOLED", "13 MP", true, "Dài 161.7 mm - Ngang 78 mm - Dày 8.2 mm - Nặng 209 g", "Samsung Galaxy A35 5G", 10, "Chính 50 MP & Phụ 8 MP, 5 MP", "6.6\"", 0 },
                    { 18, "", "5000 mAh", 2, "25W", "Exynos 1280", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(462), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(462), "", "Super AMOLED", "13 MP", true, "Dài 161 mm - Ngang 76.5 mm - Dày 8.3 mm - Nặng 197 g", "Samsung Galaxy A25 5G", 10, "Chính 50 MP & Phụ 8 MP, 2 MP", "6.5\"", 0 },
                    { 19, "", "4900 mAh", 2, "45W", "Exynos 2400", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(465), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(465), "", "Dynamic AMOLED 2X", "12 MP", true, "Dài 158.5 mm - Ngang 75.9 mm - Dày 7.7 mm - Nặng 196 g", "Samsung Galaxy S24+ 5G", 10, "Chính 50 MP & Phụ 12 MP, 10 MP", "6.7\"", 0 },
                    { 20, "", "5000 mAh", 2, "25W", "Exynos 1480 8 nhân", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(468), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(468), "", "Super AMOLED", "32 MP", true, "Dài 161.1 mm - Ngang 77.4 mm - Dày 8.2 mm - Nặng 213 g", "Samsung Galaxy A55 5G", 10, "Chính 50 MP & Phụ 12 MP, 5 MP", "6.6\"", 0 },
                    { 21, "", "6000 mAh", 2, "25W", "MediaTek Dimensity 6100+", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(470), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(471), "", "Super AMOLED", "13 MP", true, "Dài 160.1 mm - Ngang 76.8 mm - Dày 9.3 mm - Nặng 217 g", "Samsung Galaxy M15 5G", 10, "Chính 50 MP & Phụ 5 MP, 2 MP", "6.5\"", 0 },
                    { 22, "", "5800 mAh", 3, "45W", "Snapdragon 6 Gen 1 5G 8 nhân", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(475), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(476), "", "AMOLED", "32 MP", true, "Dài 162.2 mm - Ngang 75.05 mm - Dày 7.76 mm - Nặng 192 g", "OPPO Reno13 F 5G", 10, "Chính 50 MP & Phụ 8 MP, 2 MP", "6.67\"", 0 },
                    { 23, "", "5600 mAh", 3, "80W", "MediaTek Dimensity 8350 5G 8 nhân", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(478), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(478), "", "AMOLED", "50 MP", true, "Dài 157.9 mm - Ngang 74.73 mm - Dày 7.24 mm - Nặng 181 g", "OPPO Reno13 5G", 10, "Chính 50 MP & Phụ 8 MP, 2 MP", "6.59\"", 0 },
                    { 24, "", "5800 mAh", 3, "80W", "MediaTek Dimensity 8350 5G 8 nhân", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(481), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(481), "", "AMOLED", "50 MP", true, "Dài 162.73 mm - Ngang 76.55 mm - Dày 7.55 mm - Nặng 195 g", "OPPO Reno13 Pro 5G", 10, "Chính 50 MP & Phụ 50 MP, 8 MP", "6.83\"", 0 },
                    { 25, "", "5800 mAh", 3, "45W", "MediaTek Helio G100 8 nhân", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(483), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(484), "", "AMOLED", "32 MP", true, "Dài 162.2 mm - Ngang 75.05 mm - Dày 7.76 mm - Nặng 192 g", "OPPO Reno13 F", 10, "Chính 50 MP & Phụ 8 MP, 2 MP", "6.67\"", 0 },
                    { 26, "", "5000 mAh", 3, "45 W", "Snapdragon 680", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(486), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(486), "", "IPS LCD", "8 MP", true, "Dài 165.71 mm - Ngang 76.02 mm - Dày 7.68 mm - Nặng 186 g", "OPPO A60", 10, "Chính 50 MP & Phụ 2 MP", "6.67\"", 0 },
                    { 27, "", "5000 mAh", 3, "45W", "Snapdragon 685 8 nhân", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(488), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(489), "", "AMOLED", "32 MP", true, "Dài 163.1 mm - Ngang 75.8 mm - Dày 7.69 mm - Nặng 187 g", "OPPO Reno12 F", 10, "Chính 50 MP & Phụ 8 MP, 2 MP", "6.67\"", 0 },
                    { 28, "", "5500 mAh", 4, "33W", "MediaTek Helio G99-Ultra 8 nhân", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(492), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(492), "", "AMOLED", "20 MP", true, "Dài 163.25 mm - Ngang 76.55 mm - Dày 8.16 mm - Nặng 196.5 g", "Xiaomi Redmi Note 14", 10, "Chính 108 MP & Phụ 2 MP, 2 MP", "6.67\"", 0 },
                    { 29, "", "5500 mAh", 4, "45W", "MediaTek Helio G100-Ultra 8 nhân", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(494), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(495), "", "AMOLED", "32 MP", true, "Dài 162.16 mm - Ngang 74.92 mm - Dày 8.24 mm - Nặng 180 g", "Xiaomi Redmi Note 14 Pro", 10, "Chính 200 MP & Phụ 8 MP, 2 MP", "6.67\"", 0 },
                    { 30, "", "5110 mAh", 4, "45W", "MediaTek Dimensity 7300-Ultra 8 nhân", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(497), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(497), "", "AMOLED", "20 MP", true, "Dài 162.33 mm - Ngang 74.42 mm - Dày 8.4 mm - Nặng 190 g", "Xiaomi Redmi Note 14 Pro 5G", 10, "Chính 200 MP & Phụ 8 MP, 2 MP", "6.67\"", 0 },
                    { 31, "", "5110 mAh", 4, "120 W", "Snapdragon 7s Gen 3 5G 8 nhân", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(499), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(500), "", "AMOLED", "20 MP", true, "Dài 162.53 mm - Ngang 74.67 mm - Dày 8.75 mm - Nặng 210.14g", "Xiaomi Redmi Note 14 Pro+ 5G", 10, "Chính 200 MP & Phụ 8 MP, 2 MP", "6.67\"", 0 },
                    { 32, "", "5030 mAh", 4, "33W", "MediaTek Helio G91 Ultra 8 nhân", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(502), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(502), "", "IPS LCD", "13 MP", true, "Dài 168.6 mm - Ngang 76.28 mm - Dày 8.3 mm - Nặng 205 g", "Xiaomi Redmi 13", 10, "Chính 108 MP & Phụ 2 MP", "6.79\"", 0 },
                    { 33, "", "5160 mAh", 4, "18W", "MediaTek Helio G81-Ultra 8 nhân", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(504), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(505), "", "IPS LCD", "13 MP", true, "Dài 171.88 mm - Ngang 77.8 mm - Dày 8.22 mm - Nặng 207 g", "Xiaomi Redmi 14C", 10, "Chính 50 MP & Phụ QVGA", "6.88\"", 0 },
                    { 34, "", "5000 mAh", 4, "67W", "MediaTek Dimensity 8300 Ultra 8 nhân", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(507), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(507), "", "AMOLED", "32 MP", true, "Dài 160.5 mm - Ngang 75.1 mm - Dày 7.8 mm - Nặng 195 g", "Xiaomi 14T 5G", 10, "Chính 50 MP & Phụ 50 MP, 12 MP", "6.67\"", 0 },
                    { 35, "", "5000 mAh", 5, "80W", "Snapdragon 685 8 nhân", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(516), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(516), "", "AMOLED", "32 MP", true, "Dài 163.23 mm - Ngang 75.93 mm - Dày 7.79 mm - Nặng 188g", "vivo V40 Lite", 10, "Chính 50 MP & Phụ 2 MP", "6.67\"", 0 },
                    { 36, "", "6000 mAh", 5, "44W", "MediaTek Helio G85", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(518), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(519), "", "IPS LCD", "8 MP", true, "Dài 165.7 mm - Ngang 76 mm - Dày 7.99 mm - Nặng 199 g", "vivo Y28", 10, "Chính 50 MP & Phụ 2 MP", "6.68\"", 0 },
                    { 37, "", "5500 mAh", 5, "80W", "Snapdragon 7 Gen 3 8 nhân", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(521), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(521), "", "AMOLED", "50 MP", true, "Dài 164.16 mm - Ngang 74.93 mm - Dày 7.58 mm - Nặng 190 g", "vivo V40 5G", 10, "2 camera 50 MP", "6.78\"", 0 },
                    { 38, "", "5500 mAh", 5, "15W", "Unisoc Tiger T612", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(523), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(524), "", "IPS LCD", "5 MP", true, "Dài 165.75 mm - Ngang 76.1 mm - Dày 8.1 mm - Nặng 198 g", "vivo Y19s", 10, "Chính 50 MP & Phụ 0.08 MP", "6.68\"", 0 },
                    { 39, "", "5500 mAh", 5, "44 W", "Snapdragon 6 Gen 1 8 nhân", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(526), new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(526), "", "AMOLED", "32 MP", true, "Dài 164.36 mm - Ngang 74.75 mm - Dày 7.75 mm - Nặng 188 g", "vivo V30e 5G", 10, "Chính 50 MP & Phụ 8 MP", "6.78\"", 0 }
                });

            migrationBuilder.InsertData(
                table: "Product_SKUs",
                columns: new[] { "Id", "Color", "CreatedAt", "Default", "DefaultPrice", "DiscountPercentage", "FinalPrice", "ImageName", "IsAvailable", "LastUpdatedAt", "ProductId", "Quantity", "RAM_ROM", "SKU", "Sold" },
                values: new object[,]
                {
                    { 1, "Titan sa mạc", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(584), false, 37000000.0, 0.0, 34999000.0, "iphone-16-pro-titan-sa-mac", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(586), 1, 30, "128GB", "IP16PM-128-XANH", 0 },
                    { 2, "Titan trắng", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(588), false, 37000000.0, 0.0, 34999000.0, "iphone-16-pro-titan-trang", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(588), 1, 50, "128GB", "IP16PM-128-TRANG", 0 },
                    { 3, "Titan đen", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(590), false, 37000000.0, 0.0, 34999000.0, "iphone-16-pro-titan-den", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(591), 1, 20, "128GB", "IP16PM-128-DEN", 0 },
                    { 4, "Titan tự nhiên", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(592), false, 37000000.0, 0.0, 34999000.0, "iphone-16-pro-titan-tu-nhien", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(593), 1, 40, "128GB", "IP16PM-64-XANH", 0 },
                    { 5, "Titan sa mạc", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(594), false, 40000000.0, 0.0, 37999000.0, "iphone-16-pro-titan-sa-mac", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(595), 1, 30, "256GB", "IP16PM-128-XANH", 0 },
                    { 6, "Titan trắng", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(596), false, 40000000.0, 0.0, 37999000.0, "iphone-16-pro-titan-trang", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(597), 1, 50, "256GB", "IP16PM-128-TRANG", 0 },
                    { 7, "Titan đen", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(599), false, 40000000.0, 0.0, 37999000.0, "iphone-16-pro-titan-den", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(599), 1, 20, "256GB", "IP16PM-128-DEN", 0 },
                    { 8, "Titan tự nhiên", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(601), false, 40000000.0, 0.0, 37999000.0, "iphone-16-pro-titan-tu-nhien", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(601), 1, 40, "256GB", "IP16PM-64-XANH", 0 },
                    { 9, "Titan sa mạc", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(603), false, 45000000.0, 0.0, 42999000.0, "iphone-16-pro-titan-sa-mac", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(603), 1, 30, "512GB", "IP16PM-128-XANH", 0 },
                    { 10, "Titan trắng", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(605), false, 45000000.0, 0.0, 42999000.0, "iphone-16-pro-titan-trang", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(605), 1, 50, "512GB", "IP16PM-128-TRANG", 0 },
                    { 11, "Titan đen", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(607), false, 45000000.0, 0.0, 42999000.0, "iphone-16-pro-titan-den", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(607), 1, 20, "512GB", "IP16PM-128-DEN", 0 },
                    { 12, "Titan tự nhiên", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(609), false, 45000000.0, 0.0, 42999000.0, "iphone-16-pro-titan-tu-nhien", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(609), 1, 40, "512GB", "IP16PM-64-XANH", 0 },
                    { 13, "Titan trắng", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(611), false, 30000000.0, 0.0, 28999000.0, "iphone-16-pro-titan-trang", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(612), 2, 60, "128GB", "IP16P-128-TRANG", 0 },
                    { 14, "Titan đen", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(659), false, 30000000.0, 0.0, 28999000.0, "iphone-16-pro-titan-den", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(660), 2, 30, "128GB", "IP16P-256-DEN", 0 },
                    { 15, "Titan tự nhiên", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(661), false, 30000000.0, 0.0, 28999000.0, "iphone-16-pro-titan-tu-nhien", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(662), 2, 50, "128GB", "IP16P-128-TRANG", 0 },
                    { 16, "Titan sa mạc", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(663), false, 30000000.0, 0.0, 28999000.0, "iphone-16-pro-titan-sa-mac", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(664), 2, 30, "128GB", "IP16P-256-XANH", 0 },
                    { 17, "Titan trắng", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(666), false, 35000000.0, 0.0, 33499000.0, "iphone-16-pro-titan-trang", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(666), 2, 60, "256GB", "IP16P-128-TRANG", 0 },
                    { 18, "Titan đen", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(668), false, 35000000.0, 0.0, 33499000.0, "iphone-16-pro-titan-den", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(668), 2, 30, "256GB", "IP16P-256-DEN", 0 },
                    { 19, "Titan tự nhiên", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(670), false, 35000000.0, 0.0, 33999000.0, "iphone-16-pro-titan-tu-nhien", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(670), 2, 50, "256GB", "IP16P-128-TRANG", 0 },
                    { 20, "Titan sa mạc", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(672), false, 35000000.0, 0.0, 33999000.0, "iphone-16-pro-titan-sa-mac", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(672), 2, 30, "256GB", "IP16P-256-XANH", 0 },
                    { 21, "Đen", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(675), false, 22999000.0, 0.0, 21599000.0, "iphone-16-den", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(675), 3, 20, "128GB", "IP16P-512-DEN", 0 },
                    { 22, "Trắng", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(677), false, 22999000.0, 0.0, 21599000.0, "iphone-16-trang", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(677), 3, 30, "128GB", "IP16P-512-DEN", 0 },
                    { 23, "Hồng", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(679), false, 22999000.0, 0.0, 21599000.0, "iphone-16-hong", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(679), 3, 25, "128GB", "IP16P-512-DEN", 0 },
                    { 24, "Xanh mòng két", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(687), false, 22999000.0, 0.0, 21999000.0, "iphone-16-xanh-mong-ket", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(694), 3, 25, "128GB", "IP16P-512-DEN", 0 },
                    { 25, "Xanh lưu ly", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(696), false, 22999000.0, 0.0, 21999000.0, "iphone-16-xanh-luu-ly", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(697), 3, 20, "128GB", "IP16P-512-DEN", 0 },
                    { 26, "Đen", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(699), false, 24999000.0, 0.0, 24999000.0, "iphone-16-den", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(699), 3, 20, "256GB", "IP16P-512-DEN", 0 },
                    { 27, "Trắng", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(702), false, 24999000.0, 0.0, 24999000.0, "iphone-16-trang", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(703), 3, 30, "256GB", "IP16P-512-DEN", 0 },
                    { 28, "Hồng", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(705), false, 24999000.0, 0.0, 24999000.0, "iphone-16-hong", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(706), 3, 25, "256GB", "IP16P-512-DEN", 0 },
                    { 29, "Xanh mòng két", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(709), false, 24999000.0, 0.0, 24999000.0, "iphone-16-xanh-mong-ket", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(709), 3, 25, "256GB", "IP16P-512-DEN", 0 },
                    { 30, "Xanh lưu ly", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(711), false, 24999000.0, 0.0, 24999000.0, "iphone-16-xanh-luu-ly", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(711), 3, 20, "256GB", "IP16P-512-DEN", 0 },
                    { 31, "Đen", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(713), false, 24999000.0, 0.0, 24999000.0, "iphone-16-den", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(713), 4, 20, "128GB", "IP16P-512-DEN", 0 },
                    { 32, "Trắng", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(716), false, 24999000.0, 0.0, 24999000.0, "iphone-16-trang", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(717), 4, 30, "128GB", "IP16P-512-DEN", 0 },
                    { 33, "Hồng", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(718), false, 24999000.0, 0.0, 24999000.0, "iphone-16-hong", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(719), 4, 25, "128GB", "IP16P-512-DEN", 0 },
                    { 34, "Xanh mòng két", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(721), false, 24999000.0, 0.0, 24999000.0, "iphone-16-xanh-mong-ket", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(722), 4, 25, "128GB", "IP16P-512-DEN", 0 },
                    { 35, "Xanh lưu ly", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(726), false, 24999000.0, 0.0, 24999000.0, "iphone-16-xanh-luu-ly", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(727), 4, 20, "128GB", "IP16P-512-DEN", 0 },
                    { 36, "Đen", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(731), false, 27999000.0, 0.0, 27999000.0, "iphone-16-den", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(732), 4, 20, "256GB", "IP16P-512-DEN", 0 },
                    { 37, "Trắng", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(733), false, 27999000.0, 0.0, 27999000.0, "iphone-16-trang", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(734), 4, 30, "256GB", "IP16P-512-DEN", 0 },
                    { 38, "Hồng", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(735), false, 27999000.0, 0.0, 27999000.0, "iphone-16-hong", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(736), 4, 25, "256GB", "IP16P-512-DEN", 0 },
                    { 39, "Xanh mòng két", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(737), false, 27999000.0, 0.0, 27999000.0, "iphone-16-xanh-mong-ket", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(738), 4, 25, "256GB", "IP16P-512-DEN", 0 },
                    { 40, "Xanh lưu ly", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(740), false, 27999000.0, 0.0, 27999000.0, "iphone-16-xanh-luu-ly", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(740), 4, 20, "256GB", "IP16P-512-DEN", 0 },
                    { 41, "Titan Trắng", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(742), true, 29999000.0, 0.0, 27999000.0, "iphone15-pro-max-512gb-titan-trang", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(742), 5, 4, "256GB", "IP16PL-128-TRANG", 0 },
                    { 42, "Titan tự nhiên", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(744), false, 29999000.0, 0.0, 27999000.0, "iphone-15-pro-max_5", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(744), 5, 3, "256GB", "IP16PL-256-XANH", 0 },
                    { 43, "Titan Đen", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(746), false, 29999000.0, 0.0, 27999000.0, "iphone15-pro-max-512gb-titan-den", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(746), 5, 2, "256GB", "IP16PL-512-DEN", 0 },
                    { 44, "Titan Trắng", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(749), true, 32999000.0, 0.0, 30999000.0, "iphone15-pro-max-512gb-titan-trang", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(749), 5, 4, "512GB", "IP16PL-128-TRANG", 0 },
                    { 45, "Titan tự nhiên", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(751), false, 32999000.0, 0.0, 30999000.0, "iphone-15-pro-max_5", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(751), 5, 3, "512GB", "IP16PL-256-XANH", 0 },
                    { 46, "Titan Đen", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(753), false, 32999000.0, 0.0, 30999000.0, "iphone15-pro-max-512gb-titan-den", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(753), 5, 2, "512GB", "IP16PL-512-DEN", 0 },
                    { 47, "Đỏ", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(755), true, 24999000.0, 0.0, 19999000.0, "iphone-14-plus-do", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(755), 6, 5, "128GB", "IP15PM-128-TRANG", 0 },
                    { 48, "Xanh", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(757), false, 24999000.0, 0.0, 19999000.0, "iphone-14-plus-xanh", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(758), 6, 3, "128GB", "IP15PM-256-XANH", 0 },
                    { 49, "Tím", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(759), false, 24999000.0, 0.0, 19999000.0, "iphone-14-plus-tim", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(760), 6, 0, "128GB", "IP15PM-512-DEN", 0 },
                    { 50, "Đỏ", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(761), true, 27999000.0, 0.0, 21599000.0, "iphone-14-plus-do", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(762), 6, 5, "256GB", "IP15PM-128-TRANG", 0 },
                    { 51, "Xanh", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(763), false, 27999000.0, 0.0, 21599000.0, "iphone-14-plus-xanh", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(764), 6, 0, "256GB", "IP15PM-256-XANH", 0 },
                    { 52, "Tím", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(765), false, 27999000.0, 0.0, 21799000.0, "iphone-14-plus-tim", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(766), 6, 2, "256GB", "IP15PM-512-DEN", 0 },
                    { 53, "Hồng", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(768), true, 2299000.0, 0.0, 18999000.0, "iphone-15-hong", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(768), 7, 5, "256GB", "IP15-128-TRANG", 0 },
                    { 54, "Xanh dương", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(774), false, 22999000.0, 0.0, 18999000.0, "iphone-15-128gb-xanh-duong", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(774), 7, 3, "256GB", "IP15-256-XANH", 0 },
                    { 55, "Xanh lá", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(776), false, 22999000.0, 0.0, 18999000.0, "iphone-15-128gb-xanh-la", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(776), 7, 2, "256GB", "IP15-512-DEN", 0 },
                    { 56, "Hồng", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(779), true, 24999000.0, 0.0, 20999000.0, "iphone-15-hong", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(779), 7, 5, "512GB", "IP15-128-TRANG", 0 },
                    { 57, "Xanh dương", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(781), false, 24999000.0, 0.0, 20999000.0, "iphone-15-128gb-xanh-duong", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(781), 7, 3, "512GB", "IP15-256-XANH", 0 },
                    { 58, "Xanh lá", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(783), false, 24999000.0, 0.0, 20999000.0, "iphone-15-128gb-xanh-la", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(783), 7, 0, "512GB", "IP15-512-DEN", 0 },
                    { 59, "Trắng", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(785), true, 20999000.0, 0.0, 14999000.0, "iphone-13-trang", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(785), 9, 5, "128GB", "IP13-128-TRANG", 0 },
                    { 60, "Xanh", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(787), false, 20999000.0, 0.0, 14999000.0, "iphone-13-xanh", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(787), 9, 3, "128GB", "IP13-256-XANH", 0 },
                    { 61, "Đen", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(789), false, 20999000.0, 0.0, 14599000.0, "iphone-13-den", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(789), 9, 2, "128GB", "IP13-512-DEN", 0 },
                    { 62, "Hồng", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(791), false, 20999000.0, 0.0, 15599000.0, "iphone-13-hong", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(791), 9, 2, "128GB", "IP13-512-DEN", 0 },
                    { 63, "Trắng", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(793), true, 22999000.0, 0.0, 16999000.0, "iphone-13-trang", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(794), 9, 5, "256GB", "IP13-128-TRANG", 0 },
                    { 64, "Xanh", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(796), false, 22999000.0, 0.0, 16999000.0, "iphone-13-xanh", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(797), 9, 3, "256GB", "IP13-256-XANH", 0 },
                    { 65, "Đen", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(798), false, 22999000.0, 0.0, 16999000.0, "iphone-13-den", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(799), 9, 2, "256GB", "IP13-512-DEN", 0 },
                    { 66, "Hồng", new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(800), false, 22999000.0, 0.0, 16999000.0, "iphone-13-hong", true, new DateTime(2025, 2, 27, 0, 4, 22, 74, DateTimeKind.Local).AddTicks(801), 9, 0, "256GB", "IP13-512-DEN", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_Items_CartId",
                table: "Cart_Items",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_Items_Product_SKUId",
                table: "Cart_Items",
                column: "Product_SKUId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Items_OrderId",
                table: "Order_Items",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Items_Product_SKUId",
                table: "Order_Items",
                column: "Product_SKUId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_VoucherId",
                table: "Orders",
                column: "VoucherId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Images_ProductId",
                table: "Product_Images",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SKUs_ProductId",
                table: "Product_SKUs",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WishLists_ProductId",
                table: "WishLists",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_WishLists_UserId",
                table: "WishLists",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Cart_Items");

            migrationBuilder.DropTable(
                name: "Order_Items");

            migrationBuilder.DropTable(
                name: "Product_Images");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "WishLists");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Product_SKUs");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Vouchers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
