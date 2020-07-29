using Microsoft.EntityFrameworkCore;
using Soccer.web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soccer.web.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<TeamEntity> Teams { get; set; }


        public DbSet<GroupDetailEntity> GroupDetails { get; set; }

        public DbSet<GroupEntity> Groups { get; set; }

        public DbSet<MatchEntity> Matches { get; set; }

        public DbSet<TournamentEntity> Tournaments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<TeamEntity>()
                .HasIndex(t => t.Name)
                .IsUnique();

        }

    }
}
