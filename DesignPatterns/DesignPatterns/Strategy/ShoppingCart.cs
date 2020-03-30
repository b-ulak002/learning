using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern
{
    public class ShoppingCart
    {
        public string CustomerName { get; set; }
        public double BillAmount { get; set; }

        public IStrategy Strategy;

        public ShoppingCart(IStrategy strategy)
        {
            Strategy = strategy;
        }

        public double GetFinalBill()
        {
            return Strategy.GetFinalBill(BillAmount);
        }
    }
}
