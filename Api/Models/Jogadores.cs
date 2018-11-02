using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class Jogadores
    {
        public Guid Id { get; set; }
        public Guid TimeId { get; set; }
        public string Nome { get; set; }
        public string Idade { get; set; }
        public string Posicao { get; set; }
        public bool Titular { get; set; }
    }
}
