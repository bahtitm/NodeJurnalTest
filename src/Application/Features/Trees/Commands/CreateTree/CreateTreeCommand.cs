using Application.Features.Trees.Dtos;

namespace Application.Features.Trees.Commands.CreateTree
{
    public class CreateTreeCommand : IRequest<TreeDto>
    {
        public string? Name { get; set; }
    }
}
