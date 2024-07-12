using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Mappers
{
    public static class FuelTypeMapper
    {
        /// <summary>
        /// Converts Core.Models.FuelType/DM/ to FuelTypeViewModel/VM/
        /// </summary>
        /// <param name="fuelType"></param>
        /// <returns> FuelTypeViewModel </returns>
        public static FuelTypeViewModel ToViewModel(this Core.Models.FuelType fuelType)
            => new()
            {
                Id = fuelType.Id,
                Name = fuelType.Name
            };

        /// <summary>
        /// Converts List of Core.Models.FuelType/DM/ to List of FuelTypeViewModel/VM/
        /// </summary>
        /// <param name="fuelTypes"></param>
        /// <returns> List of FuelTypeViewModel </returns>
        public static List<FuelTypeViewModel> ToViewModel(this List<Core.Models.FuelType> fuelTypes)
            => fuelTypes.Select(x => x.ToViewModel()).ToList();

        /// <summary>        
        /// Converts FuelTypeViewModel/VM/ to Core.Models.FuelType/DM/
        /// </summary>
        /// <param name="fuelType"></param>
        /// <returns> Core.Models.FuelType </returns>
        public static Core.Models.FuelType ToDomainModel(this FuelTypeViewModel fuelType)
            => new(fuelType.Id, fuelType.Name);
    }
}
