
using Microsoft.EntityFrameworkCore;
using OdeToFood.Core;

namespace OdeToFood.Data
{
    public  class OdeToFoodDbContext : DbContext
    { 
        public OdeToFoodDbContext (DbContextOptions options)
            :base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=OdeToFood;Integrated Security=True;");
            }
        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
