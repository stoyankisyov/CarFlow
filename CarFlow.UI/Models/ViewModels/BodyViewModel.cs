#nullable disable

namespace CarFlow.UI.Models.ViewModels
{
    public class BodyViewModel
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public List<BodyVariantViewModel> Variants { get; init; }
    }
}
