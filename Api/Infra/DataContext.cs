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

        public DbSet<Campeonato> Campeonato { get; set; }
        public DbSet<Times> Times { get; set; }
        public DbSet<Jogadores> Jogadores { get; set; }
    }
}
