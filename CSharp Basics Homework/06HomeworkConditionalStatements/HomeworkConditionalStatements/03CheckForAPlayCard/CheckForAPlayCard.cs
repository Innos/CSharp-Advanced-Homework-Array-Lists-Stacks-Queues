using System;

class CheckForAPlayCard
{
    static void Main(string[] args)
    {
        string[] cards = new String[13] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        Console.Write("Input a string to check if it is a card: ");
        string input = Console.ReadLine();
        switch (input)
        {
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "10":
            case "J":
            case "Q":
            case "K":
            case "A":
                Console.WriteLine("yes");
                break;
            default:
                Console.WriteLine("no");
                break;
        }
    }
}
