using CarFlow.Core.Models;
using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Mappers
{
    public static class PageMapper
    {
        /// <summary>
        /// Converts Page of Region/DM/ to PageViewModel of RegionViewModel/VM/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> PageViewModel of RegionViewModel </returns>
        public static PageViewModel<RegionViewModel> ToViewModel(this Page<Region> domainModel)
            => new()
            {
                PagesCount = domainModel.PageCount,
                PageSize = domainModel.PageSize,
                CurrentPage = domainModel.CurrentPage,
                Content = domainModel.Content.ToViewModel()
            };

        /// <summary>
        /// Converts Page of Transmission/DM/ to PageViewModel of TransmissionViewModel/VM/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> PageViewModel of TransmissionViewModel </returns>
        public static PageViewModel<TransmissionViewModel> ToViewModel(this Page<Transmission> domainModel)
            => new()
            {
                PagesCount = domainModel.PageCount,
                PageSize = domainModel.PageSize,
                CurrentPage = domainModel.CurrentPage,
                Content = domainModel.Content.ToViewModel()
            };

        /// <summary>
        /// Converts Page of Drivetrain/DM/ to PageViewModel of DrivetrainViewModel/VM/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> PageViewModel of DrivetrainViewModel </returns>
        public static PageViewModel<DrivetrainViewModel> ToViewModel(this Page<Drivetrain> domainModel)
            => new()
            {
                PagesCount = domainModel.PageCount,
                PageSize = domainModel.PageSize,
                CurrentPage = domainModel.CurrentPage,
                Content = domainModel.Content.ToViewModel()
            };

        /// <summary>
        /// Converts Page of Model/DM/ to PageViewModel of ModelViewModel/VM/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> PageViewModel of ModelViewModel </returns>
        public static PageViewModel<MakeViewModel> ToViewModel(this Page<Make> domainModel)
            => new()
            {
                PagesCount = domainModel.PageCount,
                PageSize = domainModel.PageSize,
                CurrentPage = domainModel.CurrentPage,
                Content = domainModel.Content.ToViewModel()
            };

        /// <summary>
        /// Converts Page of FuelType/DM/ to PageViewModel of FuelTypeViewModel/VM/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> PageViewModel of FuelTypeViewModel </returns>
        public static PageViewModel<FuelTypeViewModel> ToViewModel(this Page<FuelType> domainModel)
            => new()
            {
                PagesCount = domainModel.PageCount,
                PageSize = domainModel.PageSize,
                CurrentPage = domainModel.CurrentPage,
                Content = domainModel.Content.ToViewModel()
            };

        /// <summary>
        /// Converts Page of EngineConfiguration/DM/ to PageViewModel of EngineConfiguration/VM/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> PageViewModel of EngineConfiguration </returns>
        public static PageViewModel<EngineConfigurationViewModel> ToViewModel(this Core.Models.Page<EngineConfiguration> domainModel)
            => new()
            {
                PagesCount = domainModel.PageCount,
                PageSize = domainModel.PageSize,
                CurrentPage = domainModel.CurrentPage,
                Content = domainModel.Content.ToViewModel()
            };

        /// <summary>
        /// Converts Page of EngineAspiration/DM/ to PageViewModel of EngineAspiration/VM/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> PageViewModel of EngineAspiration </returns>
        public static PageViewModel<EngineAspirationViewModel> ToViewModel(this Core.Models.Page<EngineAspiration> domainModel)
            => new()
            {
                PagesCount = domainModel.PageCount,
                PageSize = domainModel.PageSize,
                CurrentPage = domainModel.CurrentPage,
                Content = domainModel.Content.ToViewModel()
            };

        /// <summary>
        /// Converts Page of Engine/DM/ to PageViewModel of EngineViewModel/VM/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> PageViewModel of EngineViewModel </returns>
        public static PageViewModel<EngineViewModel> ToViewModel(this Core.Models.Page<Engine> domainModel)
            => new()
            {
                PagesCount = domainModel.PageCount,
                PageSize = domainModel.PageSize,
                CurrentPage = domainModel.CurrentPage,
                Content = domainModel.Content.ToViewModel()
            };

        /// <summary>
        /// Converts Page of Car/DM/ to PageViewModel of CarViewModel/VM/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> PageViewModel of CarViewModel </returns>
        public static PageViewModel<CarViewModel> ToViewModel(this Core.Models.Page<Car> domainModel)
            => new()
            {
                PagesCount = domainModel.PageCount,
                PageSize = domainModel.PageSize,
                CurrentPage = domainModel.CurrentPage,
                Content = domainModel.Content.ToViewModel()
            };
    }
}
