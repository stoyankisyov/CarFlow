#nullable disable

namespace CarFlow.UI.Models.ViewModels
{
    public class PageViewModel<T>
    {
        public int CurrentPage { get; init; }
        public int PagesCount { get; init; }
        public int PageSize { get; init; }
        public List<T> Content { get; init; }
    }
}
