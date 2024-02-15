
using Microsoft.EntityFrameworkCore;
using v1 = Microsoft.EntityFrameworkCore;
using MovieApp.Models;
using System.Data.Entity;


namespace MovieApp.Data
{
    public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext   //Translator Which Helps To Communicate With Class And DB
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });

            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actor_Movies).HasForeignKey(am => am.MovieId);

            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actor_Movies).HasForeignKey(am => am.ActorId);

            base.OnModelCreating(modelBuilder);
        }

        //Defining Table name of every Model

        public v1.DbSet<Actor> Actors { get; set; }
        public v1.DbSet<Movie> Movies { get; set; }
        public v1.DbSet<Cinema> Cinemas { get; set; }
        public v1.DbSet<Actor_Movie> Actor_Movies { get; set; }
        public v1.DbSet<Producer> Producers { get; set; }



    }
}
