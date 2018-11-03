using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class Championship : BaseEntity
    {
       
        public string Name { get; set; }
        public string Initials { get; set; }
        public string PortalUrl { get; set; }
        public ICollection<ChampionshipMatches> ChampionshipMatches { get; set; }
        public ICollection<Leaderboard> Leaderboard { get; set; }

    }
}
