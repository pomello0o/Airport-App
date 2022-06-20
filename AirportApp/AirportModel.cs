using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AirportApp
{
    public partial class AirportModel : DbContext
    {
        public AirportModel()
            : base("name=Airport")
        {
            Database.SetInitializer<AirportModel>(new MyDBInitializer<AirportModel>());
        }

        public virtual DbSet<AllowedCrewMemberModel> AllowedCrewMemberModels { get; set; }
        public virtual DbSet<AllowedRaceModel> AllowedRaceModels { get; set; }
        public virtual DbSet<Crew> Crews { get; set; }
        public virtual DbSet<CrewMember> CrewMembers { get; set; }
        public virtual DbSet<Flight> Flights { get; set; }
        public virtual DbSet<Model> Models { get; set; }
        public virtual DbSet<Plane> Planes { get; set; }
        public virtual DbSet<Race> Races { get; set; }
        public virtual DbSet<Stewardess> Stewardesses { get; set; }
        public virtual DbSet<TakenPlaceFlight> TakenPlaceFlights { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<CrewMember>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<CrewMember>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CrewMember>()
                .Property(e => e.Role)
                .IsUnicode(false);

            modelBuilder.Entity<CrewMember>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Model>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Plane>()
                .Property(e => e.BoardNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Race>()
                .Property(e => e.DeparturePoint)
                .IsUnicode(false);

            modelBuilder.Entity<Race>()
                .Property(e => e.DestinationPoint)
                .IsUnicode(false);

            modelBuilder.Entity<Race>()
                .Property(e => e.DepartureTime)
                .HasPrecision(2);

            modelBuilder.Entity<Race>()
                .Property(e => e.LandingTime)
                .HasPrecision(2);

            modelBuilder.Entity<Stewardess>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Stewardess>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Stewardess>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<TakenPlaceFlight>()
                .Property(e => e.BoardNumber)
                .IsUnicode(false);

            modelBuilder.Entity<TakenPlaceFlight>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
