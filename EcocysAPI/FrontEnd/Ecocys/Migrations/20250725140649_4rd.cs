using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecocys.Migrations
{
    /// <inheritdoc />
    public partial class _4rd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Success",
                table: "ContactForms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Success",
                table: "ContactForms");
        }
    }
}
