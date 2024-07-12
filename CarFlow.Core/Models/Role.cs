namespace CarFlow.Core.Models
{
    public class Role(int id, string name)
    {
        public int Id { get; } = id;
        public string Name { get; } = name;
    }
}
