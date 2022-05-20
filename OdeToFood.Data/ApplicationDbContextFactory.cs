
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using OdeToFood.Data;

public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<OdeToFoodDbContext>
{
    public OdeToFoodDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<OdeToFoodDbContext>();
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=OdeToFood;Integrated Security=True;");

        return new OdeToFoodDbContext(optionsBuilder.Options);

        //lalalla
    }
}