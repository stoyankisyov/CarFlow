#nullable disable

namespace CarFlow.UI.Models.ViewModels;

public class RegionViewModel
{
    public int Id { get; init; }
    public string Name { get; init; }
    public List<SubregionViewModel> Subregions { get; init; }
}