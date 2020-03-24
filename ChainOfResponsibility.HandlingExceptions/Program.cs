using System;

namespace ChainOfResponsibility.HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Method1();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("ArgumentException: Handled in Main");
                Console.WriteLine("==========================================");
                Method1();
            }
        }

        static void Method1()
        {
            try
            {
                Method2();

            }
            catch (NullReferenceException)
            {
                Console.WriteLine("NullReferenceException: Handled in Method1");
                Console.WriteLine("==========================================");
                Method1();
            }
        }
        static void Method2()
        {
            try
            {
                Console.WriteLine("Choose number to fire an exception:");
                Console.WriteLine("1. AccessViolationException");
                Console.WriteLine("2. NullReferenceException");
                Console.WriteLine("3. ArgumentException");
                var input = Console.ReadKey().Key;
                Console.WriteLine();
                switch (input)
                {
                    case ConsoleKey.D1:
                        throw new AccessViolationException();
                    case ConsoleKey.D2:
                        throw new NullReferenceException();
                    case ConsoleKey.D3:
                        throw new ArgumentException();
                }
            }
            catch (AccessViolationException)
            {
                Console.WriteLine("AccessViolationException: Handled in Method2");
                Console.WriteLine("==========================================");
                Method1();
            }
        }
    }
}
