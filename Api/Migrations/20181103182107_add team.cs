using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Migrations
{
    public partial class addteam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_LeaderboardGroupInfo_TeamId",
                table: "LeaderboardGroupInfo",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaderboardGroupInfo_Team_TeamId",
                table: "LeaderboardGroupInfo",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaderboardGroupInfo_Team_TeamId",
                table: "LeaderboardGroupInfo");

            migrationBuilder.DropIndex(
                name: "IX_LeaderboardGroupInfo_TeamId",
                table: "LeaderboardGroupInfo");
        }
    }
}
