using Car_Service.Models;
using System.Data.Entity;

namespace Car_Service.Context
{
    public class CarContext : DbContext
    {
        public CarContext() : base("name=CarServiceDBConnectionString")
        {
           // Database.SetInitializer<CarContext>(new CreateDatabaseIfNotExists<CarContext>());
        }

        public DbSet<CarDetails> CarDetails { get; set; }
    }
}