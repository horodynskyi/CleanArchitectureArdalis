namespace Parking.Core.Models;

public class Payment:BaseEntity
{
    public long Id { get; set; }
    public bool IsDeleted { get; set; }
    public long? TariffId { get; set; }
    public long? ArrivalId { get; set;  }
    public string EndPark { get; set; } = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
    public float? Sum { get; set; }
    
    public Arrival? Arrival { get; set;  }
    public Tariff? Tariff { get; set;}
}