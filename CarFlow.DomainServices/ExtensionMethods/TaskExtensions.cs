namespace CarFlow.DomainServices.ExtensionMethods;

public static class TaskExtensions
{
    public static async Task<T> ValidateNull<T>(this Task<T?> task, string errorMessage)
    {
        var result = await task;

        if (result is not null)
        {
            return result;
        }

        throw new ArgumentNullException(errorMessage);
    }
}