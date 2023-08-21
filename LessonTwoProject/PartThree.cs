using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PartThreeC
{
    public static void PartThree()
    {
        string firstName = "John";
        string lastName = "Doe";
        int age = 30;
        int yearsUntil40 = 40 - age;

        string fullName = $"{firstName} {lastName}";
        string message = $"Hello, my name is {fullName}. I have {yearsUntil40} years left until a new chapter begins.";

        Console.WriteLine(message);
    }
}
