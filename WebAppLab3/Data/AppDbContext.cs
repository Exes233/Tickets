using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;
using WebAppLab3.Models;

namespace WebAppLab3.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<ContactUsEntry> ContactUsEntries { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Comment> Comments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactUsEntry>().HasData(
                new ContactUsEntry { Id = 1, Email = "test@gmail.com", Message = "Hello", Timestamp = DateTime.Now });
            modelBuilder.Entity<Flight>().HasData(
                new Flight
                {
                    Id = 1,
                    Name = "Paris",
                    Description = "Explore the romantic charm of the City of Lights, visit iconic landmarks like the Eiffel Tower, and indulge in exquisite French cuisine.",
                    ImagePath = "/images/paris.jpg"
                },
                new Flight
                {
                    Id = 2,
                    Name = "Tokyo",
                    Description = "Immerse yourself in the vibrant energy of Tokyo, experience a blend of modernity and tradition, and discover the unique cultural wonders of Japan.",
                    ImagePath = "/images/tokyo.jpg"
                },
                new Flight
                {
                    Id = 3,
                    Name = "New York",
                    Description = "Dive into the bustling metropolis of New York City, witness the dazzling lights of Times Square, and explore world-renowned attractions like Central Park and the Statue of Liberty.",
                    ImagePath = "/images/new_york.jpg"
                },
                new Flight
                {
                    Id = 4,
                    Name = "Rio de Janeiro",
                    Description = "Embark on a journey to Rio de Janeiro, where the lively rhythm of samba meets stunning beaches, iconic landmarks like Christ the Redeemer, and the vibrant Carnival spirit.",
                    ImagePath = "/images/rio.jpg"
                });
            var parisSeats = Enumerable.Range(1, 20).Select(i => new Seat
            {
                Id = i,
                Number = $"A{i}",
                Price = 250,
                FlightId = 1 
            }).ToList();
            modelBuilder.Entity<Seat>().HasData(parisSeats.ToArray());
            
            var tokyoSeats = Enumerable.Range(1, 15).Select(i => new Seat
            {
                Id = i + 20,
                Number = $"B{i}",
                Price = 450,
                FlightId = 2 
            }).ToList();
            modelBuilder.Entity<Seat>().HasData(tokyoSeats.ToArray());

            var newYorkSeats = Enumerable.Range(1, 20).Select(i => new Seat
            {
                Id = i + 35,
                Number = $"C{i}",
                Price = 1050,
                FlightId = 3 
            }).ToList();
            modelBuilder.Entity<Seat>().HasData(newYorkSeats.ToArray());

            var rioSeats = Enumerable.Range(1, 10).Select(i => new Seat
            {
                Id = i + 55,
                Number = $"A{i}",
                Price = 350,
                FlightId = 4 
            }).ToList();
            modelBuilder.Entity<Seat>().HasData(rioSeats.ToArray());
        }
    }
}
