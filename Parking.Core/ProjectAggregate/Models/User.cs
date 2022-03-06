using AutoMapper;
using Parking.Core.Dtos;
using Parking.Core.Models;
using Parking.SharedKernel.Interfaces;

namespace Parking.Core.ProjectAggregate.Models;

public class User:IAggregateRoot,IMapFrom<UserDto>
{
    public long Id { get; set; }
    public bool IsDeleted { get; set; } 
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Patronumic { get; set; }
    public string? PhoneNumber { get; set;}
    
    public List<Car>? Cars { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<User, UserDto>();
        profile.CreateMap<UserDto,User>();
    }
}