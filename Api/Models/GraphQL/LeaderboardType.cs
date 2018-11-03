using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class LeaderboardType : ObjectGraphType<Leaderboard>
    {
        public LeaderboardType()
        {
            Name = "Leaderboard";

            Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the menu.");
            Field(x => x.ChampionshipName).Description("Nome do campeonato");
            Field(x => x.ActualStage).Description("Estagio atual");            
            Field(x => x.LeaderboardGroupInfo, type: typeof(ListGraphType<LeaderboardGroupInfoType>)).Description("Ranking dos primeiros colocados");
        }
    }
}
