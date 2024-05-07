namespace Inventory.Entities
{
    public class InventoryStock
    {
        public int Id { get; set; }
        public string? ProductId { get; set; }
        public int Quantity { get; set; }
        public string? Location { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}