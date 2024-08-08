using Application.Features.Nodes.Commands.CreateNode;
using Application.Features.Nodes.Commands.UpdateNode;
using Application.Features.Nodes.Dtos;

namespace Application.Features.Nodes.MappingProfile
{
    internal class NodeMappingProfile : Profile
    {
        public NodeMappingProfile()
        {
            CreateMap<CreateNodeCommand, Node>();
            CreateMap<UpdateNodeCommand, Node>();
            CreateMap<Node, NodeDto>();
        }
    }
}
