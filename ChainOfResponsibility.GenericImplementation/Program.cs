using System;

namespace ChainOfResponsibility.GenericImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            // The other part of the client code constructs the actual chain.
            var firstHandler = new FirstHandler();
            var secondHandler = new SecondHandler();
            var thirdHandler = new ThirdHandler();

            firstHandler.SetNext(secondHandler).SetNext(thirdHandler);

            // The client should be able to send a request to any handler, not
            // just the first one in the chain.
            Console.WriteLine("Chain: First > Second > Third\n");
            Client.ClientCode(firstHandler);
            Console.WriteLine();

            Console.WriteLine("Sub-chain: Second > Third\n");
            Client.ClientCode(secondHandler);
        }
    }
}
