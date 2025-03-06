using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MobiSell.Migrations
{
    /// <inheritdoc />
    public partial class UpReview : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Classify",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsRate",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Classify",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "IsRate",
                table: "Orders");
        }
    }
}
