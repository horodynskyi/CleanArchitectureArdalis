using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Parking.Core.Models;

namespace Parking.Infrastructure.Configuration;

public class TariffConfiguration:IEntityTypeConfiguration<Tariff>
{
    public void Configure(EntityTypeBuilder<Tariff> builder)
    {
        builder.HasKey(x => x.Id);
      
    }
}