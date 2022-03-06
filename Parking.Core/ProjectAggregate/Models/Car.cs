using Parking.Core.ProjectAggregate.Models;

namespace Parking.Core.Models;

public class Car:BaseEntity
{
    public long Id { get; set; }
    public long? UserId { get; set; }
    public string? CarNumber { get; set; }
    public User? User { get; set; }

    public Car()
    {
        
    }
    public Car(long userId, string carNumber)
    {
        UserId = userId;
        CarNumber = carNumber;
    }
    public IEnumerable<Arrival>? Arrivals { get; set; }
    public bool IsDeleted { get; set; }
}