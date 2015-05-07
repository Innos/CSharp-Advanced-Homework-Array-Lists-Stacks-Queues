using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SpiralMatrix
{
    static void Main(string[] args)
    {
        Console.Write("Input an integer: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int row = 0;
        int col = 0;
        string direction = "right";
        for (int i = 1; i <= (n * n); i++)
        {
            if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
            {
                direction = "down";
                col--;
                row++;
            }
            if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
            {
                direction = "left";
                row--;
                col--;
            }
            if (direction == "left" && (col < 0 || matrix[row, col] != 0))
            {
                direction = "up";
                col++;
                row--;
            }
            if (direction == "up" && (row < 0 || matrix[row, col] != 0))
            {
                direction = "right";
                col++;
                row++;
            }
            matrix[row, col] = i;
            if (direction == "right")
            {
                col++;
            }
            else if (direction == "down")
            {
                row++;
            }
            else if (direction == "left")
            {
                col--;
            }
            else if (direction == "up")
            {
                row--;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int l = 0; l < n; l++)
            {
                Console.Write("{0,-8}",matrix[i,l]);
            }
            Console.WriteLine();
        }
    }
}

