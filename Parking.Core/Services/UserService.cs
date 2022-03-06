using Parking.Core.Interfaces;
using Parking.Core.Models;
using Parking.Core.ProjectAggregate.Models;
using Parking.Core.Specifications.UserSpecifications;
using Parking.SharedKernel.Interfaces;

namespace Parking.Core.Services;

public class UserService:IUserService
{
    private readonly IRepository<User> _repository;

    public UserService(IRepository<User> repository)
    {
        _repository = repository;
    }

    public async Task Create(User user)
    { 
        throw new NotImplementedException();
    }

    public async Task<List<User>> Get()
    {
        var users = await _repository.ListAsync();
        return users;
    }

    public async Task<User> GetById(long id)
    {
        var spec = new UserGetByIdSpec(id);
        var user = await _repository.GetBySpecAsync(spec);
        return user;
    }

    public async Task Update(User user)
    {
        throw new NotImplementedException();
    }

    public async Task Delete(long id)
    {
        throw new NotImplementedException();
    }
}