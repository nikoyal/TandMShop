using Microsoft.EntityFrameworkCore.Migrations;

namespace TandMShop.Data.Migrations
{
    public partial class FixBedSetsPicutre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Picutre1",
                table: "BedSets",
                newName: "Picture1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Picture1",
                table: "BedSets",
                newName: "Picutre1");
        }
    }
}
