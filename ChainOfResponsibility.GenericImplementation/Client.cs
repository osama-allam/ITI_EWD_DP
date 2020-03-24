using System;
using System.Collections.Generic;

namespace ChainOfResponsibility.GenericImplementation
{
    class Client
    {
        // The client code is usually suited to work with a single handler. In
        // most cases, it is not even aware that the handler is part of a chain.
        public static void ClientCode(AbstractHandler handler)
        {
            foreach (var request in new List<string> { "First Request", "Second Request", "Third Request", "Fourth Request" })
            {
                Console.WriteLine($"Client: Who wants to handle {request}?");

                var result = handler.Handle(request);

                if (result != null)
                {
                    Console.Write($"   {result}");
                }
                else
                {
                    Console.WriteLine($"   {request} was left untouched.");
                }
            }
        }
    }
}