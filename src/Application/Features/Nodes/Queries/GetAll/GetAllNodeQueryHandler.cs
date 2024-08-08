using Application.Features.Nodes.Dtos;

namespace Application.Features.Nodes.Queries.GetAll
{
    internal class GetAllNodeQueryHandler : IRequestHandler<GetAllNodeQuery, IEnumerable<NodeDto>>
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public GetAllNodeQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<NodeDto>> Handle(GetAllNodeQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(dbContext.Set<Node>().ProjectTo<NodeDto>(mapper.ConfigurationProvider));
        }
    }
}
