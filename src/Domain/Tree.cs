namespace Domain
{
    public class Tree : BaseEntity
    {
        public string? Name { get; set; }
        public virtual IEnumerable<Node>? Nodes { get; set; }
    }
}
