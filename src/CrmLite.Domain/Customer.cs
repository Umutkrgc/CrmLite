using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmLite.Domain
{
    public class Customer
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Name { get; set; }
        public string? Industry { get; set; }

        public string? Email { get; set;}
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
