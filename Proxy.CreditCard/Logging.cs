using System;
using System.Diagnostics;

namespace Proxy.CreditCard
{
    ///
    /// Houses all logging methods for various debug outputs.
    ///
    public static class Logging
    {
        public static void Log(string value)
        {
            Console.WriteLine(value);
        }

        public static void LineSeparator(int length = 40)
        {
            Console.WriteLine(new string('-', length));
        }
    }
}