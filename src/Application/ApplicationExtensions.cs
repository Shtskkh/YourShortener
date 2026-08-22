using System.Reflection;

namespace YourShortener.Application;

public static class ApplicationExtensions
{
    extension(IServiceCollection services)
    {
        public void AddApplication()
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        }
    }
}
