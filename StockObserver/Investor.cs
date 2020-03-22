using System;

namespace Observer.Stock
{
    /// <summary>
    /// The 'ConcreteObserver' class
    /// </summary>
    class Investor : IInvestor

    {
        private string _name;

        // Constructor
        public Investor(string name)
        {
            this._name = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine("Notified {0} of {1}'s " + "change to {2:C}", _name, stock.Symbol, stock.Price);
        }

        // Gets or sets the stock
        public Stock Stock { get; set; }
    }
}