using Application.Features.Nodes.Dtos;

namespace Application.Features.Nodes.Queries.GetDetail
{
    internal class GetDetailNodeQueryHandler : IRequestHandler<GetDetailNodeQuery, NodeDto>
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public GetDetailNodeQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
        public async Task<NodeDto> Handle(GetDetailNodeQuery request, CancellationToken cancellationToken)
        {
            var Node = await dbContext.FindByIdAsync<Node>(request.id);
            return mapper.Map<NodeDto>(Node);
        }
    }
}
