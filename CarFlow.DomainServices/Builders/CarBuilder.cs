#nullable disable

using CarFlow.Core.Models;

namespace CarFlow.DomainServices.Builders;

public abstract class CarBuilder<TSelf>
    where TSelf : CarBuilder<TSelf>
{
    protected Body Body;
    protected BodyVariant BodyVariant;
    protected Brand Brand;
    protected Drivetrain Drivetrain;
    protected DateOnly? EndYear;
    protected string Generation;
    protected int Id;
    protected Model Model;
    protected DateOnly StartYear;
    protected Transmission Transmission;
    protected TransmissionVariant TransmissionVariant;

    public TSelf WithId(int id)
    {
        Id = id;

        return (TSelf)this;
    }

    public TSelf WithBrand(Brand brand)
    {
        Brand = brand;

        return (TSelf)this;
    }

    public TSelf WithModel(Model model)
    {
        Model = model;

        return (TSelf)this;
    }

    public TSelf WithGeneration(string generation)
    {
        Generation = generation;

        return (TSelf)this;
    }

    public TSelf WithBody(Body body)
    {
        Body = body;

        return (TSelf)this;
    }

    public TSelf WithBodyVariant(BodyVariant bodyVariant)
    {
        BodyVariant = bodyVariant;

        return (TSelf)this;
    }

    public TSelf WithTransmission(Transmission transmission)
    {
        Transmission = transmission;

        return (TSelf)this;
    }

    public TSelf WithTransmissionVariant(TransmissionVariant transmissionVariant)
    {
        TransmissionVariant = transmissionVariant;

        return (TSelf)this;
    }

    public TSelf WithDrivetrain(Drivetrain drivetrain)
    {
        Drivetrain = drivetrain;

        return (TSelf)this;
    }

    public TSelf WithStartYear(DateOnly startYear)
    {
        StartYear = startYear;

        return (TSelf)this;
    }

    public TSelf WithEndYear(DateOnly? endYear)
    {
        EndYear = endYear;

        return (TSelf)this;
    }

    public abstract Car Build();
}