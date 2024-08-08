using Application.Features.Journals.Dtos;

namespace Application.Features.Journals.Commands.UpdateJournal
{
    internal class UpdateJournalCommand : IRequest<JournalDto>
    {
        public uint Id { get; set; }
    }
}
