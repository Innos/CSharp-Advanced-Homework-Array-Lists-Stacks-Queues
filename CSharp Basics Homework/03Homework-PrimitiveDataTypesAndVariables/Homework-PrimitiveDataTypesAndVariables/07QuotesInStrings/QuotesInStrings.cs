using System;

class QuotesInStrings
{
    static void Main(string[] args)
    {
        string quote1 = @"The ""use"" of quotation marks causes difficulties.";
        string quote2 = "The \"use\" of quotation marks causes difficulties.";
        Console.WriteLine(quote1);
        Console.WriteLine(quote2);
    }
}
