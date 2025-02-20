﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MobiSell.Migrations
{
    /// <inheritdoc />
    public partial class NewItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSelected",
                table: "Cart_Items",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSelected",
                table: "Cart_Items");
        }
    }
}
