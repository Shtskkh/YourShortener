using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace YourShortener.Infrastructure;

public class YourShortenerDbContext(DbContextOptions<YourShortenerDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
