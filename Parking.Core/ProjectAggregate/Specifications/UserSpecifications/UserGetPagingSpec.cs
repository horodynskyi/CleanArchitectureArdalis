using Ardalis.Specification;
using Parking.Core.Models;
using Parking.Core.ProjectAggregate.Models;

namespace Parking.Core.Specifications.UserSpecifications;

public class UserGetPagingSpec:Specification<User>, ISingleResultSpecification
{
    public UserGetPagingSpec(int pageNumber,int pageSize,bool isPagingEnabled)
    {
        Query
            .Skip(pageNumber*(pageSize-1))
            .Take(pageSize);
    }
}