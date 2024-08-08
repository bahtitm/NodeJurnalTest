using Application.Features.Trees.Dtos;

namespace Application.Features.Trees.Queries.GetAll
{
    public record GetAllTreeQuery : IRequest<IEnumerable<TreeDto>>;
}
