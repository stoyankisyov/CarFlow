using CarFlow.Core.Models;
using CarFlow.Core.Models.Commands;
using CarFlow.Core.Repositories;
using CarFlow.DomainServices.Builders;
using CarFlow.DomainServices.ExtensionMethods;

namespace CarFlow.DomainServices.Handlers;

public class ElectricCarCreateHandler(
    IBrandRepository brandRepository,
    ITransmissionRepository transmissionRepository)
    : PolymorphicCommandHandler<CarCommand, ElectricCarCreateCommand, Car>
{
    public override async Task<Car> Handle(ElectricCarCreateCommand command)
    {
        var model = await brandRepository
            .GetModelAsync(command.Model.Id)
            .ValidateNull("Model not found");
        var brand = await brandRepository
            .GetAsync(model.BrandId)
            .ValidateNull("Brand not found");
        var transmissionVariant = await transmissionRepository
            .GetVariantAsync(command.TransmissionVariant.Id)
            .ValidateNull("Transmission variant not found");
        var transmission = await transmissionRepository
            .GetAsync(transmissionVariant.TransmissionId)
            .ValidateNull("Transmission not found");

        // TODO: This is going to be improved in Task 87, after introducing body management. For now, it has to be hardcoded.
        var bodyVariant = LoadBodyVariant(command.BodyVariant.Id);
        var body = LoadBody(bodyVariant);

        var carBuilder = new ElectricCarBuilder();
        var car = carBuilder.WithId(0)
            .WithBrand(brand)
            .WithModel(model)
            .WithGeneration(command.Generation)
            .WithBody(body)
            .WithBodyVariant(bodyVariant)
            .WithTransmission(transmission)
            .WithTransmissionVariant(transmissionVariant)
            .WithDrivetrain(command.Drivetrain)
            .WithStartYear(command.StartYear)
            .WithEndYear(command.EndYear)
            .WithHorsepower(command.Horsepower)
            .WithTorque(command.Torque)
            .WithBatteryCapacity(command.BatteryCapacity)
            .WithRange(command.Range)
            .WithMotorCount(command.MotorCount)
            .Build();

        return (ElectricCar)car;
    }

    // TODO: This is going to be improved in Task 87, after introducing body management. For now, it has to be hardcoded.
    private static BodyVariant LoadBodyVariant(int bodyVariantId)
        => new(bodyVariantId, 1, 2, 3);

    private static Body LoadBody(BodyVariant bodyVariant)
        => new(1, "Sedan", [bodyVariant]);
}