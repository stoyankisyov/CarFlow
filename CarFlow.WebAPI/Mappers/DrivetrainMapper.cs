using CarFlow.WebAPI.Models;

namespace CarFlow.WebAPI.Mappers;

public static class DrivetrainMapper
{
    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.Drivetrain" /> to a contract of type
    ///     <see cref="DrivetrainContract" />.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of <see cref="DrivetrainContract" /> representing the contract.</returns>
    public static DrivetrainContract ToContract(this Core.Models.Drivetrain domainModel)
        => new()
        {
            Id = domainModel.Id,
            Name = domainModel.Name
        };
}