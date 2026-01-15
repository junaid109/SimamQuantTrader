using System;
using System.Collections.Generic;

namespace SimamQuantTrader.Core.Entities
{
    public class Portfolio
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public decimal CashBalance { get; set; }
        public List<Position> Positions { get; set; } = new List<Position>();
    }

    public class Position
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Symbol { get; set; }
        public decimal Quantity { get; set; }
        public decimal AverageEntryPrice { get; set; }
        public decimal CurrentPrice { get; set; } // Updated via market data
        
        public decimal MarketValue => Quantity * CurrentPrice;
        public decimal PnL => (CurrentPrice - AverageEntryPrice) * Quantity;
    }
}
