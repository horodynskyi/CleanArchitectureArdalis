using Parking.SharedKernel.Interfaces;

namespace Parking.Core.Models;

public abstract class BaseEntity
{
    public long Id { get; set; }
    public bool IsDeleted { get; set; }
}