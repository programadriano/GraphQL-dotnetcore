//using GraphQL.Types;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Api.Models
//{
//    public class CampeonatoType : ObjectGraphType<Championship>
//    {
//        public CampeonatoType()
//        {
//            Name = "Campeonato";

//            Field(x => x.Id, type: typeof(IdGraphType)).Description("Id do campeonato");
//            Field(x => x.Nome).Description("Nome do campeonato");
//            Field(x => x.Times, type: typeof(ListGraphType<TimesType>)).Description("Lista de times");
//        }
//    }
//}
