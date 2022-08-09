using ETicaretAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretAPI.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceRegistration(this IServiceCollection collection)
    {
        collection.AddDbContext<ETicaretAPIDbContext>(options => 
            options.UseNpgsql(Configurations.ConnectionString));
    } 
}