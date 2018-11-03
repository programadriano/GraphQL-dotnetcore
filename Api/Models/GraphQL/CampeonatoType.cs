using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class CampeonatoType : ObjectGraphType<Championship>
    {
        public CampeonatoType()
        {
            Name = "Campeonato";

            Field(x => x.Id, type: typeof(IdGraphType)).Description("Id do campeonato");

            Field(x => x.Name).Description("Nome do campeonato");

            Field(x => x.PortalUrl);

            Field(x => x.ChampionshipMatches, type: typeof(ListGraphType<ChampionshipMatchesType>)).Description("Lista de partidas");

            Field(x => x.Leaderboard, type: typeof(ListGraphType<LeaderboardType>)).Description("Ranking");
        }
    }
}
