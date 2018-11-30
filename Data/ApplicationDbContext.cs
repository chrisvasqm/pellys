using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pellys.Models;

namespace Pellys.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ActorMovies>().HasKey(Am => new { Am.ActorId, Am.MovieId });
            modelBuilder.Entity<PartnerActors>().HasKey(Pa => new { Pa.PartnerId, Pa.ActorId});
            modelBuilder.Entity<PartnerDirector>().HasKey(Pd => new { Pd.PartnerId, Pd.DirectorId });
            modelBuilder.Entity<PartnerGenre>().HasKey(Pg => new { Pg.PartnerId, Pg.GenreId });
            modelBuilder.Entity<PartnerWaitingList>().HasKey(Pw => new { Pw.PartnerId, Pw.WaitingListId });
        }


        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<Director> Directors { get; set; }
        public virtual DbSet<Form> Forms { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Partner> Partners { get; set; }
        public virtual DbSet<Tape> Tapes { get; set; }
        public virtual DbSet<WaitingList> WaitingLists { get; set; }

    }
}