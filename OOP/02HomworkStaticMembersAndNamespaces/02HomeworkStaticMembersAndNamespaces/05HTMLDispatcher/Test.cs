using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLDispatcher
{
    class Test
    {
        static void Main(string[] args)
        {
            ElementBuilder div = new ElementBuilder("div");
            div.AddAtribute("id", "page");
            div.AddAtribute("class", "big");
            div.AddContent("<p>Hello</p>");
            Console.WriteLine(div * 3);

            string image = HTMLDispatcher.CreateImage("../../test.jpg", "test", "Test Image");
            string url = HTMLDispatcher.CreateURL("www.google.bg", "Google", "Welcome to Google!");
            string input = HTMLDispatcher.CreateInput("text", "Random Text", "It's Random Text");

            Console.WriteLine(image);
            Console.WriteLine(url);
            Console.WriteLine(input);
        }
    }
}
