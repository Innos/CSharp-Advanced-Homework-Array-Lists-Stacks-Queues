namespace _02NestedLoopsToRecursion
{
    using System;
    using System.CodeDom;

    public class NestedLoopsToRecursion
    {
        private static int iterations;

        private static int numberOfLoops;

        private static int[] loops;

        public static void Main(string[] args)
        {
            numberOfLoops = iterations = int.Parse(Console.ReadLine());
            loops = new int[numberOfLoops];
            RecursionLoop(0);
        }

        private static void RecursionLoop(int currentLoop)
        {
            if (currentLoop == numberOfLoops)
            {
                PrintLoops();
                return;
            }

            for (int i = 0; i < iterations; i++)
            {
                loops[currentLoop] = i + 1;
                RecursionLoop(currentLoop + 1);
            }

        }

        private static void PrintLoops()
        {
            for (int i = 0; i < numberOfLoops; i++)
            {
                Console.Write("{0} ", loops[i]);
            }
            Console.WriteLine();
        }
    }
}
