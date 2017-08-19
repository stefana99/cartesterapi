using Microsoft.EntityFrameworkCore;

namespace CarTest.Models
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options) : base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<BasicCar> BasicCars {get; set;}
        public DbSet<BasicUser> BasicUser {get ; set;}
    }
}