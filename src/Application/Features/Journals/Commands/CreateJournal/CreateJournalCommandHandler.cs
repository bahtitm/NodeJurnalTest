using Application.Features.Journals.Dtos;

namespace Application.Features.Journals.Commands.CreateJournal
{
    internal class CreateJournalCommandHandler : IRequestHandler<CreateJournalCommand, JournalDto>
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public CreateJournalCommandHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<JournalDto> Handle(CreateJournalCommand request, CancellationToken cancellationToken)
        {
            var journal = mapper.Map<Journal>(request);
            await dbContext.AddAsync(journal);
            await dbContext.SaveChangesAsync();
            return mapper.Map<JournalDto>(journal);
        }
    }
}
