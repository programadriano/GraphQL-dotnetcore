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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Campeonato>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Times>()
                 .HasKey(p => p.Id);

            modelBuilder.Entity<Jogadores>()
            .HasKey(p => p.Id);
        }

        public DbSet<Campeonato> Campeonato { get; set; }
        public DbSet<Times> Times { get; set; }
        public DbSet<Jogadores> Jogadores { get; set; }
    }
}
