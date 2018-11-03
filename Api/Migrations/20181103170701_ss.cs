using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Migrations
{
    public partial class ss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Leaderboard_Team_TeamId",
                table: "Leaderboard");

            migrationBuilder.DropIndex(
                name: "IX_Leaderboard_TeamId",
                table: "Leaderboard");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Leaderboard");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "Leaderboard",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Leaderboard_TeamId",
                table: "Leaderboard",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Leaderboard_Team_TeamId",
                table: "Leaderboard",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
