using CR.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace CR.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<ApplicationUser> applicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Car>().HasData(
                    new Car
                    {
                        Id = 1,
                        Model = "Mercedes CLS 5.5",
                        Type = "Sedan",
                        Interior = "leathar",
                        Fuel = "Petrol",
                        Transmission = "Auto",
                        Seats = "4",
                        Price = 100,
                        Mileage = "147",
                        Year = "2020"
                    },

                    new Car
                    {
                        Id = 2,
                        Model = "Mazda 6 2.0",
                        Type = "Sedan",
                        Interior = "Fabric",
                        Fuel = "Petrol",
                        Transmission = "Auto",
                        Seats = "5",
                        Price = 70,
                        Mileage = "95",
                        Year = "2016"
                    },
                    new Car
                    {
                        Id = 3,
                        Model = "BMW X5 4.0",
                        Type = "Sedan",
                        Interior = "leathar",
                        Fuel = "Petrol",
                        Transmission = "Manual",
                        Seats = "4",
                        Price = 90,
                        Mileage = "112",
                        Year = "2018"
                    },
                    new Car
                    {
                        Id = 4,
                        Model = "Mecedes Viano 2.5",
                        Type = "Van",
                        Interior = "Fabric",
                        Fuel = "Diesel",
                        Transmission = "Auto",
                        Seats = "7",
                        Price = 120,
                        Mileage = "34",
                        Year = "2021"
                    }

                );
        }
    }
}
