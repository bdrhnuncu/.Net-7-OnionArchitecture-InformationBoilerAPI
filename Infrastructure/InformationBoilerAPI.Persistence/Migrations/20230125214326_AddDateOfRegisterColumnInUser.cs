using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InformationBoilerAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddDateOfRegisterColumnInUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfRegister",
                table: "Users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfRegister",
                table: "Users");
        }
    }
}
