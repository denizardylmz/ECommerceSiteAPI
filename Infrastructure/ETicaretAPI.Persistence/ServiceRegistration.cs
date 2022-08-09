using ETicaretAPI.Application.Repositories.CustomerRep;
using ETicaretAPI.Application.Repositories.OrderRep;
using ETicaretAPI.Application.Repositories.ProductRep;
using ETicaretAPI.Persistence.Contexts;
using ETicaretAPI.Persistence.Repository.CustomerRep;
using ETicaretAPI.Persistence.Repository.OrderRep;
using ETicaretAPI.Persistence.Repository.ProductRep;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretAPI.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceRegistration(this IServiceCollection collection)
    {
        collection.AddDbContext<ETicaretAPIDbContext>(options => 
            options.UseNpgsql(Configurations.ConnectionString), ServiceLifetime.Singleton);

        collection.AddSingleton<IProductWriteRepository, ProductWriteRepository>();
        collection.AddSingleton<IProductReadRepository, ProductReadRepository>();
        
        collection.AddSingleton<IOrderWriteRepository, OrderWriteRepository>();
        collection.AddSingleton<IOrderReadRepository, OrderReadRepository>();
        
        collection.AddSingleton<ICustomerWriteRepository, CustomerWriteRepository>();
        collection.AddSingleton<ICustomerReadRepository, CustomerReadRepository>();
        
    } 
}