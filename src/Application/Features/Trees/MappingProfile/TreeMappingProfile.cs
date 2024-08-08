using Application.Features.Trees.Commands.CreateTree;
using Application.Features.Trees.Commands.UpdateTree;
using Application.Features.Trees.Dtos;

namespace Application.Features.Trees.MappingProfile
{
    public class TreeMappingProfile : Profile
    {
        public TreeMappingProfile()
        {
            CreateMap<CreateTreeCommand, Tree>();
            CreateMap<UpdateTreeCommand, Tree>();
            CreateMap<Tree, TreeDto>();
        }
    }
}
