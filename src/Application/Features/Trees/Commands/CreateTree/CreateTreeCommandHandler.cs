using Application.Features.Trees.Dtos;

namespace Application.Features.Trees.Commands.CreateTree
{
    internal class CreateTreeCommandHandler : IRequestHandler<CreateTreeCommand, TreeDto>
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public CreateTreeCommandHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<TreeDto> Handle(CreateTreeCommand request, CancellationToken cancellationToken)
        {
            var tree = mapper.Map<Tree>(request);
            await dbContext.AddAsync(tree);
            await dbContext.SaveChangesAsync();
            return mapper.Map<TreeDto>(tree);
        }
    }
}
