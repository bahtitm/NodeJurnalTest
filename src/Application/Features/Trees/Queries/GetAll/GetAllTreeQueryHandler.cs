using Application.Features.Trees.Dtos;

namespace Application.Features.Trees.Queries.GetAll
{
    internal class GetAllTreeQueryHandler : IRequestHandler<GetAllTreeQuery, IEnumerable<TreeDto>>
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public GetAllTreeQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<TreeDto>> Handle(GetAllTreeQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(dbContext.Set<Tree>().ProjectTo<TreeDto>(mapper.ConfigurationProvider));
        }
    }
}
