using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Parking.Core.Models;

namespace Parking.Infrastructure.Configuration;

public class CarConfiguration:IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(d => d.User)
            .WithMany(p => p.Cars)
            .HasForeignKey( d=> d.UserId);
       // builder.HasQueryFilter(m => EF.Property<bool>(m, "IsDeleted") == false);
    }
}