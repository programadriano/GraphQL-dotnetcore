using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class TeamType : ObjectGraphType<Team>
    {
        public TeamType()
        {
            Name = "TeamType";

            Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the menu.");
            Field(x => x.Name).Description("Nome do time");
            Field(x => x.TeamShieldImage).Description("Escudo do time");
            Field(x => x.Initials).Description("Iniciais do time");
            Field(x => x.City).Description("Cidade do time");
            Field(x => x.State).Description("Estado do time");
            Field(x => x.TeamSectionUrl).Description("Interna");
        }
    }
}
