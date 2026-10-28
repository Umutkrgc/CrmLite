

namespace CrmLite.Domain
{
    public class Customer
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Name { get; set; }
        public string? Industry { get; set; }

        public string? Email { get; set;}
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public List<Deal> Deals { get; set; } = new();
    }
}
