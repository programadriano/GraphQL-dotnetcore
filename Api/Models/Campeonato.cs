using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class Campeonato
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Times> Times { get; set; }
    }
}
