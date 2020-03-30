using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern
{
    public class FiftyPercentDiscountStrategy :IStrategy
    {
        public double GetFinalBill(double BillAmount)
        {
            return BillAmount - (BillAmount * 0.5);
        }
    }
}
