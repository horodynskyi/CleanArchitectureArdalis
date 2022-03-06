using MediatR;
using Parking.Core.Interfaces;
using Parking.Core.Models;
using Parking.Core.ProjectAggregate.Models;
using Parking.Core.ProjectAggregate.Queries.UserQueries;
using Parking.SharedKernel.Interfaces;

namespace Parking.Core.ProjectAggregate.Handlers.UserHandlers;

public class UserGetHandler:IRequestHandler<UserGetQuery,List<User>>
{
    private readonly IRepository<User> _repository;
    public UserGetHandler(IRepository<User> repository)
    {
        _repository = repository;
    }

    public async Task<List<User>> Handle(UserGetQuery request, CancellationToken cancellationToken)
    {
        return await _repository.ListAsync(cancellationToken);
    }
}