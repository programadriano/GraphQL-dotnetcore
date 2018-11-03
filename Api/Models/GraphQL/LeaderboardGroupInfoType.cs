using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class LeaderboardGroupInfoType : ObjectGraphType<LeaderboardGroupInfo>
    {
        public LeaderboardGroupInfoType()
        {
            Name = "LeaderboardGroupInfo";

            Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the menu.");
            Field(x => x.Position).Description("Posicao");
            Field(x => x.positionChange).Description("Posicao atual");
            Field(x => x.Points).Description("Pontos");
            Field(x => x.MatchesPlayed).Description("Partidas desputadas");

            Field(x => x.Wins).Description("Vitórias");
            Field(x => x.Draws).Description("Empates");
            Field(x => x.Losses).Description("Partidas que perdeu");
            Field(x => x.QualificationType).Description("Interna");

            Field(x => x.GoalsFor).Description("Goals");
            Field(x => x.GoalsAgainst).Description("Goals");
            Field(x => x.GoalsDifference).Description("Goals");
            Field(x => x.PointsPercentage).Description("Porcentagem de pontos no campeonato");
            Field(x => x.Team, type: typeof(TeamType)).Description("Time");


        }
    }
}
