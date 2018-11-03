//using Api.Infra;
//using Api.Models;
//using GraphQL.Types;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Linq;

//namespace Api.Queries
//{
//    public class EatMoreQuery : ObjectGraphType
//    {
//        public EatMoreQuery(DataContext db)
//        {
//            //GetAll
//            Field<ListGraphType<CampeonatoType>>(
//                "campeonatos",
//                resolve: context =>
//                {
//                    var campeonatos = db.Campeonato.Include("Times.Jogadores");
//                    return campeonatos;
//                });

//            //GetByID
//            Field<CampeonatoType>(
//                "campeonato",
//                arguments: new QueryArguments(
//                    new QueryArgument<IdGraphType> { Name = "id", Description = "Id do campeonato" }),
//                resolve: context =>
//                {
//                    var id = context.GetArgument<Guid?>("id");
//                    var campeonato = db
//                        .Campeonato
//                        .Include("Times.Jogadores") //
//                        .FirstOrDefault(i => i.Id == id);
//                    return campeonato;
//                });


//        }
//    }
//}
