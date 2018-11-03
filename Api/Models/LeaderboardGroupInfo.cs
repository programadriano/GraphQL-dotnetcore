using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class LeaderboardGroupInfo : BaseEntity
    {
        public Team Team { get; set; }
        public int TeamId { get; set; }
        public int LeaderboardId { get; set; }
        public int Position { get; set; }
        public string positionChange { get; set; }
        public int Points { get; set; }
        public int MatchesPlayed { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Losses { get; set; }
        public string QualificationType { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }
        public int GoalsDifference { get; set; }
        public double PointsPercentage { get; set; }
    }
}
