using MediatR;
using Parking.Core.ProjectAggregate.Models;

namespace Parking.Core.ProjectAggregate.Queries.UserQueries;

public class UserGetByIdQuery:IRequest<User>
{
    public UserGetByIdQuery(long id)
    {
        Id = id;
    }

    public long Id { get; set; }
}