namespace Domain
{
    public class Node : BaseEntity
    {
        public string? Name { get; set; }
        public uint ParentId { get; set; }
        public uint TreeId { get; set; }
        public virtual Tree? Tree { get; set; }
    }
}
