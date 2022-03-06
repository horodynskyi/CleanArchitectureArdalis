namespace Parking.Core.Models;

public class Arrival:BaseEntity
{
    public long Id { get; set; }
    public bool IsDeleted { get; set; }
    public long? CarId { get; set; }
    public string StartPark { get; set; } = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
    public long? StatusId { get; set; }
    public Status? Status { get; set; }
    public Car? Car { get; set; }
    public List<Payment>? Payments { get; set; }
}