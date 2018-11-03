using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class Leaderboard : BaseEntity
    {
       
        public int ChampionshipId { get; set; }
        public string ChampionshipName { get; set; }       
        public string ActualStage { get; set; }

        public ICollection<LeaderboardGroupInfo> LeaderboardGroupInfo { get; set; }
    }
}
