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
                    payment = table.Column<int>(type: "int", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CancelDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
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
                    { 1, new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(8772), "", "Apple" },
                    { 2, new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(8785), "", "Samsung" },
                    { 3, new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(8786), "", "Xiaomi" },
                    { 4, new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(8787), "", "Oppo" },
                    { 5, new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(8788), "", "Vivo" },
                    { 6, new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(8789), "", "Huawei" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Accessories", "Battery", "BrandId", "Charger", "Chip", "DayCreate", "DayUpdate", "Description", "Display", "FrontCamera", "IsAvailable", "LxWxHxW", "Name", "Quality", "RearCamera", "Size", "Sold" },
                values: new object[,]
                {
                    { 1, "", "33 giờ", 1, "20W", "Apple A18 Pro 6 nhân", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9027), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9028), "", "OLED", "12 MP", true, "Dài 163 mm - Ngang 77.6 mm - Dày 8.25 mm - Nặng 227 g", "Iphone 16 Pro max", 10, "Chính 48 MP & Phụ 48 MP, 12 MP", "6.9\"", 0 },
                    { 2, "", "22 giờ", 1, "20W", "Apple A18 6 nhân", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9031), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9032), "", "OLED", "12 MP", true, "Dài 147.6 mm - Ngang 71.6 mm - Dày 7.8 mm - Nặng 170 g", "Iphone 16 ", 10, "Chính 48 MP & Phụ 12 MP", "6.1\"", 0 },
                    { 3, "", "27 giờ", 1, "20W", "Apple A18 Pro 6 nhân", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9034), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9035), "", "OLED", "12 MP", true, "Dài 149.6 mm - Ngang 71.5 mm - Dày 8.25 mm - Nặng 199 g", "Iphone 16 Pro", 10, "Chính 48 MP & Phụ 48 MP, 12 MP", "6.3\"", 0 },
                    { 4, "", "5800 mAh", 4, "45W", "Snapdragon 6 Gen 1 5G 8 nhân", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9040), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9040), "", "AMOLED", "32 MP", true, "Dài 162.2 mm - Ngang 75.05 mm - Dày 7.76 mm - Nặng 192 g", "OPPO Reno13 F 5G", 10, "Chính 50 MP & Phụ 8 MP, 2 MP", "6.67\"", 0 },
                    { 5, "", "5600 mAh", 4, "80W", "MediaTek Dimensity 8350 5G 8 nhân", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9043), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9044), "", "AMOLED", "50 MP", true, "Dài 157.9 mm - Ngang 74.73 mm - Dày 7.24 mm - Nặng 181 g", "OPPO Reno13 5G", 10, "Chính 50 MP & Phụ 8 MP, 2 MP", "6.59\"", 0 },
                    { 6, "", "5800 mAh", 4, "80W", "MediaTek Dimensity 8350 5G 8 nhân", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9046), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9047), "", "AMOLED", "50 MP", true, "Dài 162.73 mm - Ngang 76.55 mm - Dày 7.55 mm - Nặng 195 g", "OPPO Reno13 Pro 5G", 10, "Chính 50 MP & Phụ 50 MP, 8 MP", "6.83\"", 0 },
                    { 7, "", "4000 mAh", 2, "25W", "Qualcomm Snapdragon 8 Elite For Galaxy 8 nhân", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9049), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9049), "", "Dynamic AMOLED 2X", "12 MP", true, "Dài 146.9 mm - Ngang 70.5 mm - Dày 7.2 mm - Nặng 162 g", "Samsung Galaxy S25 5G", 10, "Chính 50 MP & Phụ 12 MP, 10 MP", "6.2\"", 0 },
                    { 8, "", "5000 mAh", 2, "45W", "Qualcomm Snapdragon 8 Elite For Galaxy 8 nhân", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9052), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9052), "", "Dynamic AMOLED 2X", "12 MP", true, "Dài 162.8 mm - Ngang 77.6 mm - Dày 8.2 mm - Nặng 218 g", "Samsung Galaxy S25 Ultra 5G", 10, "Chính 200 MP & Phụ 50 MP, 50 MP, 10 MP", "6.9\"", 0 },
                    { 9, "", "5000 mAh", 2, "45W", "Snapdragon 8 Gen 3 for Galaxy", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9055), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9056), "", "Dynamic AMOLED 2X", "12 MP", true, "Dài 162.3 mm - Ngang 79 mm - Dày 8.6 mm - Nặng 232 g", "Samsung Galaxy S24 Ultra 5G", 10, "Chính 200 MP & Phụ 50 MP, 12 MP, 10 MP", "6.8\"", 0 },
                    { 10, "", "5500 mAh", 3, "33W", "MediaTek Helio G99-Ultra 8 nhân", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9058), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9059), "", "AMOLED", "20 MP", true, "Dài 163.25 mm - Ngang 76.55 mm - Dày 8.16 mm - Nặng 196.5 g", "Xiaomi Redmi Note 14", 10, "Chính 108 MP & Phụ 2 MP, 2 MP", "6.67\"", 0 },
                    { 11, "", "5500 mAh", 3, "45W", "MediaTek Helio G100-Ultra 8 nhân", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9061), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9062), "", "AMOLED", "32 MP", true, "Dài 162.16 mm - Ngang 74.92 mm - Dày 8.24 mm - Nặng 180 g", "Xiaomi Redmi Note 14 Pro", 10, "Chính 200 MP & Phụ 8 MP, 2 MP", "6.67\"", 0 },
                    { 12, "", "5110 mAh", 3, "45W", "MediaTek Dimensity 7300-Ultra 8 nhân", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9065), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9065), "", "AMOLED", "20 MP", true, "Dài 162.33 mm - Ngang 74.42 mm - Dày 8.4 mm - Nặng 190 g", "Xiaomi Redmi Note 14 Pro 5G", 10, "Chính 200 MP & Phụ 8 MP, 2 MP", "6.67\"", 0 },
                    { 13, "", "5000 mAh", 5, "44W", "Snapdragon 695 5G 8 nhân", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9068), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9068), "", "AMOLED", "50 MP", true, "Dài 162.35 mm - Ngang 74.85 mm - Dày 7.69 mm - Nặng 190 g", "Vivo V29e 5G", 10, "Chính 64 MP & Phụ 8 MP", "6.67\"", 0 },
                    { 14, "", "5000 mAh", 5, "80W", "Snapdragon 4 Gen 2 5G 8 nhân", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9070), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9071), "", "AMOLED", "8 MP", true, "Dài 163.17 mm - Ngang 75.81 mm - Dày 7.79 mm - Nặng 186 g", "Vivo Y100 5G", 10, "Chính 50 MP & Phụ 2 MP", "6.67\"", 0 },
                    { 15, "", "5000 mAh", 5, "15W", "MediaTek Helio G85 8 nhân", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9074), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9074), "", "AMOLED", "8 MP", true, "Dài 163.74 mm - Ngang 75.43 mm - Dày 8.09 mm - Nặng 186 g", "Vivo Y17s", 10, "Chính 50 MP & Phụ 2 MP", "6.56\"", 0 }
                });

            migrationBuilder.InsertData(
                table: "Product_SKUs",
                columns: new[] { "Id", "Color", "CreatedAt", "Default", "DefaultPrice", "DiscountPercentage", "FinalPrice", "ImageName", "IsAvailable", "LastUpdatedAt", "ProductId", "Quantity", "RAM_ROM", "SKU", "Sold" },
                values: new object[,]
                {
                    { 1, "Xanh", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9112), false, 35000000.0, 0.0, 34999000.0, "", true, new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9118), 1, 3, "64Gb", "sku", 0 },
                    { 2, "Đen", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9121), false, 34500000.0, 0.0, 34499000.0, "", true, new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9121), 1, 3, "64Gb", "sku", 0 },
                    { 3, "Xanh", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9123), false, 41000000.0, 0.0, 40999000.0, "", true, new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9124), 1, 3, "128Gb", "sku", 0 },
                    { 4, "Đen", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9126), false, 40000000.0, 0.0, 39999000.0, "", true, new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9126), 1, 3, "128Gb", "sku", 0 },
                    { 5, "Trắng", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9128), false, 40000000.0, 0.0, 39999000.0, "", true, new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9130), 1, 3, "128Gb", "sku", 0 },
                    { 6, "Đen", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9131), false, 25000000.0, 0.0, 24999000.0, "", true, new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9132), 2, 3, "64Gb", "sku", 0 },
                    { 7, "Trắng", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9134), false, 24500000.0, 0.0, 24499000.0, "", true, new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9134), 2, 3, "64Gb", "sku", 0 },
                    { 8, "Xanh", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9136), false, 25000000.0, 0.0, 24999000.0, "", true, new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9137), 2, 3, "64Gb", "sku", 0 },
                    { 9, "Xanh", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9138), false, 28000000.0, 0.0, 27999000.0, "", true, new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9139), 2, 3, "128Gb", "sku", 0 },
                    { 10, "Trắng", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9141), false, 28000000.0, 0.0, 27999000.0, "", true, new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9141), 2, 3, "128Gb", "sku", 0 },
                    { 11, "Đỏ", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9143), false, 10000000.0, 0.0, 10000000.0, "", true, new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9144), 3, 3, "64Gb", "sku", 0 },
                    { 12, "Trắng", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9145), false, 10000000.0, 0.0, 10000000.0, "", true, new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9146), 3, 3, "64Gb", "sku", 0 },
                    { 13, "Xanh", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9147), false, 10000000.0, 0.0, 10000000.0, "", true, new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9148), 3, 3, "64Gb", "sku", 0 },
                    { 14, "Đỏ", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9185), false, 10000000.0, 0.0, 10000000.0, "", true, new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9185), 3, 3, "128Gb", "sku", 0 },
                    { 15, "Trắng", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9187), false, 10000000.0, 0.0, 10000000.0, "", true, new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9187), 3, 3, "128Gb", "sku", 0 },
                    { 16, "Đen", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9189), false, 10000000.0, 0.0, 10000000.0, "", true, new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9190), 4, 3, "64Gb", "sku", 0 },
                    { 17, "Xanh", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9192), false, 10000000.0, 0.0, 10000000.0, "", true, new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9192), 4, 3, "64Gb", "sku", 0 },
                    { 18, "Trắng", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9194), false, 10000000.0, 0.0, 10000000.0, "", true, new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9194), 4, 3, "64Gb", "sku", 0 },
                    { 19, "Trắng", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9196), false, 10000000.0, 0.0, 10000000.0, "", true, new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9196), 4, 3, "128Gb", "sku", 0 },
                    { 20, "Đen", new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9198), false, 10000000.0, 0.0, 10000000.0, "", true, new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9199), 4, 3, "128Gb", "sku", 0 }
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
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");

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
