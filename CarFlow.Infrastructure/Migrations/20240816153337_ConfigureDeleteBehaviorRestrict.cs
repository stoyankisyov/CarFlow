using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarFlow.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ConfigureDeleteBehaviorRestrict : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountFavouriteAdvertisement_Account_AccountId",
                table: "AccountFavouriteAdvertisement");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountRole_Account_AccountId",
                table: "AccountRole");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountRole_Role_RoleId",
                table: "AccountRole");

            migrationBuilder.DropForeignKey(
                name: "FK_BodyVariant_Body_BodyId",
                table: "BodyVariant");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_BodyVariant_BodyVariantId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_Drivetrain_DrivetrainId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_Model_ModelId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_TransmissionVariant_TransmissionVariantId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_CarAdvertisementFeature_Feature_FeatureId",
                table: "CarAdvertisementFeature");

            migrationBuilder.DropForeignKey(
                name: "FK_CombustionEngineCar_Car_Id",
                table: "CombustionEngineCar");

            migrationBuilder.DropForeignKey(
                name: "FK_CombustionEngineCar_Engines_EngineId",
                table: "CombustionEngineCar");

            migrationBuilder.DropForeignKey(
                name: "FK_CombustionEngineCar_EuroStandard_EuroStandardId",
                table: "CombustionEngineCar");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectricCar_Car_Id",
                table: "ElectricCar");

            migrationBuilder.DropForeignKey(
                name: "FK_Engines_EngineAspiration_AspirationId",
                table: "Engines");

            migrationBuilder.DropForeignKey(
                name: "FK_Engines_EngineConfiguration_ConfigurationId",
                table: "Engines");

            migrationBuilder.DropForeignKey(
                name: "FK_Engines_FuelType_FuelTypeId",
                table: "Engines");

            migrationBuilder.DropForeignKey(
                name: "FK_Model_Brand_BrandId",
                table: "Model");

            migrationBuilder.DropForeignKey(
                name: "FK_ModelStandardFeature_Feature_FeatureId",
                table: "ModelStandardFeature");

            migrationBuilder.DropForeignKey(
                name: "FK_ModelStandardFeature_Model_ModelId",
                table: "ModelStandardFeature");

            migrationBuilder.DropForeignKey(
                name: "FK_Promotion_PromotionType_PromotionTypeId",
                table: "Promotion");

            migrationBuilder.DropForeignKey(
                name: "FK_Subregion_Region_RegionId",
                table: "Subregion");

            migrationBuilder.DropForeignKey(
                name: "FK_TransmissionVariant_Transmission_TransmissionId",
                table: "TransmissionVariant");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountFavouriteAdvertisement_Account_AccountId",
                table: "AccountFavouriteAdvertisement",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountRole_Account_AccountId",
                table: "AccountRole",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountRole_Role_RoleId",
                table: "AccountRole",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BodyVariant_Body_BodyId",
                table: "BodyVariant",
                column: "BodyId",
                principalTable: "Body",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_BodyVariant_BodyVariantId",
                table: "Car",
                column: "BodyVariantId",
                principalTable: "BodyVariant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Drivetrain_DrivetrainId",
                table: "Car",
                column: "DrivetrainId",
                principalTable: "Drivetrain",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Model_ModelId",
                table: "Car",
                column: "ModelId",
                principalTable: "Model",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_TransmissionVariant_TransmissionVariantId",
                table: "Car",
                column: "TransmissionVariantId",
                principalTable: "TransmissionVariant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CarAdvertisementFeature_Feature_FeatureId",
                table: "CarAdvertisementFeature",
                column: "FeatureId",
                principalTable: "Feature",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CombustionEngineCar_Car_Id",
                table: "CombustionEngineCar",
                column: "Id",
                principalTable: "Car",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CombustionEngineCar_Engines_EngineId",
                table: "CombustionEngineCar",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CombustionEngineCar_EuroStandard_EuroStandardId",
                table: "CombustionEngineCar",
                column: "EuroStandardId",
                principalTable: "EuroStandard",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricCar_Car_Id",
                table: "ElectricCar",
                column: "Id",
                principalTable: "Car",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Engines_EngineAspiration_AspirationId",
                table: "Engines",
                column: "AspirationId",
                principalTable: "EngineAspiration",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Engines_EngineConfiguration_ConfigurationId",
                table: "Engines",
                column: "ConfigurationId",
                principalTable: "EngineConfiguration",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Engines_FuelType_FuelTypeId",
                table: "Engines",
                column: "FuelTypeId",
                principalTable: "FuelType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Model_Brand_BrandId",
                table: "Model",
                column: "BrandId",
                principalTable: "Brand",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ModelStandardFeature_Feature_FeatureId",
                table: "ModelStandardFeature",
                column: "FeatureId",
                principalTable: "Feature",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ModelStandardFeature_Model_ModelId",
                table: "ModelStandardFeature",
                column: "ModelId",
                principalTable: "Model",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Promotion_PromotionType_PromotionTypeId",
                table: "Promotion",
                column: "PromotionTypeId",
                principalTable: "PromotionType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subregion_Region_RegionId",
                table: "Subregion",
                column: "RegionId",
                principalTable: "Region",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TransmissionVariant_Transmission_TransmissionId",
                table: "TransmissionVariant",
                column: "TransmissionId",
                principalTable: "Transmission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountFavouriteAdvertisement_Account_AccountId",
                table: "AccountFavouriteAdvertisement");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountRole_Account_AccountId",
                table: "AccountRole");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountRole_Role_RoleId",
                table: "AccountRole");

            migrationBuilder.DropForeignKey(
                name: "FK_BodyVariant_Body_BodyId",
                table: "BodyVariant");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_BodyVariant_BodyVariantId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_Drivetrain_DrivetrainId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_Model_ModelId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_TransmissionVariant_TransmissionVariantId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_CarAdvertisementFeature_Feature_FeatureId",
                table: "CarAdvertisementFeature");

            migrationBuilder.DropForeignKey(
                name: "FK_CombustionEngineCar_Car_Id",
                table: "CombustionEngineCar");

            migrationBuilder.DropForeignKey(
                name: "FK_CombustionEngineCar_Engines_EngineId",
                table: "CombustionEngineCar");

            migrationBuilder.DropForeignKey(
                name: "FK_CombustionEngineCar_EuroStandard_EuroStandardId",
                table: "CombustionEngineCar");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectricCar_Car_Id",
                table: "ElectricCar");

            migrationBuilder.DropForeignKey(
                name: "FK_Engines_EngineAspiration_AspirationId",
                table: "Engines");

            migrationBuilder.DropForeignKey(
                name: "FK_Engines_EngineConfiguration_ConfigurationId",
                table: "Engines");

            migrationBuilder.DropForeignKey(
                name: "FK_Engines_FuelType_FuelTypeId",
                table: "Engines");

            migrationBuilder.DropForeignKey(
                name: "FK_Model_Brand_BrandId",
                table: "Model");

            migrationBuilder.DropForeignKey(
                name: "FK_ModelStandardFeature_Feature_FeatureId",
                table: "ModelStandardFeature");

            migrationBuilder.DropForeignKey(
                name: "FK_ModelStandardFeature_Model_ModelId",
                table: "ModelStandardFeature");

            migrationBuilder.DropForeignKey(
                name: "FK_Promotion_PromotionType_PromotionTypeId",
                table: "Promotion");

            migrationBuilder.DropForeignKey(
                name: "FK_Subregion_Region_RegionId",
                table: "Subregion");

            migrationBuilder.DropForeignKey(
                name: "FK_TransmissionVariant_Transmission_TransmissionId",
                table: "TransmissionVariant");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountFavouriteAdvertisement_Account_AccountId",
                table: "AccountFavouriteAdvertisement",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountRole_Account_AccountId",
                table: "AccountRole",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountRole_Role_RoleId",
                table: "AccountRole",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BodyVariant_Body_BodyId",
                table: "BodyVariant",
                column: "BodyId",
                principalTable: "Body",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_BodyVariant_BodyVariantId",
                table: "Car",
                column: "BodyVariantId",
                principalTable: "BodyVariant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Drivetrain_DrivetrainId",
                table: "Car",
                column: "DrivetrainId",
                principalTable: "Drivetrain",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Model_ModelId",
                table: "Car",
                column: "ModelId",
                principalTable: "Model",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_TransmissionVariant_TransmissionVariantId",
                table: "Car",
                column: "TransmissionVariantId",
                principalTable: "TransmissionVariant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarAdvertisementFeature_Feature_FeatureId",
                table: "CarAdvertisementFeature",
                column: "FeatureId",
                principalTable: "Feature",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CombustionEngineCar_Car_Id",
                table: "CombustionEngineCar",
                column: "Id",
                principalTable: "Car",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CombustionEngineCar_Engines_EngineId",
                table: "CombustionEngineCar",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CombustionEngineCar_EuroStandard_EuroStandardId",
                table: "CombustionEngineCar",
                column: "EuroStandardId",
                principalTable: "EuroStandard",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricCar_Car_Id",
                table: "ElectricCar",
                column: "Id",
                principalTable: "Car",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Engines_EngineAspiration_AspirationId",
                table: "Engines",
                column: "AspirationId",
                principalTable: "EngineAspiration",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Engines_EngineConfiguration_ConfigurationId",
                table: "Engines",
                column: "ConfigurationId",
                principalTable: "EngineConfiguration",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Engines_FuelType_FuelTypeId",
                table: "Engines",
                column: "FuelTypeId",
                principalTable: "FuelType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Model_Brand_BrandId",
                table: "Model",
                column: "BrandId",
                principalTable: "Brand",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModelStandardFeature_Feature_FeatureId",
                table: "ModelStandardFeature",
                column: "FeatureId",
                principalTable: "Feature",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModelStandardFeature_Model_ModelId",
                table: "ModelStandardFeature",
                column: "ModelId",
                principalTable: "Model",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Promotion_PromotionType_PromotionTypeId",
                table: "Promotion",
                column: "PromotionTypeId",
                principalTable: "PromotionType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subregion_Region_RegionId",
                table: "Subregion",
                column: "RegionId",
                principalTable: "Region",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransmissionVariant_Transmission_TransmissionId",
                table: "TransmissionVariant",
                column: "TransmissionId",
                principalTable: "Transmission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
