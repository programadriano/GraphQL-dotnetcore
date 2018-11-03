﻿// <auto-generated />
using System;
using Api.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20181103164905_correct")]
    partial class correct
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Api.Models.Championship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataDeAtualizacao");

                    b.Property<DateTime>("DataDeCriacao");

                    b.Property<bool>("Deletado");

                    b.Property<string>("Initials");

                    b.Property<string>("Name");

                    b.Property<string>("PortalUrl");

                    b.HasKey("Id");

                    b.ToTable("Championship");
                });

            modelBuilder.Entity("Api.Models.ChampionshipMatches", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AwaPenaltyScore");

                    b.Property<int>("AwayScore");

                    b.Property<string>("AwayTeamInitials");

                    b.Property<string>("AwayTeamName");

                    b.Property<int>("ChampionshipId");

                    b.Property<DateTime>("DataDeAtualizacao");

                    b.Property<DateTime>("DataDeCriacao");

                    b.Property<DateTime>("Date");

                    b.Property<bool>("Deletado");

                    b.Property<string>("DetailedDate");

                    b.Property<int>("HomePenaltyScore");

                    b.Property<int>("HomeScore");

                    b.Property<string>("HomeTeamInitials");

                    b.Property<string>("HomeTeamName");

                    b.Property<string>("Hour");

                    b.Property<int>("Round");

                    b.Property<string>("Stadium");

                    b.Property<string>("Status");

                    b.Property<string>("awayTeamShieldUrl");

                    b.Property<string>("homeTeamShieldUrl");

                    b.HasKey("Id");

                    b.HasIndex("ChampionshipId");

                    b.ToTable("ChampionshipMatches");
                });

            modelBuilder.Entity("Api.Models.Leaderboard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActualStage");

                    b.Property<int>("ChampionshipId");

                    b.Property<string>("ChampionshipName");

                    b.Property<DateTime>("DataDeAtualizacao");

                    b.Property<DateTime>("DataDeCriacao");

                    b.Property<bool>("Deletado");

                    b.Property<int?>("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("ChampionshipId");

                    b.HasIndex("TeamId");

                    b.ToTable("Leaderboard");
                });

            modelBuilder.Entity("Api.Models.LeaderboardGroupInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataDeAtualizacao");

                    b.Property<DateTime>("DataDeCriacao");

                    b.Property<bool>("Deletado");

                    b.Property<int>("Draws");

                    b.Property<int>("GoalsAgainst");

                    b.Property<int>("GoalsDifference");

                    b.Property<int>("GoalsFor");

                    b.Property<int>("LeaderboardId");

                    b.Property<int>("Losses");

                    b.Property<int>("MatchesPlayed");

                    b.Property<int>("Points");

                    b.Property<double>("PointsPercentage");

                    b.Property<int>("Position");

                    b.Property<string>("QualificationType");

                    b.Property<int>("TeamId");

                    b.Property<int>("Wins");

                    b.Property<string>("positionChange");

                    b.HasKey("Id");

                    b.HasIndex("LeaderboardId");

                    b.ToTable("LeaderboardGroupInfo");
                });

            modelBuilder.Entity("Api.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<DateTime>("DataDeAtualizacao");

                    b.Property<DateTime>("DataDeCriacao");

                    b.Property<bool>("Deletado");

                    b.Property<string>("Initials");

                    b.Property<string>("Name");

                    b.Property<string>("State");

                    b.Property<string>("TeamSectionUrl");

                    b.Property<string>("TeamShieldImage");

                    b.HasKey("Id");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("Api.Models.ChampionshipMatches", b =>
                {
                    b.HasOne("Api.Models.Championship")
                        .WithMany("ChampionshipMatches")
                        .HasForeignKey("ChampionshipId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Api.Models.Leaderboard", b =>
                {
                    b.HasOne("Api.Models.Championship")
                        .WithMany("Leaderboard")
                        .HasForeignKey("ChampionshipId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Api.Models.Team")
                        .WithMany("Leaderboard")
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("Api.Models.LeaderboardGroupInfo", b =>
                {
                    b.HasOne("Api.Models.Leaderboard")
                        .WithMany("LeaderboardGroupInfo")
                        .HasForeignKey("LeaderboardId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
