using System;



class Program
{
    static void Main()
    {
    Start:
        Console.Write("1.Decimal to Binary \n2.Decimal to Hexadecimal \n3.Binary to Decimal \n4.Binary to Hexadecimal \n5.Hexadecimal to Decimal \n6.Hexadecimal to Binary \nChoose a conversion (1,2,3,4,5 or 6):");
        int input = int.Parse(Console.ReadLine());
        if (input == 1)
        {
            Console.Write("Input Decimal number: ");
            int number = int.Parse(Console.ReadLine());
            int[] DtoB = DecimalToBinary(number);
            for (int i = 0; i < DtoB.Length; i++)
            {
                Console.Write(DtoB[i]);
            }
            Console.WriteLine();
        }
        else if (input == 2)
        {
            Console.Write("Input Decimal number: ");
            int number = int.Parse(Console.ReadLine());
            string[] DtoH = DecimalToHexadecimal(number);
            for (int i = 0; i < DtoH.Length; i++)
            {
                Console.Write(DtoH[i]);
            }
            Console.WriteLine();
        }
        else if (input == 3)
        {
            Console.Write("Input Binary number: ");
            int number = int.Parse(Console.ReadLine());
            int BtoD = BinaryToDecimal(number);
            Console.WriteLine(BtoD);
        }
        else if (input == 4)
        {
            Console.Write("Input Binary number: ");
            int number = int.Parse(Console.ReadLine());
            int BtoD = BinaryToDecimal(number);
            string[] DtoH = DecimalToHexadecimal(BtoD);
            for (int i = 0; i < DtoH.Length; i++)
            {
                Console.Write(DtoH[i]);
            }
            Console.WriteLine();
        }
        else if (input == 5)
        {
            Console.Write("Input Hexadecimal number: ");
            string number = Console.ReadLine();
            int HtoD = HexadecimalToDecimal(number);
            Console.WriteLine(HtoD);
        }
        else if (input == 6)
        {
            Console.Write("Input Hexadecimal number: ");
            string number = Console.ReadLine();
            int HtoD = HexadecimalToDecimal(number);
            int[] DtoB = DecimalToBinary(HtoD);
            for (int i = 0; i < DtoB.Length; i++)
            {
                Console.Write(DtoB[i]);
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("\nIncorrect Input\n");
            goto Start;
        }
    }


    private static int[] DecimalToBinary(int num)
    {
        int roof = 0;
        int[] Number = new int[0];
        while (num > 0)
        {
            Array.Resize(ref Number, Number.Length + 1);
            Number[roof] = num % 2;
            roof++;
            num = num / 2;
        }
        Array.Reverse(Number);
        return Number;
    }



    private static string[] DecimalToHexadecimal(int num)
    {
        int roof = 0;
        string[] Number = new string[0];
        while (num > 0)
        {
            Array.Resize(ref Number, Number.Length + 1);
            int temp = num % 16;
            if (temp == 10)
            {
                Number[roof] = "A";
            }
            else if (temp == 11)
            {
                Number[roof] = "B";
            }
            else if (temp == 12)
            {
                Number[roof] = "C";
            }
            else if (temp == 13)
            {
                Number[roof] = "D";
            }
            else if (temp == 14)
            {
                Number[roof] = "E";
            }
            else if (temp == 15)
            {
                Number[roof] = "F";
            }
            else
            {
                Number[roof] = temp.ToString();
            }
            roof++;
            num = num / 16;
        }
        Array.Reverse(Number);
        return Number;
    }
    private static int BinaryToDecimal(int num)
    {
        int Decimal = 0;
        int increment = 0;
        while (num > 0)
        {
            int Digit = num % 10;
            if (Digit == 0 || Digit == 1)
            {
                num = num / 10;
                Decimal = (int)(Decimal + Digit * Math.Pow(2, increment));
                increment++;
            }
            else
            {
                Console.WriteLine("\nIncorrect Input\n");
                break;
            }
        }
        return Decimal;
    }
    private static int HexadecimalToDecimal(string num)
    {
        int increment = 0;
        int Decimal = 0;
        for (int i = num.Length - 1; i >= 0; i--)
        {
            char current = num[increment];
            if (current == 'A' || current == 'a')
            {
                Decimal = (int)(Decimal + 10 * Math.Pow(16, i));
            }
            else if (current == 'B' || current == 'b')
            {
                Decimal = (int)(Decimal + 11 * Math.Pow(16, i));
            }
            else if (current == 'C' || current == 'c')
            {
                Decimal = (int)(Decimal + 12 * Math.Pow(16, i));
            }
            else if (current == 'D' || current == 'd')
            {
                Decimal = (int)(Decimal + 13 * Math.Pow(16, i));
            }
            else if (current == 'E' || current == 'e')
            {
                Decimal = (int)(Decimal + 14 * Math.Pow(16, i));
            }
            else if (current == 'F' || current == 'f')
            {
                Decimal = (int)(Decimal + 15 * Math.Pow(16, i));
            }
            else if (current == '1' || current == '2' || current == '3' || current == '4' || current == '5' || current == '6' || current == '7' || current == '8' || current == '9' || current == '0')
            {
                int n = (int)Char.GetNumericValue(current);
                Decimal = (int)(Decimal + n * Math.Pow(16, i));
            }
            else
            {
                Console.WriteLine("\nIncorrect Input\n");
                break;
            }
            increment++;
        }
        return Decimal;
    }
}

