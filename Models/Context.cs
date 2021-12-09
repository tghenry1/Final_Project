using System;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VideoGameStreamer>().HasKey(v => new {v.GameId, v.StreamerId});
        }

        public DbSet<VideoGame> VideoGame {get; set;}
        public DbSet<Streamer> Streamer {get; set;}
        public DbSet<VideoGameStreamer> VideoGameStreamer {get; set;}
    }
}