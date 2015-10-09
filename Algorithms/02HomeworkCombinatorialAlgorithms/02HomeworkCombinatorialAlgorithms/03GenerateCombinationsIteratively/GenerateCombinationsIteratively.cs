namespace _03GenerateCombinationsIteratively
{
    using System;
    using System.Linq;

    public class GenerateCombinationsIteratively
    {
        private static int[] source;

        private static int[] indexes;

        private static int lastRequiredIndex;

        public static void Main(string[] args)
        {
            Console.Write("Input n:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Input k:");
            int k = int.Parse(Console.ReadLine());

            // the collection we wanna find the combinations of
            //source = new[] { "apple", "banana", "orange", "pear", "apricot" };
            source = Enumerable.Range(1, n).ToArray();

            // an index array with which we track the elements in the current combination (ex. the first combination of 3 elements is the combination of items on indexes [0,1,2] or in this case "apple", "banana", "orange"
            indexes = new int[k];

            lastRequiredIndex = k - 1;

            // we initialize the index array with the first valid combination (because combinations cannot have repetitions like 0,0,0 and because all combinations that have decreasing order in them are just rearrangments of increasing combinations (ex. the combination 3,2,1 is equivalent to 3,1,2 which is equivalent to 1,2,3 as it uses the same indexes(order is not important only indexes used)), thus we can conclude that the combinations are all increasing sequences with length k of a collection of n elements
            for (int i = 0; i < indexes.Length; i++)
            {
                indexes[i] = i;
            }

            GenerateCombinations(n, k);
        }

        // the method which will find all combinations (by finding the indexes of the items used in each combination)
        private static void GenerateCombinations(int totalElements, int requiredElements)
        {
            // the basic flow of the method is Print -> check for exit condition -> reset digit -> check for overflow -> increment index[currentDigit] -> set all elements after the current index to correct values
            while (true)
            {
                // first we print because we initialize the index array with a valid combination
                Print();

                // exit condition, 
                if (indexes[0] + requiredElements == totalElements)
                {
                    break;
                }

                // set the digit we're currently working with to the last digit of the combination (ex. if k = 3, then we need to set currentDigit to the 3rd element in an array this is the element on index k-1 (2)), we do this because everytime we increase a forward digit (ex 0,0,4 -> 0,1,0) we need to then start increasing from the last digit again (0,1,0 -> 0,1,1)  
                int currentDigit = requiredElements - 1;

                // increment the current index 
                indexes[currentDigit]++;

                // overflow check, we calculate the value of the last index by adding to the current index the amount of indexes to the right of it (because at best every right index is equal to his left neighbour + 1) if it overflows, we move one position to the left, increment that index and try again (Note that currentDigit will never reach -1, because the last combination will be the only sequence that fulfills the exit condition)
                while (indexes[currentDigit] + (lastRequiredIndex - currentDigit) == totalElements)
                {
                    currentDigit--;
                    indexes[currentDigit]++;
                }

                // after we're sure that a combination will not overflow, we set the indexes to the right of the current index
                for (int i = currentDigit + 1; i < requiredElements; i++)
                {
                    indexes[i] = indexes[i - 1] + 1;
                }
            }
        }

        private static void Print()
        {
            for (int i = 0; i < indexes.Length; i++)
            {
                Console.Write(source[indexes[i]] + " ");
            }
            Console.WriteLine();
        }
    }
}
