namespace CarFlow.Infrastructure.Models;

public partial class Body
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<BodyVariant> BodyVariants { get; set; } = new List<BodyVariant>();
}
