using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class Investor : IInvestor
    {
        private string _name;
        private List<Stock> _stocks;

        public string Name { get => _name; set => _name = value; }

        public Investor(string name)
        {
            Name = name;
            _stocks = new List<Stock>();
        }

        public void BuyStock(Stock stock)
        {
            _stocks.Add(stock);
            stock.RegisterInvestor(this);
        }

        public void SellStock(Stock stock)
        {
            _stocks.Remove(stock);
            stock.UnregisterInvestor(this);           
        }
       

        public void Update(Stock stock)
        {
            if (_stocks.Contains(stock))
            {
                Console.WriteLine($"{_name} is notified for {stock.Symbol}. New Price = {stock.Price}");
            }
        }
    }
}
