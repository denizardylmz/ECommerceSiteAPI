using ETicaretAPI.Application.Repositories.ProductRep;
using ETicaretAPI.Persistence.Contexts;
using ETicaretAPI.Domain.Entities;

namespace ETicaretAPI.Persistence.Repository.ProductRep;

public class ProductReadRepository : ReadRepository<Domain.Entities.Product>, IProductReadRepository
{
    public ProductReadRepository(ETicaretAPIDbContext context) : base(context)
    {
    }
}