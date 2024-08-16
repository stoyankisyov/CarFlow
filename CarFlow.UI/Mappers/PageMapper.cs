using CarFlow.Core.Models;
using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Mappers;

public static class PageMapper
{
    /// <summary>
    ///     Converts a domain model of regions to a view model representing a paged collection of regions.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of view model representing a paged collection of regions.</returns>
    public static PageViewModel<RegionViewModel> ToViewModel(this Page<Region> domainModel)
        => new()
        {
            PagesCount = domainModel.PageCount,
            PageSize = domainModel.PageSize,
            CurrentPage = domainModel.CurrentPage,
            Content = domainModel.Content.ToViewModel()
        };

    /// <summary>
    ///     Converts a domain model of transmissions to a view model representing a paged collection of transmissions.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of view model representing a paged collection of transmissions.</returns>
    public static PageViewModel<TransmissionViewModel> ToViewModel(this Page<Transmission> domainModel)
        => new()
        {
            PagesCount = domainModel.PageCount,
            PageSize = domainModel.PageSize,
            CurrentPage = domainModel.CurrentPage,
            Content = domainModel.Content.ToViewModel()
        };

    /// <summary>
    ///     Converts a domain model of drivetrains to a view model representing a paged collection of drivetrains.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of view model representing a paged collection of drivetrains.</returns>
    public static PageViewModel<DrivetrainViewModel> ToViewModel(this Page<Drivetrain> domainModel)
        => new()
        {
            PagesCount = domainModel.PageCount,
            PageSize = domainModel.PageSize,
            CurrentPage = domainModel.CurrentPage,
            Content = domainModel.Content.ToViewModel()
        };

    /// <summary>
    ///     Converts a domain model of brands to a view model representing a paged collection of brands.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of view model representing a paged collection of brands.</returns>
    public static PageViewModel<BrandViewModel> ToViewModel(this Page<Brand> domainModel)
        => new()
        {
            PagesCount = domainModel.PageCount,
            PageSize = domainModel.PageSize,
            CurrentPage = domainModel.CurrentPage,
            Content = domainModel.Content.ToViewModel()
        };

    /// <summary>
    ///     Converts a domain model of fuel types to a view model representing a paged collection of fuel types.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of view model representing a paged collection of fuel types.</returns>
    public static PageViewModel<FuelTypeViewModel> ToViewModel(this Page<FuelType> domainModel)
        => new()
        {
            PagesCount = domainModel.PageCount,
            PageSize = domainModel.PageSize,
            CurrentPage = domainModel.CurrentPage,
            Content = domainModel.Content.ToViewModel()
        };

    /// <summary>
    ///     Converts a domain model of engine configurations to a view model representing a paged collection of engine
    ///     configurations.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of view model representing a paged collection of engine configurations.</returns>
    public static PageViewModel<EngineConfigurationViewModel> ToViewModel(this Page<EngineConfiguration> domainModel)
        => new()
        {
            PagesCount = domainModel.PageCount,
            PageSize = domainModel.PageSize,
            CurrentPage = domainModel.CurrentPage,
            Content = domainModel.Content.ToViewModel()
        };

    /// <summary>
    ///     Converts a domain model of engine aspirations to a view model representing a paged collection of engine
    ///     aspirations.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of view model representing a paged collection of engine aspirations.</returns>
    public static PageViewModel<EngineAspirationViewModel> ToViewModel(this Page<EngineAspiration> domainModel)
        => new()
        {
            PagesCount = domainModel.PageCount,
            PageSize = domainModel.PageSize,
            CurrentPage = domainModel.CurrentPage,
            Content = domainModel.Content.ToViewModel()
        };

    /// <summary>
    ///     Converts a domain model of engines to a view model representing a paged collection of engines.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of view model representing a paged collection of engines.</returns>
    public static PageViewModel<EngineViewModel> ToViewModel(this Page<Engine> domainModel)
        => new()
        {
            PagesCount = domainModel.PageCount,
            PageSize = domainModel.PageSize,
            CurrentPage = domainModel.CurrentPage,
            Content = domainModel.Content.ToViewModel()
        };

    /// <summary>
    ///     Converts a domain model of cars to a view model representing a paged collection of cars.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of view model representing a paged collection of cars.</returns>
    public static PageViewModel<CarViewModel> ToViewModel(this Page<Car> domainModel)
        => new()
        {
            PagesCount = domainModel.PageCount,
            PageSize = domainModel.PageSize,
            CurrentPage = domainModel.CurrentPage,
            Content = domainModel.Content.ToViewModel()
        };
}