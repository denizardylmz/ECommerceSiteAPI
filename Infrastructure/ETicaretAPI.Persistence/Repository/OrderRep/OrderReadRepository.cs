using ETicaretAPI.Application.Repositories.OrderRep;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repository.OrderRep;

public class OrderReadRepository : ReadRepository<Domain.Entities.Order>, IOrderReadRepository
{
    public OrderReadRepository(ETicaretAPIDbContext context) : base(context)
    {
    }
}