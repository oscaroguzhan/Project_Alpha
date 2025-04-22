using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Data.Contexts;
// this class is used to manage in design-time the creation of the database (so we can use the dotnet ef migrations commands)
public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
{
    public DataContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
        optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=AlphaDB;User Id=sa;Password=CodeGuruOzzy2025!?;TrustServerCertificate=True");

        return new DataContext(optionsBuilder.Options);
    }
}