using Microsoft.EntityFrameworkCore;
using Parking.Core.Models;
using Parking.Core.ProjectAggregate.Models;
using Parking.Infrastructure.Configuration;

namespace Parking.Infrastructure.DataBase;

public class DataContext:DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    public DataContext() 
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-S0326N0;Initial Catalog=ParkingDb;Integrated Security=True");
        }
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Status> Statuses { get; set; }
    public DbSet<Tariff> Tariffs { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Arrival> Arrivals { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PaymentConfiguration());
        modelBuilder.ApplyConfiguration(new ArrivalConfiguration());
        modelBuilder.ApplyConfiguration(new TariffConfiguration());
        modelBuilder.ApplyConfiguration(new StatusConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new CarConfiguration());
        base.OnModelCreating(modelBuilder);
    }
}