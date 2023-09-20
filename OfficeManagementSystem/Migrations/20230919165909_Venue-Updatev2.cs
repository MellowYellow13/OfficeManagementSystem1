using Microsoft.EntityFrameworkCore.Migrations;

namespace OfficeManagementSystem.Migrations
{
    public partial class VenueUpdatev2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VenueID",
                table: "Events",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VenueID",
                table: "Events");
        }
    }
}
