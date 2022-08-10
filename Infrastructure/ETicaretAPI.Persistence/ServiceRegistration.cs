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
            options.UseNpgsql(Configurations.ConnectionString));

        collection.AddScoped<IProductWriteRepository, ProductWriteRepository>();
        collection.AddScoped<IProductReadRepository, ProductReadRepository>();
        
        collection.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
        collection.AddScoped<IOrderReadRepository, OrderReadRepository>();
        
        collection.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
        collection.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
        
    } 
}