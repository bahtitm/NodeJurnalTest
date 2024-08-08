using Application.Features.Journals.Commands.CreateJournal;
using Application.Features.Journals.Commands.UpdateJournal;
using Application.Features.Journals.Dtos;

namespace Application.Features.Journals.MappingProfile
{
    internal class JournalMappingProfile : Profile
    {
        public JournalMappingProfile()
        {
            CreateMap<CreateJournalCommand, Journal>();
            CreateMap<UpdateJournalCommand, Journal>();
            CreateMap<Journal, JournalDto>();
        }
    }
}
