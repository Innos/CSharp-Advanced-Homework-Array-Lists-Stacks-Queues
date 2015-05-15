using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FillTheMatrix
{
    static int counter = 1;

    static void Main(string[] args)
    {
        int[,] matrixA = new int[4,4];
        int[,] matrixB = new int[4,4];
        FillMethodA(matrixA);
        FillMethodB(matrixB);
        PrintMatrix(matrixA);
        PrintMatrix(matrixB);
    }
    static void FillMethodA(int[,]matrix)
    {
        for (int col = 0; col < matrix.GetLength(0); col++)
        {
            FillColumnAscending(matrix,col);
        }
        counter = 1;
    }
    static void FillMethodB(int[,]matrix)
    {
        bool descending = false;
        for (int col = 0; col < matrix.GetLength(0); col++)
        {
            if (descending)
            {
                FillColumnDescending(matrix, col);
            }
            else
            {
                FillColumnAscending(matrix, col);
            }
            descending = !descending;
        }
        counter = 1;
    }
    static void FillColumnAscending(int[,]matrix, int col)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            matrix[row, col] = counter++;
        }
    }

    static void FillColumnDescending(int[,] matrix, int col)
    {
        for (int row = matrix.GetUpperBound(0); row >= 0; row--)
        {
            matrix[row, col] = counter++;
        }
    }

    static void PrintMatrix(int[,]matrix)
    {
        for (int row = 0; row < matrix.GetLength(0);row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,4}",matrix[row,col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("{0}",new string('=',matrix.GetLength(1)*4));
        Console.WriteLine();
    }
}

