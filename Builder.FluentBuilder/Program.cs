using System;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Builder.FluentBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var personBuilder = new PersonBuilder();
            Person person = personBuilder
                .Lives
                    .Street("Cairo")
                    .Postal("12345")
                .Works
                    .IsA("Developer")
                    .InA("Microsoft")
                    .Earning(10000);
            Debug.WriteLine(person.ToString());
        }
    }
}
