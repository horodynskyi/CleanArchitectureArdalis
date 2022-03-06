using AutoMapper;
using Parking.Core.Models;
using Parking.Core.ProjectAggregate.Models;
using Parking.SharedKernel.Interfaces;

namespace Parking.Core.Dtos;

public class UserDto:IMapTo<User>
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Patronumic { get; set; }
    public string? PhoneNumber { get; set;}
    
    public void Mapping(Profile profile)
    {
        profile.CreateMap<UserDto, User>();
        profile.CreateMap<User, UserDto>();
    }
}