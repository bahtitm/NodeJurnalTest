using Application.Features.Nodes.Dtos;

namespace Application.Features.Nodes.Commands.CreateNode
{
    public class CreateNodeCommand : IRequest<NodeDto>
    {
        public string? Name { get; set; }
        public uint ParentId { get; set; }
    }
}
