using Application.Features.Trees.Dtos;

namespace Application.Features.Trees.Queries.GetDetail
{
    public record GetDetailTreeQuery(uint id) : IRequest<TreeDto>;
}
