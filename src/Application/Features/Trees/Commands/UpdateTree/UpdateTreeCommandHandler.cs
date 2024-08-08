using Application.Features.Trees.Dtos;

namespace Application.Features.Trees.Commands.UpdateTree
{
    public class UpdateTreeCommandHandler : IRequestHandler<UpdateTreeCommand, TreeDto>
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public UpdateTreeCommandHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<TreeDto> Handle(UpdateTreeCommand request, CancellationToken cancellationToken)
        {
            var tree = await dbContext.FindByIdAsync<Tree>(request.Id);
            mapper.Map(request, tree);
            await dbContext.SaveChangesAsync();
            return mapper.Map<TreeDto>(tree);
        }
    }
}
