using ETicaretAPI.Application.Repositories.OrderRep;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repository.OrderRep;

public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
{
    public OrderWriteRepository(ETicaretAPIDbContext context) : base(context)
    {
    }
}