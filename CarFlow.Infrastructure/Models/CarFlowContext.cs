using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CarFlow.Infrastructure.Models;

public partial class CarFlowContext : DbContext
{
    private readonly IConfiguration _configuration;

    public CarFlowContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public CarFlowContext(DbContextOptions<CarFlowContext> options, IConfiguration configuration)
        : base(options)
    {
        _configuration = configuration;
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Body> Bodies { get; set; }

    public virtual DbSet<BodyVariant> BodyVariants { get; set; }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<CarAd> CarAds { get; set; }

    public virtual DbSet<CarAdImage> CarAdImages { get; set; }

    public virtual DbSet<Color> Colors { get; set; }

    public virtual DbSet<CombustionEngineCar> CombustionEngineCars { get; set; }

    public virtual DbSet<Condition> Conditions { get; set; }

    public virtual DbSet<Drivetrain> Drivetrains { get; set; }

    public virtual DbSet<ElectricCar> ElectricCars { get; set; }

    public virtual DbSet<Engine> Engines { get; set; }

    public virtual DbSet<EngineAspiration> EngineAspirations { get; set; }

    public virtual DbSet<EngineConfiguration> EngineConfigurations { get; set; }

    public virtual DbSet<EuroStandard> EuroStandards { get; set; }

    public virtual DbSet<Feature> Features { get; set; }

    public virtual DbSet<FuelType> FuelTypes { get; set; }

    public virtual DbSet<Make> Makes { get; set; }

    public virtual DbSet<Model> Models { get; set; }

    public virtual DbSet<Promotion> Promotions { get; set; }

    public virtual DbSet<PromotionType> PromotionTypes { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<SeatsMaterial> SeatsMaterials { get; set; }

    public virtual DbSet<Subregion> Subregions { get; set; }

    public virtual DbSet<Transmission> Transmissions { get; set; }

    public virtual DbSet<TransmissionVariant> TransmissionVariants { get; set; }

    public virtual DbSet<TunedCarDetail> TunedCarDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(_configuration.GetConnectionString("SQLConnection"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Account__3214EC079864BD73");

            entity.ToTable("Account");

            entity.HasIndex(e => e.Phone, "UQ__Account__5C7E359EB6F65048").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__Account__A9D1053440AF1592").IsUnique();

            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.Phone).HasMaxLength(50);

            entity.HasMany(d => d.CarAds).WithMany(p => p.Accounts)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountFavouriteCar",
                    r => r.HasOne<CarAd>().WithMany()
                        .HasForeignKey("CarAdId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__AccountFa__CarAd__03BB8E22"),
                    l => l.HasOne<Account>().WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__AccountFa__CarAd__02C769E9"),
                    j =>
                    {
                        j.HasKey("AccountId", "CarAdId").HasName("PK__AccountF__DFE70BD97B2A3832");
                        j.ToTable("AccountFavouriteCar");
                    });

            entity.HasMany(d => d.Roles).WithMany(p => p.Accounts)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountRole",
                    r => r.HasOne<Role>().WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__AccountRo__RoleI__12FDD1B2"),
                    l => l.HasOne<Account>().WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__AccountRo__Accou__1209AD79"),
                    j =>
                    {
                        j.HasKey("AccountId", "RoleId").HasName("PK__AccountR__8C3209477E1404EF");
                        j.ToTable("AccountRole");
                    });

            entity.HasMany(d => d.RolesNavigation).WithMany(p => p.AccountsNavigation)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountRole1",
                    r => r.HasOne<Role>().WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__AccountRo__RoleI__0F2D40CE"),
                    l => l.HasOne<Account>().WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__AccountRo__Accou__0E391C95"),
                    j =>
                    {
                        j.HasKey("AccountId", "RoleId").HasName("PK__AccountR__8C320947B9DC7BD4");
                        j.ToTable("AccountRoles");
                    });
        });

        modelBuilder.Entity<Body>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Body__3214EC07ABCDAD7F");

            entity.ToTable("Body");

            entity.HasIndex(e => e.Name, "UQ__Body__737584F6E9CD3EAE").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<BodyVariant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BodyVari__3214EC071BA567B0");

            entity.ToTable("BodyVariant");

            entity.HasOne(d => d.Body).WithMany(p => p.BodyVariants)
                .HasForeignKey(d => d.BodyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BodyVaria__SeatC__3A81B327");
        });

        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Car__3214EC07554FA1B0");

            entity.ToTable("Car");

            entity.Property(e => e.EndYear).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.Generation)
                .HasMaxLength(150)
                .HasDefaultValueSql("(NULL)");

            entity.HasOne(d => d.BodyVariant).WithMany(p => p.Cars)
                .HasForeignKey(d => d.BodyVariantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Car__BodyVariant__619B8048");

            entity.HasOne(d => d.Drivetrain).WithMany(p => p.Cars)
                .HasForeignKey(d => d.DrivetrainId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Car__DrivetrainI__6383C8BA");

            entity.HasOne(d => d.Model).WithMany(p => p.Cars)
                .HasForeignKey(d => d.ModelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Car__EndYear__60A75C0F");

            entity.HasOne(d => d.TransmissionVariant).WithMany(p => p.Cars)
                .HasForeignKey(d => d.TransmissionVariantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Car__Transmissio__628FA481");
        });

        modelBuilder.Entity<CarAd>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CarAd__3214EC07CB76815E");

            entity.ToTable("CarAd");

            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(3000)
                .HasDefaultValueSql("(NULL)");
            entity.Property(e => e.ExpirationDate).HasColumnType("datetime");
            entity.Property(e => e.OwnerCount).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.RegistrationYear).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.Title).HasMaxLength(150);
            entity.Property(e => e.VideoUrl)
                .HasMaxLength(500)
                .HasDefaultValueSql("(NULL)");
            entity.Property(e => e.Vin)
                .HasMaxLength(150)
                .HasDefaultValueSql("(NULL)");

            entity.HasOne(d => d.Account).WithMany(p => p.CarAdsNavigation)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CarAd__VideoUrl__1BC821DD");

            entity.HasOne(d => d.Car).WithMany(p => p.CarAds)
                .HasForeignKey(d => d.CarId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CarAd__CarId__1DB06A4F");

            entity.HasOne(d => d.Condition).WithMany(p => p.CarAds)
                .HasForeignKey(d => d.ConditionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CarAd__Condition__1CBC4616");

            entity.HasOne(d => d.ExteriorColor).WithMany(p => p.CarAdExteriorColors)
                .HasForeignKey(d => d.ExteriorColorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CarAd__ExteriorC__1EA48E88");

            entity.HasOne(d => d.InteriorColor).WithMany(p => p.CarAdInteriorColors)
                .HasForeignKey(d => d.InteriorColorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CarAd__InteriorC__1F98B2C1");

            entity.HasOne(d => d.SeatsMaterial).WithMany(p => p.CarAds)
                .HasForeignKey(d => d.SeatsMaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CarAd__SeatsMate__208CD6FA");

            entity.HasOne(d => d.Subregion).WithMany(p => p.CarAds)
                .HasForeignKey(d => d.SubregionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CarAd__Subregion__2180FB33");

            entity.HasMany(d => d.Features).WithMany(p => p.CarAds)
                .UsingEntity<Dictionary<string, object>>(
                    "CarFeature",
                    r => r.HasOne<Feature>().WithMany()
                        .HasForeignKey("FeatureId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__CarFeatur__Featu__367C1819"),
                    l => l.HasOne<CarAd>().WithMany()
                        .HasForeignKey("CarAdId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__CarFeatur__CarAd__3587F3E0"),
                    j =>
                    {
                        j.HasKey("CarAdId", "FeatureId").HasName("PK__CarFeatu__3F88D743334180B0");
                        j.ToTable("CarFeature");
                    });
        });

        modelBuilder.Entity<CarAdImage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CarAdIma__3214EC078BE72691");

            entity.ToTable("CarAdImage");

            entity.HasOne(d => d.CarAd).WithMany(p => p.CarAdImages)
                .HasForeignKey(d => d.CarAdId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CarAdImag__Image__395884C4");
        });

        modelBuilder.Entity<Color>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Color__3214EC0762679E69");

            entity.ToTable("Color");

            entity.HasIndex(e => e.Name, "UQ__Color__737584F64A780269").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(150);
        });

        modelBuilder.Entity<CombustionEngineCar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Combusti__3214EC071D351A1F");

            entity.ToTable("CombustionEngineCar");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CityFuel)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(3, 1)");
            entity.Property(e => e.CombinedFuel)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(3, 1)");
            entity.Property(e => e.HighwayFuel)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(3, 1)");

            entity.HasOne(d => d.Engine).WithMany(p => p.CombustionEngineCars)
                .HasForeignKey(d => d.EngineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Combustio__Engin__6A30C649");

            entity.HasOne(d => d.EuroStandard).WithMany(p => p.CombustionEngineCars)
                .HasForeignKey(d => d.EuroStandardId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Combustio__EuroS__6B24EA82");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.CombustionEngineCar)
                .HasForeignKey<CombustionEngineCar>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Combustio__Highw__693CA210");
        });

        modelBuilder.Entity<Condition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Conditio__3214EC074305DB49");

            entity.ToTable("Condition");

            entity.HasIndex(e => e.Name, "UQ__Conditio__737584F687AF0F6D").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(150);
        });

        modelBuilder.Entity<Drivetrain>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Drivetra__3214EC0780F3C851");

            entity.ToTable("Drivetrain");

            entity.HasIndex(e => e.Name, "UQ__Drivetra__737584F6A11EE94B").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<ElectricCar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Electric__3214EC07A66EBBA9");

            entity.ToTable("ElectricCar");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.ElectricCar)
                .HasForeignKey<ElectricCar>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ElectricC__Motor__6E01572D");
        });

        modelBuilder.Entity<Engine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Engine__3214EC07A2AD7ADA");

            entity.ToTable("Engine");

            entity.Property(e => e.Model)
                .HasMaxLength(100)
                .HasDefaultValueSql("(NULL)");

            entity.HasOne(d => d.Aspiration).WithMany(p => p.Engines)
                .HasForeignKey(d => d.AspirationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Engine__Aspirati__52593CB8");

            entity.HasOne(d => d.Configuration).WithMany(p => p.Engines)
                .HasForeignKey(d => d.ConfigurationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Engine__Configur__5165187F");

            entity.HasOne(d => d.FuelType).WithMany(p => p.Engines)
                .HasForeignKey(d => d.FuelTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Engine__Aspirati__5070F446");
        });

        modelBuilder.Entity<EngineAspiration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EngineAs__3214EC0754D443AB");

            entity.ToTable("EngineAspiration");

            entity.HasIndex(e => e.Name, "UQ__EngineAs__737584F6193C49A0").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<EngineConfiguration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EngineCo__3214EC076CA7DC04");

            entity.ToTable("EngineConfiguration");

            entity.HasIndex(e => new { e.Name, e.CylinderCount }, "UQ__EngineCo__89DF6516FB01487D").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<EuroStandard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EuroStan__3214EC0746814BDC");

            entity.ToTable("EuroStandard");

            entity.HasIndex(e => e.Name, "UQ__EuroStan__737584F6AFB0EA00").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Feature>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Feature__3214EC07A2E1156B");

            entity.ToTable("Feature");

            entity.HasIndex(e => e.Name, "UQ__Feature__737584F6CBB2F6CC").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(150);
        });

        modelBuilder.Entity<FuelType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FuelType__3214EC0765DCA187");

            entity.ToTable("FuelType");

            entity.HasIndex(e => e.Name, "UQ__FuelType__737584F66DA15B43").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Make>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Make__3214EC0748EBA92B");

            entity.ToTable("Make");

            entity.HasIndex(e => e.Name, "UQ__Make__737584F6EC73E514").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Model>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Model__3214EC07838E56BB");

            entity.ToTable("Model");

            entity.HasIndex(e => new { e.MakeId, e.Name, e.ModelVariant }, "UQ__Model__2453371F39045580").IsUnique();

            entity.Property(e => e.ModelVariant).HasMaxLength(150);
            entity.Property(e => e.Name).HasMaxLength(150);

            entity.HasOne(d => d.Make).WithMany(p => p.Models)
                .HasForeignKey(d => d.MakeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Model__ModelVari__412EB0B6");

            entity.HasMany(d => d.Features).WithMany(p => p.Models)
                .UsingEntity<Dictionary<string, object>>(
                    "ModelStandardFeature",
                    r => r.HasOne<Feature>().WithMany()
                        .HasForeignKey("FeatureId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__ModelStan__Featu__3D2915A8"),
                    l => l.HasOne<Model>().WithMany()
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__ModelStan__Model__3C34F16F"),
                    j =>
                    {
                        j.HasKey("ModelId", "FeatureId").HasName("PK__ModelSta__60F5919026E0BAD9");
                        j.ToTable("ModelStandardFeature");
                    });
        });

        modelBuilder.Entity<Promotion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Promotio__3214EC0730C06505");

            entity.ToTable("Promotion");

            entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

            entity.HasOne(d => d.CarAd).WithMany(p => p.Promotions)
                .HasForeignKey(d => d.CarAdId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Promotion__Expir__42E1EEFE");

            entity.HasOne(d => d.PromotionType).WithMany(p => p.Promotions)
                .HasForeignKey(d => d.PromotionTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Promotion__Promo__43D61337");
        });

        modelBuilder.Entity<PromotionType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Promotio__3214EC07394B6F27");

            entity.ToTable("PromotionType");

            entity.HasIndex(e => e.Name, "UQ__Promotio__737584F647E6F9E2").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Region__3214EC071BFC7595");

            entity.ToTable("Region");

            entity.HasIndex(e => e.Name, "UQ__Region__737584F6A8C0E411").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(150);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Role__3214EC07C75477BC");

            entity.ToTable("Role");

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<SeatsMaterial>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SeatsMat__3214EC079628B006");

            entity.ToTable("SeatsMaterial");

            entity.HasIndex(e => e.Name, "UQ__SeatsMat__737584F63E50E350").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(150);
        });

        modelBuilder.Entity<Subregion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Subregio__3214EC074377A527");

            entity.ToTable("Subregion");

            entity.HasIndex(e => e.Name, "UQ__Subregio__737584F6D5791710").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(150);

            entity.HasOne(d => d.Region).WithMany(p => p.Subregions)
                .HasForeignKey(d => d.RegionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Subregion__Name__7C4F7684");
        });

        modelBuilder.Entity<Transmission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Transmis__3214EC0755060136");

            entity.ToTable("Transmission");

            entity.HasIndex(e => e.Name, "UQ__Transmis__737584F6C3614411").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<TransmissionVariant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Transmis__3214EC076E09E6B5");

            entity.ToTable("TransmissionVariant");

            entity.HasIndex(e => new { e.TransmissionId, e.GearCount }, "UQ__Transmis__CB922EC0CA32CAA8").IsUnique();

            entity.HasOne(d => d.Transmission).WithMany(p => p.TransmissionVariants)
                .HasForeignKey(d => d.TransmissionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Transmiss__GearC__59063A47");
        });

        modelBuilder.Entity<TunedCarDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TunedCar__3214EC07DEA7EFC0");

            entity.HasIndex(e => e.CarAdId, "UQ__TunedCar__B7AAE7FE9A1CD654").IsUnique();

            entity.HasOne(d => d.CarAd).WithOne(p => p.TunedCarDetail)
                .HasForeignKey<TunedCarDetail>(d => d.CarAdId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TunedCarD__Horse__29221CFB");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}