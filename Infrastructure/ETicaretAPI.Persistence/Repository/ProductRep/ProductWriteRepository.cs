using ETicaretAPI.Application.Repositories.ProductRep;
using ETicaretAPI.Persistence.Contexts;
using ETicaretAPI.Domain.Entities;

namespace ETicaretAPI.Persistence.Repository.ProductRep;

public class ProductWriteRepository : WriteRepository<Domain.Entities.Product>, IProductWriteRepository
{
    public ProductWriteRepository(ETicaretAPIDbContext context) : base(context)
    {
    }
}