using CarFlow.Core.Models;

namespace CarFlow.DomainServices.Builders;

public class ElectricCarBuilderBase<TBuilder>
    : CarBuilder<ElectricCarBuilderBase<TBuilder>>
    where TBuilder : ElectricCarBuilderBase<TBuilder>
{
    private int _batteryCapacity;
    private int _horsepower;
    private int _motorCount;
    private int _range;
    private int _torque;

    public override Car Build() =>
        new ElectricCar(Id, Brand, Model, Generation, Body, BodyVariant, Transmission,
            TransmissionVariant, Drivetrain, StartYear, EndYear, _horsepower, _torque, _batteryCapacity, _range,
            _motorCount);

    public TBuilder WithHorsepower(int horsepower)
    {
        _horsepower = horsepower;

        return (TBuilder)this;
    }

    public TBuilder WithTorque(int torque)
    {
        _torque = torque;

        return (TBuilder)this;
    }

    public TBuilder WithBatteryCapacity(int batteryCapacity)
    {
        _batteryCapacity = batteryCapacity;

        return (TBuilder)this;
    }

    public TBuilder WithRange(int range)
    {
        _range = range;

        return (TBuilder)this;
    }

    public TBuilder WithMotorCount(int motorCount)
    {
        _motorCount = motorCount;

        return (TBuilder)this;
    }
}