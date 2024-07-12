namespace CarFlow.Infrastructure.Mappers
{
    public static class AccountMapper
    {
        /// <summary>
        /// Converts Models.Account/Entity/ to Core.Models.Account/DM/
        /// </summary>
        /// <param name="entity"></param>
        /// <returns> Core.Models.Account </returns>
        public static Core.Models.Account ToDomainModel(this Models.Account entity)
            => new(entity.Id, entity.Roles.ToDomainModel(), entity.Name, entity.Email, entity.Phone, entity.Password, entity.Address);

        /// <summary>
        /// Converts Core.Models.Account/DM/ to Models.Account/Entity/ 
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> Models.Account </returns>
        public static Models.Account ToEntity(this Core.Models.Account domainModel)
            => new()
            {
                Id = domainModel.Id,
                Roles = domainModel.Roles.ToEntities(),
                Name = domainModel.Name,
                Email = domainModel.Email,
                Phone = domainModel.Phone,
                Password = domainModel.Password,
                Address = domainModel.Address
            };
    }
}
