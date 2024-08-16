#nullable disable

namespace CarFlow.UI.Models.ViewModels;

public class BrandViewModel
{
    public int Id { get; init; }

    public string Name { get; init; }

    public List<ModelViewModel> Models { get; init; }
}