using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Migrations
{
    public partial class correctfields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Season",
                table: "Championship",
                newName: "PortalUrl");

            migrationBuilder.RenameColumn(
                name: "Place",
                table: "Championship",
                newName: "Initials");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PortalUrl",
                table: "Championship",
                newName: "Season");

            migrationBuilder.RenameColumn(
                name: "Initials",
                table: "Championship",
                newName: "Place");
        }
    }
}
