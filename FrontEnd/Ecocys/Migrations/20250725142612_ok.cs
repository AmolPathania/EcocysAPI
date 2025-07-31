using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecocys.Migrations
{
    /// <inheritdoc />
    public partial class ok : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Success",
                table: "ContactForms");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Success",
                table: "ContactForms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
