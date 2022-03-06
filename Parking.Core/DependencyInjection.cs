using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Parking.Core.Interfaces;
using Parking.Core.Services;

namespace Parking.Core;

public static class DependencyInjection
{
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        services.AddTransient<IUserService, UserService>();
        services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        return services;
    }
}