﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SequenceInMatrix
{
    static int maxLength;
    static string element;

    static void Main(string[] args)
    {
        ////2 test matrices
        //string[,] matrix1 = {
        //                       {"ha","fifi","ho","hi"},
        //                       {"fo","ha","hi","xx"},
        //                       {"xxx","ho","ha","xx"}
        //                   };
        //string[,] matrix2 = {
        //                        {"s","qq","s"},
        //                        {"pp","pp","s"},
        //                        {"pp","qq","s"}
        //                    };

        Console.WriteLine("Input rows and cols each on a seperate line, then for the next rows number of \nlines input the row's content on a single line seperated by spaces \nexample: \n2\n2 \nzz qq \naq za");
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        string[,] matrix = new string[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            string[] input = Console.ReadLine().Split();
            for (int l = 0; l < cols; l++)
            {
                matrix[i, l] = input[l];
            }
        }
        maxLength = 1;
        element = matrix[0, 0];
        FindLongestSequence(matrix);
        Print();

    }
    static void FindLongestSequence(string[,] matrix)
    {
        //no need to search the entire matrix only searching the 3 outer sides is enough (left, top/bot,right sides)
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            CheckDirections(matrix, 0, col);
        }
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            CheckDirections(matrix, row, 0);
            CheckDirections(matrix, row, matrix.GetUpperBound(1));
        }

    }
    static void CheckDirections(string[,] matrix, int row, int col)
    {
        int rChange = 0;
        int cChange = 0;
        for (int i = 0; i < 4; i++) //directions 0 = right, 1 = rigthDownDiagonal, 2 = down, 3 = leftDownDiagonal
        {
            string start = matrix[row, col];
            int length = 1;
            switch (i)
            {
                case 0: rChange = 0; cChange = 1; break;
                case 1: rChange = 1; cChange = 1; break;
                case 2: rChange = 1; cChange = 0; break;
                case 3: rChange = 1; cChange = -1; break;
            }
            int tempRow = row;
            int tempCol = col;
            while (true)
            {
                tempRow += rChange;
                tempCol += cChange;
                if (tempRow < 0 || tempRow > matrix.GetUpperBound(0) || tempCol < 0 || tempCol > matrix.GetUpperBound(1))
                {
                    break;
                }
                string currentElement = matrix[tempRow, tempCol];
                if (currentElement.Equals(start))
                {
                    length++;
                }
                else
                {
                    length = 1;
                    start = currentElement;
                }
                if (length > maxLength)
                {
                    maxLength = length;
                    element = start;
                }
            }


        }
    }
    static void Print()
    {
        for (int i = 0; i < maxLength; i++)
        {
            if (i == maxLength - 1)
            {
                Console.WriteLine(element);
            }
            else
            {
                Console.Write(element + ", ");
            }
        }
    }
}

