using CarFlow.Core.Models.Commands;
using CarFlow.DomainServices.Interfaces;

namespace CarFlow.DomainServices.Handlers;

public abstract class PolymorphicCommandHandler<T, TConcrete, TOut>
    : IPolymorphicCommandHandler<T, TConcrete, TOut>
    where TConcrete : Command, T where T : Command
{
    public Task<TOut> Handle(T command)
        => command is null ? throw new ArgumentNullException(nameof(command)) : Handle((TConcrete)command);

    public abstract Task<TOut> Handle(TConcrete command);
}