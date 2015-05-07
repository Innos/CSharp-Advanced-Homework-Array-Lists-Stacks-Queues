using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NumberAsWords
{
    static void Main(string[] args)
    {
        Console.Write("Input an Integer [0-999]: ");
        int num = int.Parse(Console.ReadLine());
        if (num < 0)
        {
            Console.WriteLine("Wrong input");
        }
        else if (num == 0)
        {
            Console.WriteLine("Zero");
        }
        else if (num < 20)
        {
            Console.WriteLine(Capitalization(Exchange(num)));
        }
        else if (num < 100)
        {
            Console.WriteLine(Capitalization(DecimalExchange(num / 10)) + " " + Exchange(num % 10));
        }
        else if(num % 100 == 0)
        {
            Console.WriteLine(Capitalization(Exchange(num/100)) + " hundred");
        }
        else if (num%100 < 20)
        {
            Console.WriteLine(Capitalization(Exchange(num/100)) + " hundred and " + Exchange(num%100));
        }
        else
        {
            Console.WriteLine(Capitalization(Exchange(num/100)) + " hundred and " + DecimalExchange((num/10)%10) + " " + Exchange(num%10));
        }
    }

    private static string Capitalization(string str)
    {
        string capitalizedWord = "";
        switch (str)
        {
            case "one": capitalizedWord = "One"; break;
            case "two": capitalizedWord = "Two"; break;
            case "three": capitalizedWord = "Three"; break;
            case "four": capitalizedWord = "Four"; break;
            case "five": capitalizedWord = "Five"; break;
            case "six": capitalizedWord = "Six"; break;
            case "seven": capitalizedWord = "Seven"; break;
            case "eight": capitalizedWord = "Eight"; break;
            case "nine": capitalizedWord = "Nine"; break;
            case "ten": capitalizedWord = "Ten"; break;
            case "eleven": capitalizedWord = "Eleven"; break;
            case "twelve": capitalizedWord = "Twelve"; break;
            case "thirteen": capitalizedWord = "Thirteen"; break;
            case "fourteen": capitalizedWord = "Fourteen"; break;
            case "fifteen": capitalizedWord = "Fifteen"; break;
            case "sixteen": capitalizedWord = "Sixteen"; break;
            case "seventeen": capitalizedWord = "Seventeen"; break;
            case "eighteen": capitalizedWord = "Eighteen"; break;
            case "nineteen": capitalizedWord = "Nineteen"; break;
            case "twenty": capitalizedWord = "Twenty"; break;
            case "thirty": capitalizedWord = "Thirty"; break;
            case "forty": capitalizedWord = "Forty"; break;
            case "fifty": capitalizedWord = "Fifty"; break;
            case "sixty": capitalizedWord = "Sixty"; break;
            case "seventy": capitalizedWord = "Seventy"; break;
            case "eighty": capitalizedWord = "Eighty"; break;
            case "ninety": capitalizedWord = "Ninety"; break;
        }
        return capitalizedWord;
    }

    private static string Exchange(int num)
    {
        string word = "";
        switch (num)
        {
            case 0: word = ""; break;
            case 1: word = "one"; break;
            case 2: word = "two"; break;
            case 3: word = "three"; break;
            case 4: word = "four"; break;
            case 5: word = "five"; break;
            case 6: word = "six"; break;
            case 7: word = "seven"; break;
            case 8: word = "eight"; break;
            case 9: word = "nine"; break;
            case 10: word = "ten"; break;
            case 11: word = "eleven"; break;
            case 12: word = "twelve"; break;
            case 13: word = "thirteen"; break;
            case 14: word = "fourteen"; break;
            case 15: word = "fifteen"; break;
            case 16: word = "sixteen"; break;
            case 17: word = "seventeen"; break;
            case 18: word = "eighteen"; break;
            case 19: word = "nineteen"; break;
        }
        return word;
    }
    private static string DecimalExchange(int num)
    {
        string word = "";
        switch (num)
        {
            case 2: word = "twenty"; break;
            case 3: word = "thirty"; break;
            case 4: word = "forty"; break;
            case 5: word = "fifty"; break;
            case 6: word = "sixty"; break;
            case 7: word = "seventy"; break;
            case 8: word = "eighty"; break;
            case 9: word = "ninety"; break;
        }
        return word;
    }
}

