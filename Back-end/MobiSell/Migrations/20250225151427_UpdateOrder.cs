using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MobiSell.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "payment",
                table: "Orders",
                newName: "Payment");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CancelDate",
                table: "Orders",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "DayCreate",
                value: new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "DayCreate",
                value: new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "DayCreate",
                value: new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "DayCreate",
                value: new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "DayCreate",
                value: new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "DayCreate",
                value: new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2970), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2973), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2973) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2975), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2979) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2980), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2983), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2985), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2986) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2987), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2990), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2990) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2992), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2992) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2994), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2996), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2997) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2998), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2999) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(3000), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(3001) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(3003), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(3005), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(3008), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(3008) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(3010), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(3011) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(3012), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(3015), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(3015) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(3017), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(3017) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DayCreate", "DayUpdate" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2864), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2864) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DayCreate", "DayUpdate" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2868), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2869) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DayCreate", "DayUpdate" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2872), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DayCreate", "DayUpdate" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2874), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2875) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DayCreate", "DayUpdate" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2880), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2881) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DayCreate", "DayUpdate" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2906), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2907) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DayCreate", "DayUpdate" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2909), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2909) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DayCreate", "DayUpdate" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2912), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DayCreate", "DayUpdate" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2914), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2915) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DayCreate", "DayUpdate" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2917), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2917) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DayCreate", "DayUpdate" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2920), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DayCreate", "DayUpdate" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2923), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DayCreate", "DayUpdate" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2926), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2927) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DayCreate", "DayUpdate" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2929), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2929) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DayCreate", "DayUpdate" },
                values: new object[] { new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2931), new DateTime(2025, 2, 25, 22, 14, 27, 103, DateTimeKind.Local).AddTicks(2932) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "Payment",
                table: "Orders",
                newName: "payment");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CancelDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "DayCreate",
                value: new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "DayCreate",
                value: new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "DayCreate",
                value: new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "DayCreate",
                value: new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "DayCreate",
                value: new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "DayCreate",
                value: new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9112), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9118) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9121), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9121) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9123), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9126), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9128), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9130) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9131), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9134), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9134) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9136), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9137) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9138), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9139) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9141), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9143), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9144) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9145), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9147), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9185), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9185) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9187), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9187) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9189), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9192), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9192) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9194), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9196), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9196) });

            migrationBuilder.UpdateData(
                table: "Product_SKUs",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9198), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9199) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DayCreate", "DayUpdate" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9027), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DayCreate", "DayUpdate" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9031), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DayCreate", "DayUpdate" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9034), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9035) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DayCreate", "DayUpdate" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9040), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DayCreate", "DayUpdate" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9043), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DayCreate", "DayUpdate" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9046), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9047) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DayCreate", "DayUpdate" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9049), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DayCreate", "DayUpdate" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9052), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DayCreate", "DayUpdate" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9055), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9056) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DayCreate", "DayUpdate" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9058), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DayCreate", "DayUpdate" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9061), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9062) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DayCreate", "DayUpdate" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9065), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9065) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DayCreate", "DayUpdate" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9068), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9068) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DayCreate", "DayUpdate" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9070), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9071) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DayCreate", "DayUpdate" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9074), new DateTime(2025, 2, 20, 23, 38, 1, 820, DateTimeKind.Local).AddTicks(9074) });
        }
    }
}
