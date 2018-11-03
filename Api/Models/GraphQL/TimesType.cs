//using GraphQL.Types;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Api.Models
//{
//    public class TimesType : ObjectGraphType<ChampionshipMatches>
//    {
//        public TimesType()
//        {
//            Name = "Times";

//            Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the menu.");
//            Field(x => x.Nome).Description("Nome");
//            Field(x => x.Pontos).Description("Pontos");
//            Field(x => x.Escudo).Description("Escudo");
//            Field(x => x.Jogadores, type: typeof(ListGraphType<JogadoresType>)).Description("Lista de jogadores");
//        }
//    }
//}
