namespace Application.Features.Trees.Commands.DeleteTree
{
    public class DeleteTreeCommandHandler : IRequestHandler<DeleteTreeCommand>
    {
        private readonly IApplicationDbContext dbContext;

        public DeleteTreeCommandHandler(IApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Handle(DeleteTreeCommand request, CancellationToken cancellationToken)
        {
            var tree = await dbContext.FindByIdAsync<Tree>(request.id);
            dbContext.Set<Tree>().Remove(tree);
            await dbContext.SaveChangesAsync();
        }
    }
}
