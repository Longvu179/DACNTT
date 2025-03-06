using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MobiSell.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product_Images",
                columns: new[] { "Id", "CreatedAt", "ImageName", "IsMain", "ProductId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "iphone-16-pro-titan-tu-nhien.png", true, 1 },
                    { 2, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "iphone-16-pro-titan-sa-mac.png", true, 2 },
                    { 3, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "iphone-16-xanh-mong-ket.png", true, 3 },
                    { 4, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "iphone-16-trang.png", true, 4 },
                    { 5, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "iphone-15-pro-max_5.png", true, 5 },
                    { 6, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "iphone-14-plus-tim.png", true, 6 },
                    { 7, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "iphone-15-hong.png", true, 7 },
                    { 8, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "iphone-14-vang.png", true, 8 },
                    { 9, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "iphone-13-xanh.png", true, 9 },
                    { 10, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "iphone-12-tim.png", true, 10 },
                    { 11, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "dien-thoai-samsung-galaxy-s25_3.png", true, 11 },
                    { 12, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "dien-thoai-samsung-galaxy-s25-ultra_1.png", true, 12 },
                    { 13, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "ss-s24-ultra-vang-222.png", true, 13 },
                    { 14, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "samsung-a16-5g_1.png", true, 14 },
                    { 15, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "dien-thoai-samsung-galaxy-a06.png", true, 15 },
                    { 16, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "samsung-galaxy-z-fold6-thumb.png", true, 16 },
                    { 17, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "sm-a356_galaxy_a35_awesome_iceblue_ui.png", true, 17 },
                    { 18, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "galaxy-a25-xanh-duongnhat.png", true, 18 },
                    { 19, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "galaxy-s24-plus-vang.png", true, 19 },
                    { 20, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "sm-a556_galaxy_a55_awesome_lilac_ui.png", true, 20 },
                    { 21, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "ss-m15-xanhduong.png", true, 21 },
                    { 22, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "dien-thoai-oppo-reno13-f-5g-hinh-2.png", true, 22 },
                    { 23, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "oppo-reno13-5g-thumb.png", true, 23 },
                    { 24, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "oppo-reno13-pro-5g-grey-thumb.png", true, 24 },
                    { 25, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "oppo-reno13-f-thumb.png", true, 25 },
                    { 26, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "dien-thoai-oppo-a60.png", true, 26 },
                    { 27, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "oppo-reno-12f-cam.png", true, 27 },
                    { 28, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "dien-thoai-xiaomi-redmi-note-14_2.png", true, 28 },
                    { 29, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "xiaomi-redmi-note-14-pro-thumb.png", true, 29 },
                    { 30, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "xiaomi-redmi-note-14-pro-5g-xanh-thumb.png", true, 30 },
                    { 31, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "dien-thoai-xiaomi-redmi-note-14-pro-plus-den.png", true, 31 },
                    { 32, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "redmi-13-blue-thumb.png", true, 32 },
                    { 33, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "redmi_14c_xanhduong.png", true, 33 },
                    { 34, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "xiaomi_14t_xam.png", true, 34 },
                    { 35, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "vivo-v40lite-hong.png", true, 35 },
                    { 36, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "vivo-y28-chinh-hang-xanh.png", true, 36 },
                    { 37, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "vivo-v40-tim.png", true, 37 },
                    { 38, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "dien-thoai-vivo-y19s-den.png", true, 38 },
                    { 39, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "dien-thoai-vivo-v30e-nau.png", true, 39 }
                });

            migrationBuilder.InsertData(
                table: "Product_SKUs",
                columns: new[] { "Id", "Color", "CreatedAt", "Default", "DefaultPrice", "DiscountPercentage", "FinalPrice", "ImageName", "IsAvailable", "LastUpdatedAt", "ProductId", "Quantity", "RAM_ROM", "SKU", "Sold" },
                values: new object[,]
                {
                    { 67, "Xám", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 22999000.0, 0.0, 19999000.0, "dien-thoai-samsung-galaxy-s25_4.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 25, "256GB", "GS-25-TRANG", 0 },
                    { 68, "Trắng", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 22999000.0, 0.0, 19999000.0, "dien-thoai-samsung-galaxy-s25_3.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 25, "256GB", "GS-25-TRANG", 0 },
                    { 69, "Xanh lá", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 22999000.0, 0.0, 19999000.0, "dien-thoai-samsung-galaxy-s25_2.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 25, "256GB", "GS-25-TRANG", 0 },
                    { 70, "Xanh navy", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 22999000.0, 0.0, 19999000.0, "dien-thoai-samsung-galaxy-s25_1.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 25, "256GB", "GS-25-TRANG", 0 },
                    { 71, "Xám", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 26499000.0, 0.0, 23499000.0, "dien-thoai-samsung-galaxy-s25_4.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 25, "512GB", "GS-25-TRANG", 0 },
                    { 72, "Trắng", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 26499000.0, 0.0, 23499000.0, "dien-thoai-samsung-galaxy-s25_3.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 25, "512GB", "GS-25-TRANG", 0 },
                    { 73, "Xanh lá", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 26499000.0, 0.0, 23499000.0, "dien-thoai-samsung-galaxy-s25_2.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 25, "512GB", "GS-25-TRANG", 0 },
                    { 74, "Xanh navy", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 26499000.0, 0.0, 23499000.0, "dien-thoai-samsung-galaxy-s25_1.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 25, "512GB", "GS-25-TRANG", 0 },
                    { 75, "Trắng", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 33999000.0, 0.0, 30999000.0, "dien-thoai-samsung-galaxy-s25-ultra.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 25, "256GB", "GS-S25U-TRANG", 0 },
                    { 76, "Xanh", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 33999000.0, 0.0, 30999000.0, "dien-thoai-samsung-galaxy-s25-ultra_2.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 25, "256GB", "GS-S25U-TRANG", 0 },
                    { 77, "Xám", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 33999000.0, 0.0, 30999000.0, "dien-thoai-samsung-galaxy-s25-ultra_1.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 25, "256GB", "GS-S25U-TRANG", 0 },
                    { 78, "Đen", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 33999000.0, 0.0, 30999000.0, "dien-thoai-samsung-galaxy-s25-ultra_3.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 25, "256GB", "GS-S25U-TRANG", 0 },
                    { 79, "Trắng", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 37499000.0, 0.0, 34499000.0, "dien-thoai-samsung-galaxy-s25-ultra.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 25, "512GB", "GS-S25U-TRANG", 0 },
                    { 80, "Xanh", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 37499000.0, 0.0, 34499000.0, "dien-thoai-samsung-galaxy-s25-ultra_2.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 25, "512GB", "GS-S25U-TRANG", 0 },
                    { 81, "Xám", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 37499000.0, 0.0, 34499000.0, "dien-thoai-samsung-galaxy-s25-ultra_1.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 25, "512GB", "GS-S25U-TRANG", 0 },
                    { 82, "Đen", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 37499000.0, 0.0, 34499000.0, "dien-thoai-samsung-galaxy-s25-ultra_3.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 25, "512GB", "GS-S25U-TRANG", 0 },
                    { 83, "Xám", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 43999000.0, 0.0, 38999000.0, "zfold-6-xam.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 25, "256GB", "ZFOLD6-TRANG", 0 },
                    { 84, "Hồng", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 43999000.0, 0.0, 38999000.0, "zfold-6-hong.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 25, "256GB", "ZFOLD6-TRANG", 0 },
                    { 85, "Xanh", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 43999000.0, 0.0, 38999000.0, "zfold-6-xanh.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 25, "256GB", "ZFOLD6-TRANG", 0 },
                    { 86, "Xám", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 47999000.0, 0.0, 41999000.0, "zfold-6-xam.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 25, "512GB", "ZFOLD6-TRANG", 0 },
                    { 87, "Hồng", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 47999000.0, 0.0, 41999000.0, "zfold-6-hong.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 25, "512GB", "ZFOLD6-TRANG", 0 },
                    { 88, "Xanh", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 47999000.0, 0.0, 41999000.0, "zfold-6-xanh.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 25, "512GB", "ZFOLD6-TRANG", 0 },
                    { 89, "Tím", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10999000.0, 0.0, 9999000.0, "dien-thoai-oppo-reno13-f-5g-hinh-2.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 25, "256GB", "RENO-13F-TRANG", 0 },
                    { 90, "Xám", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10999000.0, 0.0, 9999000.0, "dien-thoai-oppo-reno13-f-5g-hinh-1.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 25, "256GB", "RENO-13F-TRANG", 0 },
                    { 91, "Tím", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11999000.0, 0.0, 11999000.0, "dien-thoai-oppo-reno13-f-5g-hinh-2.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 25, "512GB", "RENO-13F-TRANG", 0 },
                    { 92, "Xám", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11999000.0, 0.0, 11999000.0, "dien-thoai-oppo-reno13-f-5g-hinh-1.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 25, "512GB", "RENO-13F-TRANG", 0 },
                    { 93, "Xanh", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 5499000.0, 0.0, 5499000.0, "dien-thoai-oppo-a60.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 25, "128GB", "OPPO-A60-XANH", 0 },
                    { 94, "Tím", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 5499000.0, 0.0, 5499000.0, "dien-thoai-oppo-a60_1.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 25, "128GB", "OPPO-A60-XANH", 0 },
                    { 95, "Xanh", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 6499000.0, 0.0, 6099000.0, "dien-thoai-oppo-a60.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 25, "256GB", "OPPO-A60-XANH", 0 },
                    { 96, "Tím", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 6499000.0, 0.0, 6099000.0, "dien-thoai-oppo-a60_1.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 25, "256GB", "OPPO-A60-XANH", 0 },
                    { 97, "Xanh", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8999000.0, 0.0, 8099000.0, "oppo-reno-12f-xanh.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 25, "256GB", "OPPO-12F-XANH", 0 },
                    { 98, "Cam", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8999000.0, 0.0, 8099000.0, "oppo-reno-12f-cam.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 25, "256GB", "OPPO-12F-XANH", 0 },
                    { 99, "Đen", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 5699000.0, 0.0, 5699000.0, "dien-thoai-xiaomi-redmi-note-14.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 25, "128GB", "REDMI-NOTE-14", 0 },
                    { 100, "Xanh", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 5699000.0, 0.0, 5699000.0, "dien-thoai-xiaomi-redmi-note-14_2.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 25, "128GB", "REDMI-NOTE-14", 0 },
                    { 101, "Tím", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 5699000.0, 0.0, 5699000.0, "dien-thoai-xiaomi-redmi-note-14_3.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 25, "128GB", "REDMI-NOTE-14", 0 },
                    { 102, "Đen", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 6299000.0, 0.0, 6299000.0, "dien-thoai-xiaomi-redmi-note-14.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 25, "256GB", "REDMI-NOTE-14", 0 },
                    { 103, "Xanh", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 6299000.0, 0.0, 6299000.0, "dien-thoai-xiaomi-redmi-note-14_2.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 25, "256GB", "REDMI-NOTE-14", 0 },
                    { 104, "Tím", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 6299000.0, 0.0, 6299000.0, "dien-thoai-xiaomi-redmi-note-14_3.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 25, "256GB", "REDMI-NOTE-14", 0 },
                    { 105, "Tím", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10999000.0, 0.0, 10699000.0, "dien-thoai-xiaomi-redmi-note-14-pro-plus-tim.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 25, "256GB", "REDMI-NOTE-14PRO+", 0 },
                    { 106, "Đen", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10999000.0, 0.0, 10699000.0, "dien-thoai-xiaomi-redmi-note-14-pro-plus-den.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 25, "256GB", "REDMI-NOTE-14PRO+", 0 },
                    { 107, "Xanh", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10999000.0, 0.0, 10699000.0, "dien-thoai-xiaomi-redmi-note-14-pro-plus-xanh.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 25, "256GB", "REDMI-NOTE-14PRO+", 0 },
                    { 108, "Đen", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 12999000.0, 0.0, 11699000.0, "xiaomi_14t-den.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 25, "256GB", "REDMI-NOTE-14PRO+", 0 },
                    { 109, "Xam", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 12999000.0, 0.0, 11699000.0, "xiaomi_14t-xam.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 25, "256GB", "REDMI-NOTE-14PRO+", 0 },
                    { 110, "Xanh", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 12999000.0, 0.0, 11699000.0, "xiaomi_14t-xanh.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 25, "256GB", "REDMI-NOTE-14PRO+", 0 },
                    { 111, "Đen", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13999000.0, 0.0, 12599000.0, "xiaomi_14t-den.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 25, "512GB", "REDMI-NOTE-14PRO+", 0 },
                    { 112, "Xam", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13999000.0, 0.0, 12599000.0, "xiaomi_14t-xam.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 25, "512GB", "REDMI-NOTE-14PRO+", 0 },
                    { 113, "Xanh", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13999000.0, 0.0, 12599000.0, "xiaomi_14t-xanh.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 25, "512GB", "REDMI-NOTE-14PRO+", 0 },
                    { 114, "Xanh dương", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3499000.0, 0.0, 3099000.0, "redmi_14c_xanhduong.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 25, "4/128GB", "REDMI-14C", 0 },
                    { 115, "Xanh lá", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3499000.0, 0.0, 3099000.0, "redmi_14c_xanhla.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 25, "4/128GB", "REDMI-14C", 0 },
                    { 116, "Đen", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3499000.0, 0.0, 2999000.0, "redmi_14c_den.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 25, "4/128GB", "REDMI-14C", 0 },
                    { 117, "Xanh dương", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3999000.0, 0.0, 3599000.0, "redmi_14c_xanhduong.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 25, "6/128GB", "REDMI-14C", 0 },
                    { 118, "Xanh lá", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3999000.0, 0.0, 3599000.0, "redmi_14c_xanhla.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 25, "6/128GB", "REDMI-14C", 0 },
                    { 119, "Đen", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3999000.0, 0.0, 3499000.0, "redmi_14c_den.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 25, "6/128GB", "REDMI-14C", 0 },
                    { 120, "Xám", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8499000.0, 0.0, 8499000.0, "vivo-v40lite-xam.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 25, "256GB", "VIVO-V40-LITE", 0 },
                    { 121, "Tím", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8499000.0, 0.0, 8499000.0, "vivo-v40lite-tim.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 25, "256GB", "VIVO-V40-LITE", 0 },
                    { 122, "Hồng", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8499000.0, 0.0, 8499000.0, "vivo-v40lite-hong.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 25, "256GB", "VIVO-V40-LITE", 0 },
                    { 123, "Cam", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 5899000.0, 0.0, 5599000.0, "vivo-y28-chinh-hang-cam.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 25, "128GB", "VIVO-Y28", 0 },
                    { 124, "Xanh", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 5899000.0, 0.0, 5599000.0, "vivo-y28-chinh-hang-xanh.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 25, "128GB", "VIVO-Y28", 0 },
                    { 125, "Cam", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 6499000.0, 0.0, 6299000.0, "vivo-y28-chinh-hang-cam.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 25, "256GB", "VIVO-Y28", 0 },
                    { 126, "Xanh", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 6499000.0, 0.0, 6299000.0, "vivo-y28-chinh-hang-xanh.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 25, "256GB", "VIVO-Y28", 0 },
                    { 127, "Xanh", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 12999000.0, 0.0, 12599000.0, "vivo-v40-xanh.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, 25, "256GB", "VIVO-V40", 0 },
                    { 128, "Xám", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 12999000.0, 0.0, 12599000.0, "vivo-v40-xam.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, 25, "256GB", "VIVO-V40", 0 },
                    { 129, "Tím", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 12999000.0, 0.0, 12599000.0, "vivo-v40-tim.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, 25, "256GB", "VIVO-V40", 0 },
                    { 130, "Xanh", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13499000.0, 0.0, 12999000.0, "vivo-v40-xanh.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, 25, "512GB", "VIVO-V40", 0 },
                    { 131, "Xám", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13499000.0, 0.0, 12999000.0, "vivo-v40-xam.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, 25, "512GB", "VIVO-V40", 0 },
                    { 132, "Tím", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13499000.0, 0.0, 12999000.0, "vivo-v40-tim.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, 25, "512GB", "VIVO-V40", 0 },
                    { 133, "Đen", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 4499000.0, 0.0, 4499000.0, "dien-thoai-vivo-y19s-den.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 25, "6/128GB", "VIVO-Y19S", 0 },
                    { 134, "Xanh", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 4499000.0, 0.0, 4499000.0, "dien-thoai-vivo-y19s-xanh.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 25, "6/128GB", "VIVO-Y19S", 0 },
                    { 135, "Trắng", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 4499000.0, 0.0, 4499000.0, "dien-thoai-vivo-y19s-trang.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 25, "6/128GB", "VIVO-Y19S", 0 },
                    { 136, "Đen", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 4899000.0, 0.0, 4799000.0, "dien-thoai-vivo-y19s-den.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 25, "8/128GB", "VIVO-Y19S", 0 },
                    { 137, "Xanh", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 4899000.0, 0.0, 4799000.0, "dien-thoai-vivo-y19s-xanh.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 25, "8/128GB", "VIVO-Y19S", 0 },
                    { 138, "Trắng", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 4899000.0, 0.0, 4799000.0, "dien-thoai-vivo-y19s-trang.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 25, "8/128GB", "VIVO-Y19S", 0 },
                    { 139, "Trắng", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9499000.0, 0.0, 9499000.0, "dien-thoai-vivo-v30e-trang.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 25, "8/256GB", "VIVO-V30E", 0 },
                    { 140, "Nâu", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9499000.0, 0.0, 9499000.0, "dien-thoai-vivo-v30e-nau.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 25, "8/256GB", "VIVO-V30E", 0 },
                    { 141, "Trắng", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10499000.0, 0.0, 10199000.0, "dien-thoai-vivo-v30e-trang.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 25, "12/256GB", "VIVO-V30E", 0 },
                    { 142, "Nâu", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10499000.0, 0.0, 10199000.0, "dien-thoai-vivo-v30e-nau.png", true, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 25, "12/256GB", "VIVO-V30E", 0 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "Name",
                value: "Vivo V40 Lite");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "Name",
                value: "Vivo Y28");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "Name",
                value: "Vivo V40 5G");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "Name",
                value: "Vivo Y19s");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "Name",
                value: "Vivo V30e 5G");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Product_Images",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "Name",
                value: "vivo V40 Lite");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "Name",
                value: "vivo Y28");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "Name",
                value: "vivo V40 5G");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "Name",
                value: "vivo Y19s");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "Name",
                value: "vivo V30e 5G");
        }
    }
}
