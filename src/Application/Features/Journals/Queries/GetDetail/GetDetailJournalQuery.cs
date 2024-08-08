using Application.Features.Journals.Dtos;

namespace Application.Features.Journals.Queries.GetDetail
{
    public record GetDetailJournalQuery(uint id) : IRequest<JournalDto>;
}
