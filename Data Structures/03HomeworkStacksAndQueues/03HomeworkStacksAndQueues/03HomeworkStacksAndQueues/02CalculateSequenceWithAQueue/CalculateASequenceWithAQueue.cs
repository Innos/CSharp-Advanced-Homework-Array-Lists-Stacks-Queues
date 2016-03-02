using System;
using System.Collections;
using System.Collections.Generic;

namespace _02CalculateSequenceWithAQueue
{
    public class CalculateASequenceWithAQueue
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Queue<int> sequence = new Queue<int>();
            sequence.Enqueue(n);
            var count = 1;

            while (true)
            {
                var current = sequence.Dequeue();
                Console.Write(current + " ");
                var add1 = current + 1;
                count++;
                sequence.Enqueue(add1);
                if (count == 50)
                {
                    break;
                }
                var multiply = current*2 + 1;
                count++;
                sequence.Enqueue(multiply);
                if (count == 50)
                {
                    break;
                }
                var add2 = current + 2;
                count++;
                sequence.Enqueue(add2);
                if (count == 50)
                {
                    break;
                }
            }
            Console.WriteLine(string.Join(" ",sequence));
        }
    }
}
