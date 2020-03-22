using System;
using System.Collections.Generic;
using System.Threading;

namespace Observer.Stock
{
    /// <summary>
    /// The 'Subject' abstract class
    /// </summary>
    abstract class Stock

    {
        private string _symbol;
        private double _price;
        private List<IInvestor> _investors = new List<IInvestor>();

        // Constructor

        public Stock(string symbol, double price)
        {
            this._symbol = symbol;
            this._price = price;
        }

        public void Subscribe(IInvestor investor)
        {
            _investors.Add(investor);
        }

        public void Unsubscribe(IInvestor investor)
        {
            _investors.Remove(investor);
        }

        public void Notify()
        {
            foreach (IInvestor investor in _investors)
            {
                investor.Update(this);
            }

            Console.WriteLine("");
        }

        // Gets or sets the price

        public double Price
        {
            get => _price;
            set

            {
                if (_price != value)
                {
                    _price = value;
                    Thread.Sleep(2000);
                    Notify();
                }
            }
        }

        // Gets the symbol

        public string Symbol
        {
            get { return _symbol; }
        }
    }
}