namespace Application.Features.Nodes.Dtos
{
    public class NodeDto
    {
        public uint Id { get; set; }
        public string? Name { get; set; }
        public uint ParentId { get; set; }
    }
}
