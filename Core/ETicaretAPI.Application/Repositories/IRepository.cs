using ETicaretAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace ETicaretAPI.Application.Repositories;

public interface IRepository <T> where T : BaseEntity 
{
    public DbSet<T> Table { get; }
}