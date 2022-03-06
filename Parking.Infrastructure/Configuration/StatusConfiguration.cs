using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Parking.Core.Models;

namespace Parking.Infrastructure.Configuration;

public class StatusConfiguration:IEntityTypeConfiguration<Status>
{
    public void Configure(EntityTypeBuilder<Status> builder)
    {
        builder.HasKey(x => x.Id);
    }
}