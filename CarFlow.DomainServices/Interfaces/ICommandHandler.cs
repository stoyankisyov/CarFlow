using CarFlow.Core.Models.Commands;

namespace CarFlow.DomainServices.Interfaces;

public interface ICommandHandler<in TBase, TOut> where TBase : Command
{
    Task<TOut> Handle(TBase command);
}