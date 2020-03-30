using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public interface IStock
    {
        void RegisterInvestor(IInvestor investor);
        void UnregisterInvestor(IInvestor investor);
        void NotifyInvestors();
    }
}
