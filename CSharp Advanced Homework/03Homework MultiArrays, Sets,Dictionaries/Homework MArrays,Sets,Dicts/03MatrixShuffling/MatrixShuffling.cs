using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MatrixShuffling
{
    static void Main(string[] args)
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        string[,] matrix = new string[rows, cols];
        FillMatrix(matrix, rows, cols);
        SwapCycle(matrix);
    }
    static void FillMatrix(string[,] matrix, int rows, int cols)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int l = 0; l < cols; l++)
            {
                matrix[i, l] = Console.ReadLine();
            }
        }
    }
    static void SwapCycle(string[,] matrix)
    {
        string action = Console.ReadLine();
        while (action != "END")
        {
            string[] commands = action.Split();
            if(ConditionCheck(commands,matrix))
            {
                Console.WriteLine("Invalid input");
                Console.WriteLine();
            }
            else
            {
                int x1 = int.Parse(action.Split()[1]);
                int y1 = int.Parse(action.Split()[2]);
                int x2 = int.Parse(action.Split()[3]);
                int y2 = int.Parse(action.Split()[4]);

                //methods
                Swap(matrix, x1, y1, x2, y2);
                Print(matrix);

            }
            action = Console.ReadLine();
        }
    }

    static bool ConditionCheck(string[] commands, string[,] matrix)
    {
        if (commands.Length != 5 || commands[0] != "swap")
        {
            return true;
        }
        else
        {
            for (int i = 1; i < 5; i++)
            {
                int x;
                bool isValid = int.TryParse(commands[i], out x);
                if (isValid == false || x < 0 ||
                    ((i == 1 || i == 3) && x > matrix.GetUpperBound(0)) ||
                    ((i == 2 || i == 4) && x > matrix.GetUpperBound(1)))
                {
                    return true;
                }
            }
        }
        return false;
    }

    static void Swap(string[,] matrix, int x1,int y1, int x2, int y2)
    {
        string temp = matrix[x1, y1];
        matrix[x1, y1] = matrix[x2, y2];
        matrix[x2, y2] = temp;
    }

    static void Print(string[,]matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int l = 0; l < matrix.GetLength(1); l++)
            {
                Console.Write("{0} ", matrix[i, l]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

