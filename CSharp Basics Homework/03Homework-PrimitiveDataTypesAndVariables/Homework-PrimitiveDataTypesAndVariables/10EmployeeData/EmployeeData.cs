using System;



class EmployeeData
{
    static void Main(string[] args)
    {
        string firstName = "Somebody";
        string lastName = "Somewhere";
        byte age = 30;
        char sex = 'm';
        string personalID = "9334675925";
        uint employeeNumber = 27564444;
        Console.WriteLine("Name: {0} {1}",firstName, lastName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Sex: {0}", sex);
        Console.WriteLine("Personal ID: {0}", personalID);
        Console.WriteLine("Unique Employee Number: {0}", employeeNumber);
    }
}

