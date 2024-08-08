using Application.Features.Nodes.Dtos;

namespace Application.Features.Nodes.Queries.GetAll
{
    public record GetAllNodeQuery : IRequest<IEnumerable<NodeDto>>;
}
