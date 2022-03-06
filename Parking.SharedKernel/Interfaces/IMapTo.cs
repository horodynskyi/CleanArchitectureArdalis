using AutoMapper;

namespace Parking.SharedKernel.Interfaces;

public interface IMapTo<T>
{
    void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType(), MemberList.Destination).DisableCtorValidation();
}