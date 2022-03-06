using Ardalis.Specification;
using Parking.Core.Models;
using Parking.Core.ProjectAggregate.Models;

namespace Parking.Core.Specifications.UserSpecifications;

public sealed class UserGetByIdSpec:Specification<User>, ISingleResultSpecification
{
    public UserGetByIdSpec(long userId)
    {
        Query
            .Where(user => user.Id == userId);
    }
}