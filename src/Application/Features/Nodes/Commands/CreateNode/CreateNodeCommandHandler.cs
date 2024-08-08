using Application.Features.Nodes.Dtos;

namespace Application.Features.Nodes.Commands.CreateNode
{
    internal class CreateNodeCommandHandler : IRequestHandler<CreateNodeCommand, NodeDto>
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public CreateNodeCommandHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<NodeDto> Handle(CreateNodeCommand request, CancellationToken cancellationToken)
        {
            var node = mapper.Map<Node>(request);
            await dbContext.AddAsync(node);
            await dbContext.SaveChangesAsync();
            return mapper.Map<NodeDto>(node);
        }
    }
}
