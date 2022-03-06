using MediatR;
using Parking.Core.Dtos;
using Parking.Core.ProjectAggregate.Models;
using Parking.Core.ProjectAggregate.Queries.UserQueries;
using Parking.SharedKernel.Interfaces;

namespace Parking.Core.ProjectAggregate.Handlers.UserHandlers;

public class UserGetByIdHandler:IRequestHandler<UserGetByIdQuery,User>
{
    private readonly IRepository<User> _repository;

    public UserGetByIdHandler(IRepository<User> repository)
    {
        _repository = repository;
    }

    public async Task<User> Handle(UserGetByIdQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetByIdAsync(request.Id, cancellationToken);
    }
}