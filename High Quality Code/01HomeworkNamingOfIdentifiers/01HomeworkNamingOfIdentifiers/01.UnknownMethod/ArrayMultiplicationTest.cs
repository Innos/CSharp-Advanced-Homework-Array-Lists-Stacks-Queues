namespace _01ArrayActions
{
    #region

    using System;
    using System.Runtime.InteropServices;

    #endregion

    public class ArrayMultiplicationTest
    {
        public static void Main(string[] args)
        {
            var array1 = new double[,] { { 1, 3 }, { 5, 7 } };
            var array2 = new double[,] { { 4, 2 }, { 1, 5 } };
            var resultArray = MultiplyArrays(array1, array2);
            Print(resultArray);
        }

        private static double[,] MultiplyArrays(double[,] array1, double[,] array2)
        {
            if (array1.GetLength(1) != array2.GetLength(0))
            {
                throw new ArgumentException("Matrixes dimensions do not allow multiplication!");
            }

            var array1MaxCols = array1.GetLength(1);
            var resultArray = new double[array1.GetLength(0), array2.GetLength(1)];
            for (var array1Row = 0; array1Row < resultArray.GetLength(0); array1Row++)
            {
                for (var array2Col = 0; array2Col < resultArray.GetLength(1); array2Col++)
                {
                    for (var array1Col = 0; array1Col < array1MaxCols; array1Col++)
                    {
                        resultArray[array1Row, array2Col] += array1[array1Row, array1Col] * array2[array1Col, array2Col];
                    }
                }
            }

            return resultArray;
        }

        private static void Print(double[,] resultArray)
        {
            for (var row = 0; row < resultArray.GetLength(0); row++)
            {
                for (var col = 0; col < resultArray.GetLength(1); col++)
                {
                    Console.Write(resultArray[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}