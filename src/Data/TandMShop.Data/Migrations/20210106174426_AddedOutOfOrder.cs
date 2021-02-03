using Microsoft.EntityFrameworkCore.Migrations;

namespace TandMShop.Data.Migrations
{
    public partial class AddedOutOfOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "OutOfStock",
                table: "BedSets",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OutOfStock",
                table: "BedSets");
        }
    }
}
