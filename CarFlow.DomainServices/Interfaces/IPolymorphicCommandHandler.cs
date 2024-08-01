using CarFlow.Core.Models.Commands;

namespace CarFlow.DomainServices.Interfaces;

public interface IPolymorphicCommandHandler<in TBase, in TConcrete, TOut>
    : ICommandHandler<TBase, TOut>
    where TConcrete : TBase where TBase : Command
{
    Task<TOut> Handle(TConcrete command);
}