using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class Times
    {
        public Guid Id { get; set; }
        public Guid CampeonatoId { get; set; }
        public string Nome { get; set; }
        public int Pontos { get; set; }
        public string Escudo { get; set; }

        public ICollection<Jogadores> Jogadores { get; set; }
    }
}
