using Application.Features.Journals.Dtos;

namespace Application.Features.Journals.Commands.UpdateJournal
{
    internal class UpdateJournalCommandHandler : IRequestHandler<UpdateJournalCommand, JournalDto>
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public UpdateJournalCommandHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<JournalDto> Handle(UpdateJournalCommand request, CancellationToken cancellationToken)
        {
            var journal = await dbContext.FindByIdAsync<Journal>(request.Id);
            mapper.Map(request, journal);
            await dbContext.SaveChangesAsync();
            return mapper.Map<JournalDto>(journal);
        }
    }
}
