using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarFlow.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Body",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Body", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Color",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Condition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condition", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drivetrain",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivetrain", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EngineAspiration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EngineAspiration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EngineConfiguration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CylinderCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EngineConfiguration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EuroStandard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EuroStandard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Feature",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feature", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FuelType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PromotionType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromotionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SeatMaterial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeatMaterial", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transmission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transmission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BodyVariant",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BodyId = table.Column<int>(type: "int", nullable: false),
                    DoorCount = table.Column<int>(type: "int", nullable: false),
                    SeatCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyVariant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BodyVariant_Body_BodyId",
                        column: x => x.BodyId,
                        principalTable: "Body",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Model",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModelVariant = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Model", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Model_Brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Engines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Displacement = table.Column<int>(type: "int", nullable: false),
                    Horsepower = table.Column<int>(type: "int", nullable: false),
                    Torque = table.Column<int>(type: "int", nullable: false),
                    FuelTypeId = table.Column<int>(type: "int", nullable: false),
                    ConfigurationId = table.Column<int>(type: "int", nullable: false),
                    AspirationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Engines_EngineAspiration_AspirationId",
                        column: x => x.AspirationId,
                        principalTable: "EngineAspiration",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Engines_EngineConfiguration_ConfigurationId",
                        column: x => x.ConfigurationId,
                        principalTable: "EngineConfiguration",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Engines_FuelType_FuelTypeId",
                        column: x => x.FuelTypeId,
                        principalTable: "FuelType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subregion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subregion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subregion_Region_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Region",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccountRole",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountRole", x => new { x.AccountId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AccountRole_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransmissionVariant",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransmissionId = table.Column<int>(type: "int", nullable: false),
                    GearCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransmissionVariant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransmissionVariant_Transmission_TransmissionId",
                        column: x => x.TransmissionId,
                        principalTable: "Transmission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModelStandardFeature",
                columns: table => new
                {
                    ModelId = table.Column<int>(type: "int", nullable: false),
                    FeatureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelStandardFeature", x => new { x.ModelId, x.FeatureId });
                    table.ForeignKey(
                        name: "FK_ModelStandardFeature_Feature_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "Feature",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModelStandardFeature_Model_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Model",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    ModelId = table.Column<int>(type: "int", nullable: false),
                    Generation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BodyVariantId = table.Column<int>(type: "int", nullable: false),
                    TransmissionVariantId = table.Column<int>(type: "int", nullable: false),
                    DrivetrainId = table.Column<int>(type: "int", nullable: false),
                    StartYear = table.Column<DateOnly>(type: "date", nullable: false),
                    EndYear = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Car_BodyVariant_BodyVariantId",
                        column: x => x.BodyVariantId,
                        principalTable: "BodyVariant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Car_Drivetrain_DrivetrainId",
                        column: x => x.DrivetrainId,
                        principalTable: "Drivetrain",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Car_Model_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Model",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Car_TransmissionVariant_TransmissionVariantId",
                        column: x => x.TransmissionVariantId,
                        principalTable: "TransmissionVariant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarAdvertisement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    ConditionId = table.Column<int>(type: "int", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    ExteriorColorId = table.Column<int>(type: "int", nullable: false),
                    InteriorColorId = table.Column<int>(type: "int", nullable: false),
                    SeatMaterialId = table.Column<int>(type: "int", nullable: false),
                    SubregionId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true),
                    Mileage = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    ManufactureYear = table.Column<DateOnly>(type: "date", nullable: false),
                    RegistrationYear = table.Column<DateOnly>(type: "date", nullable: true),
                    Warranty = table.Column<DateOnly>(type: "date", nullable: true),
                    Vin = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: true),
                    OwnerCount = table.Column<int>(type: "int", nullable: true),
                    VideoUrl = table.Column<string>(type: "nvarchar(2050)", maxLength: 2050, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarAdvertisement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarAdvertisement_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CarAdvertisement_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CarAdvertisement_Color_ExteriorColorId",
                        column: x => x.ExteriorColorId,
                        principalTable: "Color",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CarAdvertisement_Color_InteriorColorId",
                        column: x => x.InteriorColorId,
                        principalTable: "Color",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CarAdvertisement_Condition_ConditionId",
                        column: x => x.ConditionId,
                        principalTable: "Condition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CarAdvertisement_SeatMaterial_SeatMaterialId",
                        column: x => x.SeatMaterialId,
                        principalTable: "SeatMaterial",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CarAdvertisement_Subregion_SubregionId",
                        column: x => x.SubregionId,
                        principalTable: "Subregion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CombustionEngineCar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    EngineId = table.Column<int>(type: "int", nullable: false),
                    EuroStandardId = table.Column<int>(type: "int", nullable: false),
                    CityFuel = table.Column<decimal>(type: "decimal(3,1)", precision: 3, scale: 1, nullable: true),
                    CombinedFuel = table.Column<decimal>(type: "decimal(3,1)", precision: 3, scale: 1, nullable: true),
                    HighwayFuel = table.Column<decimal>(type: "decimal(3,1)", precision: 3, scale: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CombustionEngineCar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CombustionEngineCar_Car_Id",
                        column: x => x.Id,
                        principalTable: "Car",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CombustionEngineCar_Engines_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CombustionEngineCar_EuroStandard_EuroStandardId",
                        column: x => x.EuroStandardId,
                        principalTable: "EuroStandard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElectricCar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Horsepower = table.Column<int>(type: "int", nullable: false),
                    Torque = table.Column<int>(type: "int", nullable: false),
                    BatteryCapacity = table.Column<int>(type: "int", nullable: false),
                    Range = table.Column<int>(type: "int", nullable: false),
                    MotorCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricCar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElectricCar_Car_Id",
                        column: x => x.Id,
                        principalTable: "Car",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccountFavouriteAdvertisement",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    AdvertisementId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountFavouriteAdvertisement", x => new { x.AccountId, x.AdvertisementId });
                    table.ForeignKey(
                        name: "FK_AccountFavouriteAdvertisement_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountFavouriteAdvertisement_CarAdvertisement_AdvertisementId",
                        column: x => x.AdvertisementId,
                        principalTable: "CarAdvertisement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CarAdvertisementFeature",
                columns: table => new
                {
                    CarAdvertisementId = table.Column<int>(type: "int", nullable: false),
                    FeatureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarAdvertisementFeature", x => new { x.CarAdvertisementId, x.FeatureId });
                    table.ForeignKey(
                        name: "FK_CarAdvertisementFeature_CarAdvertisement_CarAdvertisementId",
                        column: x => x.CarAdvertisementId,
                        principalTable: "CarAdvertisement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CarAdvertisementFeature_Feature_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "Feature",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarAdvertisementImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarAdvertisementId = table.Column<int>(type: "int", nullable: false),
                    ImageData = table.Column<byte[]>(type: "VARBINARY(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarAdvertisementImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarAdvertisementImage_CarAdvertisement_CarAdvertisementId",
                        column: x => x.CarAdvertisementId,
                        principalTable: "CarAdvertisement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Promotion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarAdvertisementId = table.Column<int>(type: "int", nullable: false),
                    PromotionTypeId = table.Column<int>(type: "int", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Promotion_CarAdvertisement_CarAdvertisementId",
                        column: x => x.CarAdvertisementId,
                        principalTable: "CarAdvertisement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Promotion_PromotionType_PromotionTypeId",
                        column: x => x.PromotionTypeId,
                        principalTable: "PromotionType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TunedCarDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarAdvertisementId = table.Column<int>(type: "int", nullable: false),
                    Horsepower = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TunedCarDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TunedCarDetail_CarAdvertisement_CarAdvertisementId",
                        column: x => x.CarAdvertisementId,
                        principalTable: "CarAdvertisement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_Email",
                table: "Account",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Account_Phone",
                table: "Account",
                column: "Phone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AccountFavouriteAdvertisement_AdvertisementId",
                table: "AccountFavouriteAdvertisement",
                column: "AdvertisementId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountRole_RoleId",
                table: "AccountRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Body_Name",
                table: "Body",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BodyVariant_BodyId_DoorCount_SeatCount",
                table: "BodyVariant",
                columns: new[] { "BodyId", "DoorCount", "SeatCount" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Brand_Name",
                table: "Brand",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Car_BodyVariantId",
                table: "Car",
                column: "BodyVariantId");

            migrationBuilder.CreateIndex(
                name: "IX_Car_DrivetrainId",
                table: "Car",
                column: "DrivetrainId");

            migrationBuilder.CreateIndex(
                name: "IX_Car_ModelId_Generation_BodyVariantId_TransmissionVariantId_DrivetrainId_StartYear_EndYear",
                table: "Car",
                columns: new[] { "ModelId", "Generation", "BodyVariantId", "TransmissionVariantId", "DrivetrainId", "StartYear", "EndYear" },
                unique: true,
                filter: "[Generation] IS NOT NULL AND [EndYear] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Car_TransmissionVariantId",
                table: "Car",
                column: "TransmissionVariantId");

            migrationBuilder.CreateIndex(
                name: "IX_CarAdvertisement_AccountId",
                table: "CarAdvertisement",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_CarAdvertisement_CarId",
                table: "CarAdvertisement",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_CarAdvertisement_ConditionId",
                table: "CarAdvertisement",
                column: "ConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_CarAdvertisement_ExteriorColorId",
                table: "CarAdvertisement",
                column: "ExteriorColorId");

            migrationBuilder.CreateIndex(
                name: "IX_CarAdvertisement_InteriorColorId",
                table: "CarAdvertisement",
                column: "InteriorColorId");

            migrationBuilder.CreateIndex(
                name: "IX_CarAdvertisement_SeatMaterialId",
                table: "CarAdvertisement",
                column: "SeatMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_CarAdvertisement_SubregionId",
                table: "CarAdvertisement",
                column: "SubregionId");

            migrationBuilder.CreateIndex(
                name: "IX_CarAdvertisement_Vin",
                table: "CarAdvertisement",
                column: "Vin",
                unique: true,
                filter: "[Vin] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CarAdvertisementFeature_FeatureId",
                table: "CarAdvertisementFeature",
                column: "FeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_CarAdvertisementImage_CarAdvertisementId",
                table: "CarAdvertisementImage",
                column: "CarAdvertisementId");

            migrationBuilder.CreateIndex(
                name: "IX_Color_Name",
                table: "Color",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CombustionEngineCar_EngineId",
                table: "CombustionEngineCar",
                column: "EngineId");

            migrationBuilder.CreateIndex(
                name: "IX_CombustionEngineCar_EuroStandardId",
                table: "CombustionEngineCar",
                column: "EuroStandardId");

            migrationBuilder.CreateIndex(
                name: "IX_Condition_Name",
                table: "Condition",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Drivetrain_Name",
                table: "Drivetrain",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EngineAspiration_Name",
                table: "EngineAspiration",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EngineConfiguration_Name_CylinderCount",
                table: "EngineConfiguration",
                columns: new[] { "Name", "CylinderCount" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Engines_AspirationId",
                table: "Engines",
                column: "AspirationId");

            migrationBuilder.CreateIndex(
                name: "IX_Engines_ConfigurationId",
                table: "Engines",
                column: "ConfigurationId");

            migrationBuilder.CreateIndex(
                name: "IX_Engines_FuelTypeId",
                table: "Engines",
                column: "FuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FuelType_Name",
                table: "FuelType",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Model_BrandId_Name_ModelVariant",
                table: "Model",
                columns: new[] { "BrandId", "Name", "ModelVariant" },
                unique: true,
                filter: "[ModelVariant] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ModelStandardFeature_FeatureId",
                table: "ModelStandardFeature",
                column: "FeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_Promotion_CarAdvertisementId",
                table: "Promotion",
                column: "CarAdvertisementId");

            migrationBuilder.CreateIndex(
                name: "IX_Promotion_PromotionTypeId",
                table: "Promotion",
                column: "PromotionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PromotionType_Name_Price",
                table: "PromotionType",
                columns: new[] { "Name", "Price" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Region_Name",
                table: "Region",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Role_Name",
                table: "Role",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SeatMaterial_Name",
                table: "SeatMaterial",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subregion_RegionId_Name",
                table: "Subregion",
                columns: new[] { "RegionId", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transmission_Name",
                table: "Transmission",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransmissionVariant_TransmissionId_GearCount",
                table: "TransmissionVariant",
                columns: new[] { "TransmissionId", "GearCount" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TunedCarDetail_CarAdvertisementId",
                table: "TunedCarDetail",
                column: "CarAdvertisementId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountFavouriteAdvertisement");

            migrationBuilder.DropTable(
                name: "AccountRole");

            migrationBuilder.DropTable(
                name: "CarAdvertisementFeature");

            migrationBuilder.DropTable(
                name: "CarAdvertisementImage");

            migrationBuilder.DropTable(
                name: "CombustionEngineCar");

            migrationBuilder.DropTable(
                name: "ElectricCar");

            migrationBuilder.DropTable(
                name: "ModelStandardFeature");

            migrationBuilder.DropTable(
                name: "Promotion");

            migrationBuilder.DropTable(
                name: "TunedCarDetail");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Engines");

            migrationBuilder.DropTable(
                name: "EuroStandard");

            migrationBuilder.DropTable(
                name: "Feature");

            migrationBuilder.DropTable(
                name: "PromotionType");

            migrationBuilder.DropTable(
                name: "CarAdvertisement");

            migrationBuilder.DropTable(
                name: "EngineAspiration");

            migrationBuilder.DropTable(
                name: "EngineConfiguration");

            migrationBuilder.DropTable(
                name: "FuelType");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "Color");

            migrationBuilder.DropTable(
                name: "Condition");

            migrationBuilder.DropTable(
                name: "SeatMaterial");

            migrationBuilder.DropTable(
                name: "Subregion");

            migrationBuilder.DropTable(
                name: "BodyVariant");

            migrationBuilder.DropTable(
                name: "Drivetrain");

            migrationBuilder.DropTable(
                name: "Model");

            migrationBuilder.DropTable(
                name: "TransmissionVariant");

            migrationBuilder.DropTable(
                name: "Region");

            migrationBuilder.DropTable(
                name: "Body");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "Transmission");
        }
    }
}
