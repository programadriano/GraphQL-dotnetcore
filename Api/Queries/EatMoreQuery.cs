using Api.Infra;
using Api.Models;
using GraphQL.Types;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Api.Queries
{
    public class EatMoreQuery : ObjectGraphType
    {
        public EatMoreQuery(DataContext db)
        {
            //GetAll
            Field<ListGraphType<CampeonatoType>>(
                "Championships",
                resolve: context =>
                {
                    var campeonatos = db
                    .Championship
                    .Include("ChampionshipMatches")
                    .Include("Leaderboard");
                    return campeonatos;
                });

            //GetByID
            Field<CampeonatoType>(
                "Championship",
                arguments: new QueryArguments(
                    new QueryArgument<IdGraphType> { Name = "id", Description = "Id do campeonato" }),
                resolve: context =>
                {
                    var id = context.GetArgument<int?>("id");
                    var campeonato = db
                        .Championship
                        .Include("ChampionshipMatches")
                         .Include("Leaderboard.LeaderboardGroupInfo.Team")
                        .FirstOrDefault(i => i.Id == id);
                    return campeonato;
                });


        }
    }
}
