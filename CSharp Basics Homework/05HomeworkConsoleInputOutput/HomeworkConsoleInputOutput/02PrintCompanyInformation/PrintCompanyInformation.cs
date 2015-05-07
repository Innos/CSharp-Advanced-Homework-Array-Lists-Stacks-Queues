using System;

class PrintCompanyInformation
{
    static void Main(string[] args)
    {
        Console.Write("Input Company name: ");
        string company = Console.ReadLine();
        Console.Write("Input Company adress: ");
        string adress = Console.ReadLine();
        Console.Write("Input Company phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Input fax: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Input Company web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Input manager's first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Input manager's last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Input manager's age: ");
        string managerAge = Console.ReadLine();
        Console.Write("Input manager's Phone number: ");
        string managerPhoneNumber = Console.ReadLine();
        Console.WriteLine("{0}"
            + "\nAdress: {1}"
            + "\nTel.: {2}"
            + "\nFax: {3}"
            + "\nWeb Site: {4}"
            + "\nManager: {5} {6} (age: {7}, tel. {8})",company,adress,phoneNumber,faxNumber,webSite,managerFirstName,managerLastName,managerAge,managerPhoneNumber);

    }
}

