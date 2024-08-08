namespace Application.Features.Trees.Commands.DeleteTree
{
    public record DeleteTreeCommand(uint id) : IRequest;
}
