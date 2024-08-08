using Application.Features.Nodes.Dtos;

namespace Application.Features.Nodes.Commands.UpdateNode
{
    internal class UpdateNodeCommandHandler : IRequestHandler<UpdateNodeCommand, NodeDto>
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public UpdateNodeCommandHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<NodeDto> Handle(UpdateNodeCommand request, CancellationToken cancellationToken)
        {
            var node = await dbContext.FindByIdAsync<Node>(request.Id);
            mapper.Map(request, node);
            await dbContext.SaveChangesAsync();
            return mapper.Map<NodeDto>(node);
        }
    }
}
