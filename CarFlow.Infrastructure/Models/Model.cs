namespace CarFlow.Infrastructure.Models;

public partial class Model
{
    public int Id { get; set; }

    public int MakeId { get; set; }

    public string Name { get; set; } = null!;

    public string? ModelVariant { get; set; }

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();

    public virtual Make Make { get; set; } = null!;

    public virtual ICollection<Feature> Features { get; set; } = new List<Feature>();
}
