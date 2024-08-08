namespace Application.Features.Journals.Commands.DeleteJournal
{
    internal class DeleteJournalCommandHandler : IRequestHandler<DeleteJournalCommand>
    {
        private readonly IApplicationDbContext dbContext;

        public DeleteJournalCommandHandler(IApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Handle(DeleteJournalCommand request, CancellationToken cancellationToken)
        {
            var journal = await dbContext.FindByIdAsync<Journal>(request.id);
            dbContext.Set<Journal>().Remove(journal);
            await dbContext.SaveChangesAsync();
        }
    }
}
