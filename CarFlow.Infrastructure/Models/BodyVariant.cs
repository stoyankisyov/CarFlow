namespace CarFlow.Infrastructure.Models;

public partial class BodyVariant
{
    public int Id { get; set; }

    public int BodyId { get; set; }

    public int DoorCount { get; set; }

    public int SeatCount { get; set; }

    public virtual Body Body { get; set; } = null!;

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
}
