using System;
using Microsoft.EntityFrameworkCore;
using CruisersApi.Domain.Entities;

namespace CruisersApi.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Cruiser> Cruiser { get; set; }
        public DbSet<Layover> Layover { get; set; }
        public DbSet<Location> Locations { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cruiser>().ToTable("Cruiser");
            modelBuilder.Entity<Cruiser>().HasKey(p => p.Id);
            modelBuilder.Entity<Cruiser>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Cruiser>().Property(p => p.Name).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Cruiser>().Property(p => p.Model).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Cruiser>().Property(p => p.Line).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Cruiser>().Property(p => p.Picture);
            modelBuilder.Entity<Cruiser>().Property(p => p.Status).IsRequired();
            modelBuilder.Entity<Cruiser>().Property(p => p.LoadingShipCap).IsRequired();
            modelBuilder.Entity<Cruiser>().Property(p => p.Capacity).IsRequired();
            modelBuilder.Entity<Cruiser>().HasMany(p => p.Layovers).WithOne(p => p.Cruiser)
                .HasForeignKey(p => p.CruiserId);

            modelBuilder.Entity<Cruiser>().HasData
            (
                new Cruiser { Id = 100, Name = "Titanic", Model = "RMS Titanic", Line = "Transatlantic",Status = true , LoadingShipCap = 15000, Capacity = 5000},
                new Cruiser { Id = 101, Name = "Concord", Model = "Concord", Line = "Transatlantic",Status = true , LoadingShipCap = 7000, Capacity = 2500}
                );
            
            modelBuilder.Entity<Layover>().ToTable("Layover");
            modelBuilder.Entity<Layover>().HasKey(p => p.Id);
            modelBuilder.Entity<Layover>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Layover>().Property(p => p.Price).IsRequired();
            modelBuilder.Entity<Layover>().Property(p => p.ArrivalDate).IsRequired();
            modelBuilder.Entity<Layover>().Property(p => p.DepartureDate).IsRequired();
            modelBuilder.Entity<Layover>().Property(p => p.LocArrival).IsRequired();
            modelBuilder.Entity<Layover>().Property(p => p.LocDeparture).IsRequired();

            modelBuilder.Entity<Location>().ToTable("Location");
            modelBuilder.Entity<Location>().HasKey(p => p.Id);
            modelBuilder.Entity<Location>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Location>().Property(p => p.City).HasMaxLength(30);
            modelBuilder.Entity<Location>().Property(p => p.Country).HasMaxLength(30);

            modelBuilder.Entity<Location>().HasData
            (
                new Location {Id = 1, City = "Miami", Country = "United States"},
                new Location {Id =2 ,City = "Panama City", Country = "Panama"},
                new Location {Id = 3, City = "La Guaira", Country = "Venezuela"}
            );
            
            modelBuilder.Entity<Layover>().HasData(
                new Layover{Id = 100, DepartureDate = new DateTime(2019,6,20,07,0,0), ArrivalDate = new DateTime(2019,7,20,07,0,0),Price = 500, LocDeparture = 3,LocArrival = 1,CruiserId = 100},
                new Layover{Id = 101, DepartureDate = new DateTime(2019,7,20,19,0,0), ArrivalDate = new DateTime(2019,8,20,19,0,0),Price = 500, LocDeparture = 1,LocArrival = 2,CruiserId = 100}
            );
        }
    }
}