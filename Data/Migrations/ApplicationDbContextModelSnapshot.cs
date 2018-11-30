﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pellys.Data;

namespace Pellys.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Pellys.Models.Actor", b =>
                {
                    b.Property<int>("ActorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ActorName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("ActorId");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("Pellys.Models.ActorMovies", b =>
                {
                    b.Property<int>("ActorId");

                    b.Property<int>("MovieId");

                    b.HasKey("ActorId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("ActorMovies");
                });

            modelBuilder.Entity("Pellys.Models.Director", b =>
                {
                    b.Property<int>("DirectorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DirectorName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("DirectorId");

                    b.ToTable("Directors");
                });

            modelBuilder.Entity("Pellys.Models.Form", b =>
                {
                    b.Property<int>("FormId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("PartnerId");

                    b.Property<int>("TapeId");

                    b.HasKey("FormId");

                    b.HasIndex("PartnerId");

                    b.HasIndex("TapeId");

                    b.ToTable("Forms");
                });

            modelBuilder.Entity("Pellys.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GenreTitle")
                        .HasMaxLength(20);

                    b.HasKey("GenreId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Pellys.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DirectorId");

                    b.Property<int>("GenreId");

                    b.Property<string>("MovieTitle")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("MovieId");

                    b.HasIndex("DirectorId");

                    b.HasIndex("GenreId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Pellys.Models.Partner", b =>
                {
                    b.Property<int>("PartnerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PartnerAddress")
                        .IsRequired();

                    b.Property<string>("PartnerName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("PartnerTelephone")
                        .IsRequired();

                    b.HasKey("PartnerId");

                    b.ToTable("Partners");
                });

            modelBuilder.Entity("Pellys.Models.PartnerActors", b =>
                {
                    b.Property<int>("PartnerId");

                    b.Property<int>("ActorId");

                    b.HasKey("PartnerId", "ActorId");

                    b.HasIndex("ActorId");

                    b.ToTable("PartnerActors");
                });

            modelBuilder.Entity("Pellys.Models.PartnerDirector", b =>
                {
                    b.Property<int>("PartnerId");

                    b.Property<int>("DirectorId");

                    b.HasKey("PartnerId", "DirectorId");

                    b.HasIndex("DirectorId");

                    b.ToTable("PartnerDirector");
                });

            modelBuilder.Entity("Pellys.Models.PartnerGenre", b =>
                {
                    b.Property<int>("PartnerId");

                    b.Property<int>("GenreId");

                    b.HasKey("PartnerId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("PartnerGenre");
                });

            modelBuilder.Entity("Pellys.Models.PartnerWaitingList", b =>
                {
                    b.Property<int>("PartnerId");

                    b.Property<int>("WaitingListId");

                    b.HasKey("PartnerId", "WaitingListId");

                    b.HasIndex("WaitingListId");

                    b.ToTable("PartnerWaitingList");
                });

            modelBuilder.Entity("Pellys.Models.Tape", b =>
                {
                    b.Property<int>("TapeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MovieId");

                    b.Property<bool>("TapeState");

                    b.HasKey("TapeId");

                    b.HasIndex("MovieId");

                    b.ToTable("Tapes");
                });

            modelBuilder.Entity("Pellys.Models.WaitingList", b =>
                {
                    b.Property<int>("WaitingListId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MovieId");

                    b.HasKey("WaitingListId");

                    b.HasIndex("MovieId");

                    b.ToTable("WaitingLists");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Pellys.Models.ActorMovies", b =>
                {
                    b.HasOne("Pellys.Models.Actor", "Actor")
                        .WithMany("ActorMovies")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Pellys.Models.Movie", "Movie")
                        .WithMany("ActorMovies")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Pellys.Models.Form", b =>
                {
                    b.HasOne("Pellys.Models.Partner", "Partner")
                        .WithMany("Forms")
                        .HasForeignKey("PartnerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Pellys.Models.Tape", "Tape")
                        .WithMany("Forms")
                        .HasForeignKey("TapeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Pellys.Models.Movie", b =>
                {
                    b.HasOne("Pellys.Models.Director", "Director")
                        .WithMany("Movies")
                        .HasForeignKey("DirectorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Pellys.Models.Genre", "Genre")
                        .WithMany("Movies")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Pellys.Models.PartnerActors", b =>
                {
                    b.HasOne("Pellys.Models.Actor", "Actor")
                        .WithMany("PartnerActors")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Pellys.Models.Partner", "Partner")
                        .WithMany("PartnerActors")
                        .HasForeignKey("PartnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Pellys.Models.PartnerDirector", b =>
                {
                    b.HasOne("Pellys.Models.Director", "Director")
                        .WithMany("PartnerDirectors")
                        .HasForeignKey("DirectorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Pellys.Models.Partner", "Partner")
                        .WithMany("PartnerDirectors")
                        .HasForeignKey("PartnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Pellys.Models.PartnerGenre", b =>
                {
                    b.HasOne("Pellys.Models.Genre", "Genre")
                        .WithMany("PartnerGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Pellys.Models.Partner", "Partner")
                        .WithMany("PartnerGenres")
                        .HasForeignKey("PartnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Pellys.Models.PartnerWaitingList", b =>
                {
                    b.HasOne("Pellys.Models.Partner", "Partner")
                        .WithMany("PartnerWaitingLists")
                        .HasForeignKey("PartnerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Pellys.Models.WaitingList", "WaitingList")
                        .WithMany("PartnerWaitingLists")
                        .HasForeignKey("WaitingListId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Pellys.Models.Tape", b =>
                {
                    b.HasOne("Pellys.Models.Movie", "Movie")
                        .WithMany("Tapes")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Pellys.Models.WaitingList", b =>
                {
                    b.HasOne("Pellys.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
