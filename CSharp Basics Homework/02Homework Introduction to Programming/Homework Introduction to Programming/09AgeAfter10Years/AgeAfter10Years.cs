using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;




class AgeAfter10Years
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("bg-BG"); //Enforces Bulgarian standart for time reading ex. dd/mm/yyyy instead of mm/dd/yyyy
        Console.Write("Input your birthday(dd/mm/yyyy): ");                             //Because we're used to typing dates in dd/mm/yyyy format
        DateTime birthday = DateTime.Parse(Console.ReadLine());                     
        DateTime currentDate = DateTime.Today;
        int age = 0;
        int comp = DateTime.Compare(birthday.AddYears(1), currentDate);                     //Compares date1 to date2 and returns an integer with negative,0 or positive value
        while (comp <= 0)                                                       //depending on if date2 is before, the same or later than date2
        {
            age++;
            birthday = birthday.AddYears(1);                                        
            comp = DateTime.Compare(birthday.AddYears(1), currentDate);
        }
        Console.WriteLine("You are " + age + " years old");
        Console.WriteLine("After 10 years you will be " + (age+10) + " years old");
    }
}

