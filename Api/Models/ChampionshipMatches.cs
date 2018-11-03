using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class ChampionshipMatches : BaseEntity
    {
      
        public int ChampionshipId { get; set; }
        public int Round { get; set; }
        public DateTime Date { get; set; }
        public string DetailedDate { get; set; }
        public string Hour { get; set; }
        public string Stadium { get; set; }
        public string HomeTeamInitials { get; set; }
        public string AwayTeamInitials { get; set; }

        public string HomeTeamName { get; set; }
        public string AwayTeamName { get; set; }
        public string homeTeamShieldUrl { get; set; }
        public string awayTeamShieldUrl { get; set; }
        public string Status { get; set; }
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }
        public int HomePenaltyScore { get; set; }
        public int AwaPenaltyScore { get; set; }

        
    }
}
