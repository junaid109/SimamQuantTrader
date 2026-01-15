using System;
using SimamQuantTrader.Core.Enums;

namespace SimamQuantTrader.Core.Entities
{
    public class Order
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Symbol { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; } // Nullable for Market orders? Usually 0 or implied. Keeping decimal for now.
        public OrderType Type { get; set; }
        public Side Side { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public string Status { get; set; } = "Pending"; // Consider an Enum for this as well
    }
}
