namespace Application.Features.Journals.Commands.DeleteJournal
{
    public record DeleteJournalCommand(uint id) : IRequest;
}
