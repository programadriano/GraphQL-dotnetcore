using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Migrations
{
    public partial class correctfist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "HomeScore",
                table: "ChampionshipMatches",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HomePenaltyScore",
                table: "ChampionshipMatches",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AwayScore",
                table: "ChampionshipMatches",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AwaPenaltyScore",
                table: "ChampionshipMatches",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "HomeScore",
                table: "ChampionshipMatches",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "HomePenaltyScore",
                table: "ChampionshipMatches",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "AwayScore",
                table: "ChampionshipMatches",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "AwaPenaltyScore",
                table: "ChampionshipMatches",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
