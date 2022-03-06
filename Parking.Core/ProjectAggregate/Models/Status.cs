namespace Parking.Core.Models;

public class Status:BaseEntity
{
    public long Id { get; set; }
    public bool IsDeleted { get; set; }
    public string? Name { get; set; }
    public IEnumerable<Arrival>? Arrivals { get; set; }
}