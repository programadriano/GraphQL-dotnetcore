using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class ChampionshipMatchesType : ObjectGraphType<ChampionshipMatches>
    {
        public ChampionshipMatchesType()
        {
            Name = "ChampionshipMatches";

            Field(x => x.Id, type: typeof(IdGraphType)).Description("Id da partida");
            Field(x => x.Round).Description("Rodada");
            Field(x => x.Date).Description("Data da partida");
            Field(x => x.DetailedDate).Description("Data detalhada");
            Field(x => x.Hour).Description("Horário da partida");


            Field(x => x.Stadium).Description("Estádio");
            Field(x => x.HomeTeamInitials).Description("Iniciais do time da casa");
            Field(x => x.AwayTeamInitials).Description("Iniciais do time desafiante");

            Field(x => x.HomeTeamName).Description("Nome do time da casa");
            Field(x => x.AwayTeamName).Description("Nome do time desafiante");

            Field(x => x.homeTeamShieldUrl).Description("Escudo do time da casa");
            Field(x => x.awayTeamShieldUrl).Description("Escudo do time desafiante");

            Field(x => x.Status).Description("Status da partida");

            Field(x => x.HomeScore).Description("Pontos do time da casa");
            Field(x => x.AwayScore).Description("Pontos do time da desafiante");
            Field(x => x.HomePenaltyScore).Description("Penaltis do time da casa");
            Field(x => x.AwaPenaltyScore).Description("Penaltis do time desafiante");
        }
    }
}
