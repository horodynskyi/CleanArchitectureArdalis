using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Parking.Core.Models;
using Parking.Core.ProjectAggregate.Models;

namespace Parking.Infrastructure.Configuration;

public class UserConfiguration:IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.Id);
       
    }
}