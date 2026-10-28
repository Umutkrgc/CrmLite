
namespace CrmLite.Domain
{
    public class Deal
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Title { get; set; }
        public decimal Value { get; set; }
        public DealStage Stage { get; set; } = DealStage.New;
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
