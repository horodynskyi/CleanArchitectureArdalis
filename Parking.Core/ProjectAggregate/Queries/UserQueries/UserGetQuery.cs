using MediatR;
using Parking.Core.Models;
using Parking.Core.ProjectAggregate.Models;

namespace Parking.Core.ProjectAggregate.Queries.UserQueries;

public class UserGetQuery:IRequest<List<User>>
{
    
}