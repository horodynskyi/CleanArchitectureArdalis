using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Parking.Infrastructure.DataBase;
using Parking.SharedKernel.Interfaces;

namespace Parking.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastracture(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddDbContext<DataContext>(options => options.UseSqlServer(
            configuration.GetConnectionString("EFConnection")));
        services.AddTransient(typeof(IRepository<>), typeof(EfRepository<>));
        return services;
    }
}