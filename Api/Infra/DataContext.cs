using Api.Models;
using Microsoft.EntityFrameworkCore;
using System;



namespace Api.Infra
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            
        }       

        public DbSet<Championship> Championship { get; set; }
        public DbSet<ChampionshipMatches> ChampionshipMatches { get; set; }
        public DbSet<Leaderboard> Leaderboard { get; set; }
        public DbSet<LeaderboardGroupInfo> LeaderboardGroupInfo { get; set; }
        public DbSet<Team> Team { get; set; }
    }
}
