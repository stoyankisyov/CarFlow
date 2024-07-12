using CarFlow.Core.Models;

namespace CarFlow.Infrastructure.Mappers
{
    public static class CarMapper
    {
        /// <summary>
        /// Converts List of Models.Car/Entity/ to List of Core.Models.Car/DM/
        /// </summary>
        /// <param name="entities"></param>
        /// <returns> List of Core.Models.Car </returns>
        public static List<Core.Models.Car> ToDomainModel(this List<Models.Car> entities)
        {
            var carList = new List<Core.Models.Car>();

            foreach (var car in entities)
            {
                switch (car)
                {
                    case { CombustionEngineCar: not null }:
                        carList.Add(car.ToCombustionEngineCarDomainModel());
                        break;
                    case { ElectricCar: not null }:
                        carList.Add(car.ToElectricCarDomainModel());
                        break;
                }
            }

            return carList;
        }

        /// <summary>
        /// Converts Models.Car/Entity/ to Core.Models.Car/DM/
        /// </summary>
        /// <param name="entity"></param>
        /// <returns> Core.Models.Car </returns>
        public static Core.Models.Car ToDomainModel(this Models.Car entity) =>
            entity switch
            {
                { CombustionEngineCar: not null } => entity.ToCombustionEngineCarDomainModel(),
                { ElectricCar: not null } => entity.ToElectricCarDomainModel(),
                _ => throw new InvalidDataException("Invalid car type.")
            };

        /// <summary>
        /// Converts Core.Models.CombustionEngineCar/DM/ to Models.CombustionEngineCar/Entity/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> Models.CombustionEngineCar </returns>
        public static Models.CombustionEngineCar ToEntity(this Core.Models.CombustionEngineCar domainModel)
            => new()
            {
                Id = domainModel.Id,
                EngineId = domainModel.Engine.Id,
                EuroStandardId = domainModel.EuroStandard.Id,
                CityFuel = domainModel.CityFuel,
                CombinedFuel = domainModel.CombinedFuel,
                HighwayFuel = domainModel.HighwayFuel,
                IdNavigation = domainModel.ToCarEntity()
            };

        /// <summary>
        /// Converts Core.Models.ElectricCar/DM/ to Models.ElectricCar/Entity/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> Models.ElectricCar </returns>
        public static Models.ElectricCar ToEntity(this Core.Models.ElectricCar domainModel)
            => new()
            {
                Id = domainModel.Id,
                Horsepower = domainModel.Horsepower,
                Torque = domainModel.Torque,
                BatteryCapacity = domainModel.BatteryCapacity,
                Range = domainModel.Range,
                MotorCount = domainModel.MotorCount,
                IdNavigation = domainModel.ToCarEntity()
            };

        /// <summary>
        /// Converts Core.Models.CombustionEngineCar/DM/ to Models.Car/Entity/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> Models.Car </returns>
        private static Models.Car ToCarEntity(this Core.Models.CombustionEngineCar domainModel)
            => new()
            {
                Id = domainModel.Id,
                ModelId = domainModel.Model.Id,
                Generation = domainModel.Generation,
                BodyVariantId = domainModel.BodyVariant.Id,
                TransmissionVariantId = domainModel.TransmissionVariant.Id,
                DrivetrainId = domainModel.Drivetrain.Id,
                StartYear = domainModel.StartYear,
                EndYear = domainModel.EndYear
            };

        /// <summary>
        /// Converts Core.Models.ElectricCar/DM/ to Models.Car/Entity/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> Models.Car </returns>
        private static Models.Car ToCarEntity(this Core.Models.ElectricCar domainModel)
            => new()
            {
                Id = domainModel.Id,
                ModelId = domainModel.Model.Id,
                Generation = domainModel.Generation,
                BodyVariantId = domainModel.BodyVariant.Id,
                TransmissionVariantId = domainModel.TransmissionVariant.Id,
                DrivetrainId = domainModel.Drivetrain.Id,
                StartYear = domainModel.StartYear,
                EndYear = domainModel.EndYear
            };

        // TO DO: story 87
        /// <summary>
        /// Converts Models.Car/Entity/ to Core.Models.ElectricCar/DM/
        /// </summary>
        /// <param name="entity"></param>
        /// <returns> Core.Models.ElectricCar </returns>
        private static Core.Models.ElectricCar ToElectricCarDomainModel(this Models.Car entity)
            => new(entity.Id, entity.Model.Make.ToDomainModel(), entity.Model.ToDomainModel(), entity.Generation, new Body(1, "Sedan",
                    [entity.BodyVariant.ToDomainModel()]), entity.BodyVariant.ToDomainModel(), entity.TransmissionVariant.Transmission.ToDomainModel(),
                entity.TransmissionVariant.ToDomainModel(), entity.Drivetrain.ToDomainModel(), entity.StartYear, entity.EndYear,
                entity.ElectricCar!.Horsepower, entity.ElectricCar.Torque,
                entity.ElectricCar.BatteryCapacity, entity.ElectricCar.Range, entity.ElectricCar.MotorCount);

        // TO DO: story 87
        /// <summary>
        /// Converts Models.Car/Entity/ to Core.Models.CombustionEngineCar/DM/
        /// </summary>
        /// <param name="entity"></param>
        /// <returns> Core.Models.CombustionEngineCar </returns>
        private static Core.Models.CombustionEngineCar ToCombustionEngineCarDomainModel(this Models.Car entity)
            => new(entity.Id, entity.Model.Make.ToDomainModel(), entity.Model.ToDomainModel(), entity.Generation, new Body(1, "Sedan",
                    [entity.BodyVariant.ToDomainModel()]), entity.BodyVariant.ToDomainModel(), entity.TransmissionVariant.Transmission.ToDomainModel(),
                entity.TransmissionVariant.ToDomainModel(), entity.Drivetrain.ToDomainModel(), entity.StartYear, entity.EndYear, entity.CombustionEngineCar!.Engine.ToDomainModel(),
                entity.CombustionEngineCar.EuroStandard.ToDomainModel(), entity.CombustionEngineCar.CityFuel, entity.CombustionEngineCar.CombinedFuel, entity.CombustionEngineCar.HighwayFuel);
    }
}
