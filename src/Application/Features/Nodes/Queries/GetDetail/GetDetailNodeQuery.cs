using Application.Features.Nodes.Dtos;

namespace Application.Features.Nodes.Queries.GetDetail
{
    public record GetDetailNodeQuery(uint id) : IRequest<NodeDto>;
}
