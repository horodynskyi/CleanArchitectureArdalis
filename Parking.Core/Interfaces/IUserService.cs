using Parking.Core.Models;
using Parking.Core.ProjectAggregate.Models;

namespace Parking.Core.Interfaces;

public interface IUserService
{
    Task Create(User user);
    Task<List<User>> Get();
    Task<User> GetById(long id);
    Task Update(User user);
    Task Delete(long id);
}