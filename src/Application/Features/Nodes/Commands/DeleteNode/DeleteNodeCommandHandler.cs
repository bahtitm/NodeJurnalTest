namespace Application.Features.Nodes.Commands.DeleteNode
{
    internal class DeleteNodeCommandHandler : IRequestHandler<DeleteNodeCommand>
    {
        private readonly IApplicationDbContext dbContext;

        public DeleteNodeCommandHandler(IApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Handle(DeleteNodeCommand request, CancellationToken cancellationToken)
        {
            var node = await dbContext.FindByIdAsync<Node>(request.id);
            dbContext.Set<Node>().Remove(node);
            await dbContext.SaveChangesAsync();
        }
    }
}
