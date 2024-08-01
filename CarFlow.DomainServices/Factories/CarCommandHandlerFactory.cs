using CarFlow.Core.Models;
using CarFlow.Core.Models.Commands;
using CarFlow.DomainServices.Interfaces;

namespace CarFlow.DomainServices.Factories;

public class CarCommandHandlerFactory(IServiceProvider serviceProvider) : CommandHandlerFactory(serviceProvider)
{
    public ICommandHandler<T, Car> Resolve<T>(T command) where T : CarCommand
        => ResolvePolymorphic<T, CarCommand, Car>(command);
}