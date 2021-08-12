using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection serviceCollection,
            IConfiguration configuration)
        {
            var connectionString = configuration[""];
            serviceCollection.AddDbContext<GameDbContext>(options => { options.UseNpgsql(connectionString); });
            serviceCollection.AddScoped<IGameDbContext>(provider => provider.GetService<GameDbContext>());
            return serviceCollection;
        }
        
        
    }
}