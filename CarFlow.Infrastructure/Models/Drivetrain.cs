namespace CarFlow.Infrastructure.Models;

public class Drivetrain(int id, string name)
{
    public int Id { get; init; } = id;

    public string Name { get; set; } = name;

    public ICollection<Car> Cars { get; set; } = new List<Car>();
}