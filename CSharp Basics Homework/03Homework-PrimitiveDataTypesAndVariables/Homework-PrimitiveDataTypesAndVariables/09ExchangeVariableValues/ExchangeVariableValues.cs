using System;



class ExchangeVariableValues
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        int swap;
        Console.WriteLine("a = {0} b = {1}", a, b);
        swap = a;
        a = b;
        b = swap;
        Console.WriteLine("After exchanging a = {0} b = {1}", a, b);
    }
}

