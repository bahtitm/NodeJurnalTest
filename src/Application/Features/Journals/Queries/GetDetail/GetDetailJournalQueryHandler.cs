using Application.Features.Journals.Dtos;

namespace Application.Features.Journals.Queries.GetDetail
{
    internal class GetDetailJournalQueryHandler : IRequestHandler<GetDetailJournalQuery, JournalDto>
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public GetDetailJournalQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
        public async Task<JournalDto> Handle(GetDetailJournalQuery request, CancellationToken cancellationToken)
        {
            var journal = await dbContext.FindByIdAsync<Journal>(request.id);
            return mapper.Map<JournalDto>(journal);
        }
    }
}
