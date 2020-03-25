using System;
using System.Diagnostics;

namespace Builder.HTMLBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //var htmlElement = new HtmlElement("p","test");
            //Debug.WriteLine(htmlElement.ToString());

            var htmlBuilder = new HtmlBuilder("ul");
            htmlBuilder.AddChildFluent("li","first")
                .AddChildFluent("li","second")
                .AddChildFluent("li","third");
            Debug.WriteLine(htmlBuilder);
            htmlBuilder.Clear();
            Debug.WriteLine(htmlBuilder);
        }
    }
}
