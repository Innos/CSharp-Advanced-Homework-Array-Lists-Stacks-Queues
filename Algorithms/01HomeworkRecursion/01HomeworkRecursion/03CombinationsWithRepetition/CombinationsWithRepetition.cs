namespace _03CombinationsWithRepetition
{
    using System;

    public class CombinationsWithRepetition
    {
        private static int totalElements;

        private static int desiredElements;

        private static int[] results;

        public static void Main(string[] args)
        {
            totalElements = int.Parse(Console.ReadLine());
            desiredElements = int.Parse(Console.ReadLine());
            results = new int[desiredElements];

            RecursiveLoops(0, 0);
        }

        public static void RecursiveLoops(int currentLoop, int currentElement)
        {
            if (currentLoop == desiredElements)
            {
                PrintCombinations();
                return;
            }
            for (int i = currentElement; i < totalElements; i++)
            {
                results[currentLoop] = i + 1;
                RecursiveLoops(currentLoop + 1, i);
            }
        }

        private static void PrintCombinations()
        {
            Console.WriteLine("({0})", string.Join(" ", results));
        }
    }
}
