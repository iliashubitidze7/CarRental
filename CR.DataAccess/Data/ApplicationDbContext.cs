using CR.Models;
using Microsoft.EntityFrameworkCore;


namespace CR.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Car>().HasData(
                    new Car
                    {
                        Id = 1,
                        Model = "Mercedes CLS 5.5 2020",
                        Type = "Sedan",
                        Interior = "leathar",
                        Fuel = "Gasoline",
                        Transmission = "Authomatic",
                        Seats = "4",
                        Price = 100,
                        PriceFor8 = 80
                    },

                    new Car
                    {
                        Id = 2,
                        Model = "Mazda 6 2.0 2016",
                        Type = "Sedan",
                        Interior = "Fabric",
                        Fuel = "Gasoline",
                        Transmission = "Authomatic",
                        Seats = "5",
                        Price = 70,
                        PriceFor8 = 50
                    },
                    new Car
                    {
                        Id = 3,
                        Model = "BMW X5 4.0 2018",
                        Type = "Sedan",
                        Interior = "leathar",
                        Fuel = "Gasoline",
                        Transmission = "Mechanical",
                        Seats = "4",
                        Price = 90,
                        PriceFor8 = 70
                    },
                    new Car
                    {
                        Id = 4,
                        Model = "Mecedes Viano 2.5 2021",
                        Type = "Van",
                        Interior = "Fabric",
                        Fuel = "Diesel",
                        Transmission = "Authomatic",
                        Seats = "7",
                        Price = 120,
                        PriceFor8 = 100
                    }

                );
        }
    }
}
