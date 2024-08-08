namespace Application.Features.Nodes.Commands.DeleteNode
{
    public record DeleteNodeCommand(uint id) : IRequest;
}
