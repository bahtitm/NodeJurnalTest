using Application.Features.Journals.Dtos;

namespace Application.Features.Journals.Queries.GetAll
{
    internal class GetAllJournalQueryHandler : IRequestHandler<GetAllJournalQuery, IEnumerable<JournalDto>>
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public GetAllJournalQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<JournalDto>> Handle(GetAllJournalQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(dbContext.Set<Journal>().ProjectTo<JournalDto>(mapper.ConfigurationProvider));
        }
    }
}
