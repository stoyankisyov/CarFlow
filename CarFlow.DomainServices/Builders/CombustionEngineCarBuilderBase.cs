#nullable disable

using CarFlow.Core.Models;

namespace CarFlow.DomainServices.Builders;

public class CombustionEngineCarBuilderBase<TBuilder>
    : CarBuilder<CombustionEngineCarBuilderBase<TBuilder>>
    where TBuilder : CombustionEngineCarBuilderBase<TBuilder>
{
    private decimal? _cityFuel;
    private decimal? _combinedFuel;
    private Engine _engine;
    private EuroStandard _euroStandard;
    private decimal? _highwayFue;

    public override Car Build() =>
        new CombustionEngineCar(Id, Brand, Model, Generation, Body, BodyVariant, Transmission,
            TransmissionVariant, Drivetrain, StartYear, EndYear, _engine, _euroStandard, _cityFuel,
            _combinedFuel, _highwayFue);

    public TBuilder WithEngine(Engine engine)
    {
        _engine = engine;

        return (TBuilder)this;
    }

    public TBuilder WithEuroStandard(EuroStandard euroStandard)
    {
        _euroStandard = euroStandard;

        return (TBuilder)this;
    }

    public TBuilder WithCityFuel(decimal? cityFuel)
    {
        _cityFuel = cityFuel;

        return (TBuilder)this;
    }

    public TBuilder WithCombinedFuel(decimal? combinedFuel)
    {
        _combinedFuel = combinedFuel;

        return (TBuilder)this;
    }

    public TBuilder WithHighwayFuel(decimal? highwayFuel)
    {
        _highwayFue = highwayFuel;

        return (TBuilder)this;
    }
}