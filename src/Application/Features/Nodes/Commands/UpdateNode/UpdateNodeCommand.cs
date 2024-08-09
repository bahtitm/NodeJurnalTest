using Application.Features.Nodes.Dtos;

namespace Application.Features.Nodes.Commands.UpdateNode
{
    internal class UpdateNodeCommand : IRequest<NodeDto>
    {
        public uint Id { get; set; }
        public string? Name { get; set; }
        public uint ParentId { get; set; }
    }
}
