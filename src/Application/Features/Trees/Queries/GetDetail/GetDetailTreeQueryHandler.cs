using Application.Features.Trees.Dtos;

namespace Application.Features.Trees.Queries.GetDetail
{
    internal class GetDetailTreeQueryHandler : IRequestHandler<GetDetailTreeQuery, TreeDto>
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public GetDetailTreeQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
        public async Task<TreeDto> Handle(GetDetailTreeQuery request, CancellationToken cancellationToken)
        {
            var Tree = await dbContext.FindByIdAsync<Tree>(request.id);
            return mapper.Map<TreeDto>(Tree);
        }
    }
}
