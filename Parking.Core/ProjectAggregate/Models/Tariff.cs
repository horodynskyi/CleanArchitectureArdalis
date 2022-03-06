namespace Parking.Core.Models;

public class Tariff:BaseEntity
{
    public long Id { get; set; }
    public bool IsDeleted { get; set; }
    public string? Name { get; set; }
    public float? Price { get; set; }
    public List<Payment>? Payments { get; set; }
}