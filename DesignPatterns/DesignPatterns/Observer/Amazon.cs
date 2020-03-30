using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class Amazon : Stock
    {
        public Amazon(double price) : base(price)
        {
            Symbol = "AMZN";
        }        
    }   
}
