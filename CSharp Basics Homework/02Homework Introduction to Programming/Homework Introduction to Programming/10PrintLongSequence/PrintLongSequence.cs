using System;



class PrintSequence
{
    static void Main()
    {
        int numbersprinted = 0;
        for (int i = 2; i <= 1001; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + ",");
                numbersprinted += 1;
            }
            else if (i != 1001)
            {
                Console.Write(-i + ",");
                numbersprinted += 1;
            }
            else
            {
                Console.Write(-i);
                numbersprinted += 1;
            }
        }
        Console.WriteLine("\nNumbers Printed:{0}", numbersprinted);
    }
}

