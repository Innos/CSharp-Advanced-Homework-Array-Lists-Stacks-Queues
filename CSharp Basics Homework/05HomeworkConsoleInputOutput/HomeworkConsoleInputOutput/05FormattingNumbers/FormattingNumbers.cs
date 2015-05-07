using System;

class FormattingNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input an integer and 2 float numbers each on a seperate line: ");
        int number1 = int.Parse(Console.ReadLine());
        string number1Binary = Convert.ToString(number1,2);
        float number3 = float.Parse(Console.ReadLine());
        float number4 = float.Parse(Console.ReadLine());
        Console.WriteLine("{0,-10:X}|{1,10}|{2,10:F2}|{3,-10:F3}", number1, number1Binary.PadLeft(10,'0'), number3, number4);
    }
}

