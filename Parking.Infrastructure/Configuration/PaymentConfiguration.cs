using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Parking.Core.Models;

namespace Parking.Infrastructure.Configuration;

public class PaymentConfiguration:IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(d => d.Arrival)
            .WithMany(p => p.Payments)
            .HasForeignKey(d => d.ArrivalId);
        builder.HasOne(d => d.Tariff)
            .WithMany(p => p.Payments)
            .HasForeignKey(d => d.TariffId);
        /*builder.Property(x => x.Sum)
            .HasComputedColumnSql("[dbo].[GetSum]([Id])",false);*/
    }
}