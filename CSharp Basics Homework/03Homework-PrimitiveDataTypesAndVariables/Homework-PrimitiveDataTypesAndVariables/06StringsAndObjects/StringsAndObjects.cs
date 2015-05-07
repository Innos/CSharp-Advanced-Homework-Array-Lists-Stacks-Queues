using System;

class StringsAndObjects
{
    static void Main(string[] args)
    {
        string hello = "Hello";
        string world = "World";
        object concatenate = hello +" " + world;
        string greetings = (string)concatenate;
        Console.WriteLine(greetings);
    }
}

