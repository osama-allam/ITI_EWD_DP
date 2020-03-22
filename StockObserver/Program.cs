using System;

namespace Observer.Stock
{
    /// <summary>
    /// MainApp startup class for Real-World 
    /// Observer Design Pattern.
    /// </summary>
    class Program

    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            // Create IBM stock and attach investors

            IBM ibm = new IBM("IBM", 120.00);
            ibm.Subscribe(new Investor("Sorros"));
            ibm.Subscribe(new Investor("Berkshire"));

            // Fluctuating prices will notify investors

            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;

            // Wait for user

            Console.ReadKey();
        }
    }
}