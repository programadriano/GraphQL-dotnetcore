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


            //ChampionshipMatches
            Field<ListGraphType<ChampionshipMatchesType>>(
                 "ChampionshipMatches",
                 arguments: new QueryArguments(
                    new QueryArgument<IdGraphType> { Name = "pagina" },
                    new QueryArgument<IdGraphType> { Name = "quantidade" }
                    ),
                 resolve: context =>
                 {
                     var championshipMatches = db.ChampionshipMatches.OrderBy(x => x.Date);


                     if (context.Arguments.Count() > 0)
                     {
                         if (context.Arguments["pagina"] != null && context.Arguments["quantidade"] != null)
                         {

                             var pagina = context.GetArgument("pagina", int.MaxValue);

                             var qtd = context.GetArgument("quantidade", int.MaxValue);

                             return championshipMatches
                                  .Skip(pagina * qtd)
                                  .Take(qtd);

                         }

                         return championshipMatches.Take(10);

                     }
                     else
                     {
                         return championshipMatches.Take(10);
                     }


                 });



        }
    }
}
