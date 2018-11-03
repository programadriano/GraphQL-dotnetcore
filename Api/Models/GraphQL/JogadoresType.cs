//using GraphQL.Types;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Api.Models
//{
//    public class JogadoresType : ObjectGraphType<Leaderboard>
//    {
//        public JogadoresType()
//        {
//            Name = "Jogadores";

//            Field(x => x.Id, type: typeof(IdGraphType)).Description("Id do jogador");
//            Field(x => x.Nome).Description("Nome do jogador");
//            Field(x => x.Idade).Description("Idade do jogador");
//            Field(x => x.Posicao).Description("Posicao do jogador");
//            Field(x => x.Titular).Description("Se o jogador é titular");
//        }
//    }
//}
