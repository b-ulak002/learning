using System.Collections.Generic;

namespace DesignPatterns.Observer
{
    public abstract class Stock : IStock
    {
        private string _symbol;
        private double _price;
        private List<IInvestor> _investors;

        public string Symbol { get => _symbol; set => _symbol = value; }
        public double Price { get => _price; set => _price = value; }

        public Stock(double price)
        {           
            Price = price;
            _investors = new List<IInvestor>();
        }
        public void NotifyInvestors()
        {
           foreach(IInvestor investor in _investors)
            {
                investor.Update(this);
            }
        }

        public void RegisterInvestor(IInvestor investor)
        {
            _investors.Add(investor);
        }

        public void UnregisterInvestor(IInvestor investor)
        {
            _investors.Remove(investor);
        }

        public void PriceChanged(double price)
        {
            _price = price;
            NotifyInvestors();
        }
    }
}