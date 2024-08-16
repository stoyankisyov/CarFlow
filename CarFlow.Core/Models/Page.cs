namespace CarFlow.Core.Models;

public class Page<T>(int currentPage, int pageCount, int pageSize, List<T> content)
{
    public int CurrentPage { get; } = currentPage;

    public int PageCount { get; } = pageCount;

    public int PageSize { get; } = pageSize;

    public List<T> Content { get; } = content;
}