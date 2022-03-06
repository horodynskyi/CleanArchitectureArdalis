using Ardalis.Specification;

namespace Parking.SharedKernel.Interfaces;

public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
{
}