using Application.Features.Journals.Dtos;

namespace Application.Features.Journals.Queries.GetAll
{
    public record GetAllJournalQuery : IRequest<IEnumerable<JournalDto>>;
}
