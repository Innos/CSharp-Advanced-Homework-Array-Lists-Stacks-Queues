using System;
using System.Text;


class PrintTheASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.ASCII;
        int column = 1;
        for (byte counter = 0; counter < 255; counter++)
        {
            Console.Write(" {0}  ", (char)counter);
            if (++column > 10)
            {
                column = 1;
                Console.WriteLine();
            }

        }
        Console.ReadLine();

    }
}
