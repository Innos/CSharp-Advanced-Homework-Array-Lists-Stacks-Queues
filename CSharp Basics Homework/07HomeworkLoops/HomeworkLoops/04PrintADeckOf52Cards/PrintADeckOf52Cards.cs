using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrintADeckOf52Cards
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 13; i++)
        {
            string[] cards = {"2","3","4","5","6","7","8","9","10","J","Q","K","A"};
            for (int l = 1; l <= 4; l++)
            {
                switch(l)
                {
                    case 1: Console.Write("{0}♣ ", cards[i]); break;
                    case 2: Console.Write("{0}♦ ", cards[i]); break;
                    case 3: Console.Write("{0}♥ ", cards[i]); break;
                    case 4: Console.Write("{0}♠ ", cards[i]); break;
                }
            }
            Console.WriteLine();
        }
    }
}

