using CarFlow.Core.Models;
using CarFlow.Core.Models.Commands;
using CarFlow.Core.Repositories;
using CarFlow.DomainServices.Builders;
using CarFlow.DomainServices.ExtensionMethods;

namespace CarFlow.DomainServices.Handlers;

public class CombustionEngineCarUpdateHandler(
    IMakeRepository makeRepository,
    ITransmissionRepository transmissionRepository,
    IEngineRepository engineRepository)
    : PolymorphicCommandHandler<CarCommand, CombustionEngineCarUpdateCommand, Car>
{
    public override async Task<Car> Handle(CombustionEngineCarUpdateCommand command)
    {
        var model = await makeRepository
            .GetModelAsync(command.Model.Id)
            .ValidateNull("Model not found");
        var make = await makeRepository
            .GetAsync(model.MakeId)
            .ValidateNull("Make not found");
        var transmissionVariant = await transmissionRepository
            .GetVariantAsync(command.TransmissionVariant.Id)
            .ValidateNull("Transmission variant not found");
        var transmission = await transmissionRepository
            .GetAsync(transmissionVariant.TransmissionId)
            .ValidateNull("Transmission not found");
        var engine = await engineRepository
            .GetAsync(command.EngineId)
            .ValidateNull("Engine not found");

        // TODO: This is going to be improved in Task 87, after introducing body management. For now, it has to be hardcoded.
        var bodyVariant = LoadBodyVariant(command.BodyVariant.Id);
        var body = LoadBody(bodyVariant);

        var carBuilder = new CombustionEngineCarBuilder();
        var car = carBuilder.WithId(command.Id)
            .WithMake(make)
            .WithModel(model)
            .WithGeneration(command.Generation)
            .WithBody(body)
            .WithBodyVariant(bodyVariant)
            .WithTransmission(transmission)
            .WithTransmissionVariant(transmissionVariant)
            .WithDrivetrain(command.Drivetrain)
            .WithStartYear(command.StartYear)
            .WithEndYear(command.EndYear)
            .WithEngine(engine)
            .WithEuroStandard(command.EuroStandard)
            .WithCityFuel(command.CityFuel)
            .WithCombinedFuel(command.CombinedFuel)
            .WithHighwayFuel(command.HighwayFuel)
            .Build();

        return car;
    }

    // TODO: This is going to be improved in Task 87, after introducing body management. For now, it has to be hardcoded.
    private static BodyVariant LoadBodyVariant(int bodyVariantId)
        => new(bodyVariantId, 1, 2, 3);

    private static Body LoadBody(BodyVariant bodyVariant)
        => new(1, "Sedan", [bodyVariant]);
}