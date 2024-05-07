namespace Inventory.Entities
{
    public class MovementType
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool IsIncoming { get; set; }
        public bool IsOutgoing { get; set; }
        public bool IsInternalTransfer { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}