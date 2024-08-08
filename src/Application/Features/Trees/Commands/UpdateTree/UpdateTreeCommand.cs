using Application.Features.Trees.Dtos;

namespace Application.Features.Trees.Commands.UpdateTree
{
    public class UpdateTreeCommand : IRequest<TreeDto>
    {
        public uint Id { get; set; }
    }
}
