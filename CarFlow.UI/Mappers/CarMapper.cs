using CarFlow.Core.Models;
using CarFlow.UI.Enums;
using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Mappers
{
    public static class CarMapper
    {
        /// <summary>
        /// Converts List of Core.Models.Car/DM/ to List of CarViewModel/VM/
        /// </summary>
        /// <param name="domainModels"></param>
        /// <returns> List of CarViewModel </returns>
        public static List<CarViewModel> ToViewModel(this List<Core.Models.Car> domainModels)
        {
            var carViewModelList = new List<CarViewModel>();

            foreach (var car in domainModels)
            {
                switch (car)
                {
                    case Core.Models.CombustionEngineCar combustionEngineCar:
                        carViewModelList.Add(combustionEngineCar.ToViewModel());
                        break;
                    case Core.Models.ElectricCar electricCar:
                        carViewModelList.Add(electricCar.ToViewModel());
                        break;
                }
            }

            return carViewModelList;
        }

        /// <summary>
        /// Converts Core.Models.Car/DM/ to CarViewModel/VM/
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns> CarViewModel </returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static CarViewModel ToViewModel(this Core.Models.Car viewModel)
            => viewModel switch
            {
                ElectricCar electricCarDomainModel => electricCarDomainModel.ToViewModel(),
                CombustionEngineCar combustionEngineCarDomainModel => combustionEngineCarDomainModel.ToViewModel(),
                _ => throw new InvalidOperationException("Unknown view model type")
            };

        /// <summary>
        /// Converts CarViewModel/VM/ to Core.Models.Car/DM/
        /// </summary>
        /// <param name="viewViewModel"></param>
        /// <returns> Core.Models.Car </returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static Core.Models.Car ToDomainModel(this CarViewModel viewViewModel)
            => viewViewModel switch
            {
                ElectricCarViewViewModel electricCarViewModel => electricCarViewModel.ToDomainModel(),
                CombustionEngineCarViewViewModel combustionEngineCarViewModel =>
                    combustionEngineCarViewModel.ToDomainModel(),
                _ => throw new InvalidOperationException("Unknown view model type")
            };

        /// <summary>
        /// Converts CombustionEngineCarViewViewModel/VM/ to Core.Models.CombustionEngineCar/DM/
        /// </summary>
        /// <param name="viewViewModel"></param>
        /// <returns> Core.Models.CombustionEngineCar </returns>
        private static Core.Models.CombustionEngineCar ToDomainModel(this CombustionEngineCarViewViewModel viewViewModel)
            => new(viewViewModel.Id, viewViewModel.Make.ToDomainModel(), viewViewModel.Model.ToDomainModel(),
                viewViewModel.Generation, new Body(1, "Sedan",
                    [viewViewModel.BodyVariant.ToDomainModel()]), viewViewModel.BodyVariant.ToDomainModel(), viewViewModel.Transmission.ToDomainModel(),
                viewViewModel.TransmissionVariant.ToDomainModel(), viewViewModel.Drivetrain.ToDomainModel(),
                viewViewModel.StartYear, viewViewModel.EndYear, viewViewModel.Engine.ToDomainModel(),
                viewViewModel.Eurostandard.ToDomainModel(), viewViewModel.CityFuel,
                viewViewModel.CombinedFuel, viewViewModel.HighwayFuel);

        /// <summary>
        /// Converts ElectricCarViewViewModel/VM/ to Core.Models.ElectricCar/DM/
        /// </summary>
        /// <param name="viewViewModel"></param>
        /// <returns> Core.Models.ElectricCar </returns>
        private static Core.Models.ElectricCar ToDomainModel(this ElectricCarViewViewModel viewViewModel)
            => new(viewViewModel.Id, viewViewModel.Make.ToDomainModel(), viewViewModel.Model.ToDomainModel(),
                viewViewModel.Generation, new Body(1, "Sedan",
                    [viewViewModel.BodyVariant.ToDomainModel()]), viewViewModel.BodyVariant.ToDomainModel(), viewViewModel.Transmission.ToDomainModel(),
                viewViewModel.TransmissionVariant.ToDomainModel(), viewViewModel.Drivetrain.ToDomainModel(),
                viewViewModel.StartYear, viewViewModel.EndYear, viewViewModel.Horsepower, viewViewModel.Torque,
                viewViewModel.BatteryCapacity, viewViewModel.Range, viewViewModel.MotorCount);

        /// <summary>
        /// Converts Core.Models.CombustionEngineCar/DM/ to CombustionEngineCarViewViewModel/VM/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> CombustionEngineCarViewViewModel </returns>
        private static CombustionEngineCarViewViewModel ToViewModel(this Core.Models.CombustionEngineCar domainModel)
            => new()
            {
                Id = domainModel.Id,
                CarType = CarType.CombustionEngineCar,
                Generation = domainModel.Generation,
                StartYear = domainModel.StartYear,
                EndYear = domainModel.EndYear,
                Make = domainModel.Make.ToViewModel(),
                Model = domainModel.Model.ToViewModel(),
                Body = domainModel.Body.ToViewModel(),
                BodyVariant = domainModel.BodyVariant.ToViewModel(),
                Transmission = domainModel.Transmission.ToViewModel(),
                TransmissionVariant = domainModel.TransmissionVariant.ToViewModel(),
                Drivetrain = domainModel.Drivetrain.ToViewModel(),
                Engine = domainModel.Engine.ToViewModel(),
                Eurostandard = domainModel.EuroStandard.ToViewModel(),
                CityFuel = domainModel.CityFuel,
                CombinedFuel = domainModel.CombinedFuel,
                HighwayFuel = domainModel.HighwayFuel
            };

        /// <summary>
        /// Converts Core.Models.ElectricCar/DM/ to ElectricCarViewViewModel/VM/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> ElectricCarViewViewModel </returns>
        private static ElectricCarViewViewModel ToViewModel(this Core.Models.ElectricCar domainModel) =>
            new()
            {
                Id = domainModel.Id,
                CarType = CarType.ElectricCar,
                Make = domainModel.Make.ToViewModel(),
                Model = domainModel.Model.ToViewModel(),
                Generation = domainModel.Generation,
                Body = domainModel.Body.ToViewModel(),
                BodyVariant = domainModel.BodyVariant.ToViewModel(),
                Transmission = domainModel.Transmission.ToViewModel(),
                TransmissionVariant = domainModel.TransmissionVariant.ToViewModel(),
                Drivetrain = domainModel.Drivetrain.ToViewModel(),
                StartYear = domainModel.StartYear,
                EndYear = domainModel.EndYear,
                Horsepower = domainModel.Horsepower,
                Torque = domainModel.Torque,
                BatteryCapacity = domainModel.BatteryCapacity,
                Range = domainModel.Range,
                MotorCount = domainModel.MotorCount
            };
    }
}
