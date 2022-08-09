using ETicaretAPI.Application.Repositories.CustomerRep;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repository.CustomerRep;

public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
{
    public CustomerReadRepository(ETicaretAPIDbContext context) : base(context)
    {
    }
}