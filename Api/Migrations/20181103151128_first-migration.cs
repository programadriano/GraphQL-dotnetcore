using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Championship",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataDeCriacao = table.Column<DateTime>(nullable: false),
                    DataDeAtualizacao = table.Column<DateTime>(nullable: false),
                    Deletado = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Season = table.Column<string>(nullable: true),
                    Place = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Championship", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataDeCriacao = table.Column<DateTime>(nullable: false),
                    DataDeAtualizacao = table.Column<DateTime>(nullable: false),
                    Deletado = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    TeamShieldImage = table.Column<string>(nullable: true),
                    Initials = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    TeamSectionUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChampionshipMatches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataDeCriacao = table.Column<DateTime>(nullable: false),
                    DataDeAtualizacao = table.Column<DateTime>(nullable: false),
                    Deletado = table.Column<bool>(nullable: false),
                    ChampionshipId = table.Column<int>(nullable: false),
                    Round = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    DetailedDate = table.Column<DateTime>(nullable: false),
                    Hour = table.Column<string>(nullable: true),
                    Stadium = table.Column<string>(nullable: true),
                    HomeTeamInitials = table.Column<string>(nullable: true),
                    AwayTeamInitials = table.Column<string>(nullable: true),
                    HomeTeamName = table.Column<string>(nullable: true),
                    AwayTeamName = table.Column<string>(nullable: true),
                    homeTeamShieldUrl = table.Column<string>(nullable: true),
                    awayTeamShieldUrl = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    HomeScore = table.Column<string>(nullable: true),
                    AwayScore = table.Column<string>(nullable: true),
                    HomePenaltyScore = table.Column<string>(nullable: true),
                    AwaPenaltyScore = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChampionshipMatches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChampionshipMatches_Championship_ChampionshipId",
                        column: x => x.ChampionshipId,
                        principalTable: "Championship",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Leaderboard",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataDeCriacao = table.Column<DateTime>(nullable: false),
                    DataDeAtualizacao = table.Column<DateTime>(nullable: false),
                    Deletado = table.Column<bool>(nullable: false),
                    ChampionshipId = table.Column<int>(nullable: false),
                    ChampionshipName = table.Column<string>(nullable: true),
                    ActualStage = table.Column<string>(nullable: true),
                    TeamId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leaderboard", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Leaderboard_Championship_ChampionshipId",
                        column: x => x.ChampionshipId,
                        principalTable: "Championship",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Leaderboard_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LeaderboardGroupInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataDeCriacao = table.Column<DateTime>(nullable: false),
                    DataDeAtualizacao = table.Column<DateTime>(nullable: false),
                    Deletado = table.Column<bool>(nullable: false),
                    TeamId = table.Column<int>(nullable: false),
                    LeaderboardId = table.Column<int>(nullable: false),
                    Position = table.Column<int>(nullable: false),
                    positionChange = table.Column<string>(nullable: true),
                    Points = table.Column<int>(nullable: false),
                    MatchesPlayed = table.Column<int>(nullable: false),
                    Wins = table.Column<int>(nullable: false),
                    Draws = table.Column<int>(nullable: false),
                    Losses = table.Column<int>(nullable: false),
                    QualificationType = table.Column<string>(nullable: true),
                    GoalsFor = table.Column<int>(nullable: false),
                    GoalsAgainst = table.Column<int>(nullable: false),
                    GoalsDifference = table.Column<int>(nullable: false),
                    PointsPercentage = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaderboardGroupInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaderboardGroupInfo_Leaderboard_LeaderboardId",
                        column: x => x.LeaderboardId,
                        principalTable: "Leaderboard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChampionshipMatches_ChampionshipId",
                table: "ChampionshipMatches",
                column: "ChampionshipId");

            migrationBuilder.CreateIndex(
                name: "IX_Leaderboard_ChampionshipId",
                table: "Leaderboard",
                column: "ChampionshipId");

            migrationBuilder.CreateIndex(
                name: "IX_Leaderboard_TeamId",
                table: "Leaderboard",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaderboardGroupInfo_LeaderboardId",
                table: "LeaderboardGroupInfo",
                column: "LeaderboardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChampionshipMatches");

            migrationBuilder.DropTable(
                name: "LeaderboardGroupInfo");

            migrationBuilder.DropTable(
                name: "Leaderboard");

            migrationBuilder.DropTable(
                name: "Championship");

            migrationBuilder.DropTable(
                name: "Team");
        }
    }
}
