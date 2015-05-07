using System;
using System.Text;


class IsoscelesTriangle
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        char symbol = '\u00A9';
        Console.Write("Input length of a side of the triangle in ©s: ");
        int lengthInC = int.Parse(Console.ReadLine());
        int rows = lengthInC + (lengthInC - 1);
        int length = (3*(lengthInC - 1)) + lengthInC;
        for (int i = 1; i <= rows ; i++)
        {
            if (i == 1)
            {
                int spacesCount = length - 1;
                string spaces = new String(' ', spacesCount / 2);
                Console.WriteLine("{0}{1}", spaces, symbol);
            }
            else if (i == rows)
            {
                Console.Write(symbol);
                for (int n = 2; n <= lengthInC; n++)
                {
                    Console.Write("   {0}", symbol);
                }
            }
            else if (i % 2 == 0)
            {
                Console.WriteLine();
            }
            else 
            {
                int middleSpace = (i - 2) * 2 + 1;
                int sideSpace = length - middleSpace - 2;
                string sideSpaces = new String(' ', sideSpace / 2);
                string midSpaces = new String(' ', middleSpace);
                Console.WriteLine("{0}{1}{2}{1}{0}", sideSpaces, symbol, midSpaces);
            }
        }
        Console.ReadLine();
    }
}

