using System;
namespace validate;

class Program
{
    public static void Main(string[] args)
    {
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter the last name = ");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter the email = ");
        string email = Console.ReadLine();
        Console.WriteLine("Enter the mobile pattern = ");
        string mobilePattern = Console.ReadLine();
        Console.WriteLine("Enter the password = ");
        string preDefinedPassword = Console.ReadLine();


        RegValidation check = new RegValidation();

        Console.WriteLine(check.validateFirstName(firstName));
        Console.WriteLine(check.validateLastName(lastName));
        Console.WriteLine(check.validateEmail(email));
        Console.WriteLine(check.validateMobileFormat(mobilePattern));
        Console.WriteLine(check.validatePreDefinedPassword(preDefinedPassword));
    }
}