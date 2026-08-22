using Microsoft.EntityFrameworkCore;

namespace YourShortener.Infrastructure;

public static class InfrastructureExtensions
{
    extension(IServiceCollection services)
    {
        public void AddInfrastructure(IConfiguration configuration)
        {
            // TODO: add connection string to the appsettings.Development.json
            services.AddDbContextPool<YourShortenerDbContext>(
                options => options.UseNpgsql(configuration.GetConnectionString("YourShortenerDbContext"))
            );
        }
    }
}
