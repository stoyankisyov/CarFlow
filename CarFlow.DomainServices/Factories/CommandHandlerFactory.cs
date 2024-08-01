using CarFlow.Core.Models.Commands;
using CarFlow.DomainServices.Interfaces;

namespace CarFlow.DomainServices.Factories;

public class CommandHandlerFactory(IServiceProvider serviceProvider)
{
    protected ICommandHandler<TConcrete, TOut> ResolvePolymorphic<TConcrete, TBase, TOut>(TConcrete command)
        where TConcrete : Command, TBase where TBase : Command
    {
        var commandType = command.GetType();
        var baseCommandType = typeof(TBase);
        var returnType = typeof(TOut);
        var serviceType =
            typeof(IPolymorphicCommandHandler<,,>).MakeGenericType(baseCommandType, commandType, returnType);
        var service = serviceProvider.GetService(serviceType);

        return service is not null
            ? (ICommandHandler<TConcrete, TOut>)service
            : throw new InvalidOperationException("Service not found");
    }
}