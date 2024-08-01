using CarFlow.WebAPI.Models;

namespace CarFlow.WebAPI.Mappers;

public static class ModelMapper
{
    /// <summary>
    ///     Converts an enumerable collection of domain models of type <see cref="Core.Models.Model" /> to a list of contracts
    ///     of type
    ///     <see cref="ModelContract" />.
    /// </summary>
    /// <param name="domainModels">The enumerable collection of domain models to be converted.</param>
    /// <returns>A new list of <see cref="ModelContract" /> representing the contracts.</returns>
    public static List<ModelContract> ToContract(this IEnumerable<Core.Models.Model> domainModels)
        => domainModels.Select(x => x.ToContract()).ToList();

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.Model" /> to a contract of type <see cref="ModelContract" />
    ///     .
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of <see cref="ModelContract" /> representing the contract.</returns>
    public static ModelContract ToContract(this Core.Models.Model domainModel)
        => new()
        {
            Id = domainModel.Id,
            Name = domainModel.Name,
            ModelVariant = domainModel.ModelVariant,
            MakeId = domainModel.MakeId
        };
}