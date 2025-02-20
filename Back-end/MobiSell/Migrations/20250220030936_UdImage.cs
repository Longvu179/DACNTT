using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MobiSell.Migrations
{
    /// <inheritdoc />
    public partial class UdImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Product_SKUs",
                newName: "ImageName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageName",
                table: "Product_SKUs",
                newName: "Image");
        }
    }
}
