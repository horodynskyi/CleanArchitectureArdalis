using Ardalis.Specification.EntityFrameworkCore;
using Parking.Infrastructure.DataBase;
using Parking.SharedKernel.Interfaces;

namespace Parking.Infrastructure;

public class EfRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class, IAggregateRoot
{
    public EfRepository(DataContext dbContext) : base(dbContext)
    {
    }
}