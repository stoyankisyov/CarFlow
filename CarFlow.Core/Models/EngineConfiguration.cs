namespace CarFlow.Core.Models
{
    public class EngineConfiguration(int id, string name, int cylinderCount)
    {
        public int Id { get; } = id;
        public string Name { get; } = name;
        public int CylinderCount { get; } = cylinderCount;
    }
}
