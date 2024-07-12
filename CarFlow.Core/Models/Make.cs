namespace CarFlow.Core.Models
{
    public class Make(int id, string name, List<Model> models)
    {
        public int Id { get; } = id;
        public string Name { get; } = name;
        public List<Model> Models { get; } = models;
    }
}