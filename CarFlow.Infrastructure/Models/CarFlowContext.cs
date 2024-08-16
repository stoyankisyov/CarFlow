using CarFlow.Infrastructure.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace CarFlow.Infrastructure.Models;

public class CarFlowContext : DbContext
{
    public CarFlowContext()
    {
    }

    public CarFlowContext(DbContextOptions<CarFlowContext> options) : base(options)
    {
    }

    public DbSet<Account> Accounts { get; set; }

    public DbSet<AccountFavouriteAdvertisement> AccountFavouriteAdvertisements { get; set; }

    public DbSet<AccountRole> AccountRoles { get; set; }

    public DbSet<Body> Bodies { get; set; }

    public DbSet<BodyVariant> BodyVariants { get; set; }

    public DbSet<Brand> Brands { get; set; }

    public DbSet<Car> Cars { get; set; }

    public DbSet<CarAdvertisement> CarAdvertisements { get; set; }

    public DbSet<CarAdvertisementFeature> CarAdvertisementFeatures { get; set; }

    public DbSet<CarAdvertisementImage> CarAdvertisementImages { get; set; }

    public DbSet<Color> Colors { get; set; }

    public DbSet<CombustionEngineCar> CombustionEngineCars { get; set; }

    public DbSet<Condition> Conditions { get; set; }

    public DbSet<Drivetrain> Drivetrains { get; set; }

    public DbSet<ElectricCar> ElectricCars { get; set; }

    public DbSet<Engine> Engines { get; set; }

    public DbSet<EngineAspiration> EngineAspirations { get; set; }

    public DbSet<EngineConfiguration> EngineConfigurations { get; set; }

    public DbSet<EuroStandard> EuroStandards { get; set; }

    public DbSet<Feature> Features { get; set; }

    public DbSet<FuelType> FuelTypes { get; set; }

    public DbSet<Model> Models { get; set; }

    public DbSet<ModelStandardFeature> ModelStandardFeatures { get; set; }

    public DbSet<Promotion> Promotions { get; set; }

    public DbSet<PromotionType> PromotionTypes { get; set; }

    public DbSet<Region> Regions { get; set; }

    public DbSet<Role> Roles { get; set; }

    public DbSet<SeatMaterial> SeatsMaterials { get; set; }

    public DbSet<Subregion> Subregions { get; set; }

    public DbSet<Transmission> Transmissions { get; set; }

    public DbSet<TransmissionVariant> TransmissionVariants { get; set; }

    public DbSet<TunedCarDetail> TunedCarDetails { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AccountConfiguration());
        modelBuilder.ApplyConfiguration(new AccountFavouriteAdvertisementConfiguration());
        modelBuilder.ApplyConfiguration(new AccountRoleConfiguration());
        modelBuilder.ApplyConfiguration(new BodyConfiguration());
        modelBuilder.ApplyConfiguration(new BodyVariantConfiguration());
        modelBuilder.ApplyConfiguration(new BrandConfiguration());
        modelBuilder.ApplyConfiguration(new CarAdvertisementConfiguration());
        modelBuilder.ApplyConfiguration(new CarAdvertisementFeatureConfiguration());
        modelBuilder.ApplyConfiguration(new CarAdvertisementImageConfiguration());
        modelBuilder.ApplyConfiguration(new CarConfiguration());
        modelBuilder.ApplyConfiguration(new ColorConfiguration());
        modelBuilder.ApplyConfiguration(new CombustionEngineCarConfiguration());
        modelBuilder.ApplyConfiguration(new ConditionConfiguration());
        modelBuilder.ApplyConfiguration(new DrivetrainConfiguration());
        modelBuilder.ApplyConfiguration(new ElectricCarConfiguration());
        modelBuilder.ApplyConfiguration(new EngineAspirationConfiguration());
        modelBuilder.ApplyConfiguration(new EngineConfigurationConfiguration());
        modelBuilder.ApplyConfiguration(new EuroStandardConfiguration());
        modelBuilder.ApplyConfiguration(new FeatureConfiguration());
        modelBuilder.ApplyConfiguration(new FuelTypeConfiguration());
        modelBuilder.ApplyConfiguration(new ModelConfiguration());
        modelBuilder.ApplyConfiguration(new ModelStandardFeatureConfiguration());
        modelBuilder.ApplyConfiguration(new PromotionConfiguration());
        modelBuilder.ApplyConfiguration(new PromotionTypeConfiguration());
        modelBuilder.ApplyConfiguration(new RegionConfiguration());
        modelBuilder.ApplyConfiguration(new RoleConfiguration());
        modelBuilder.ApplyConfiguration(new SeatMaterialConfiguration());
        modelBuilder.ApplyConfiguration(new SubregionConfiguration());
        modelBuilder.ApplyConfiguration(new TransmissionConfiguration());
        modelBuilder.ApplyConfiguration(new TransmissionVariantConfiguration());
        modelBuilder.ApplyConfiguration(new TunedCarDetailConfiguration());
    }
}