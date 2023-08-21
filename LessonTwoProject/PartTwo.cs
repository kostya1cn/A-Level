using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PartTwoC
{
    public static void PartTwo()
    {
        double x;

        while (true)
        {
            Console.Write("Enter the value of x: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out x))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid double value.");
            }
        }

            // Calculate the result of the expression
            double result = Math.Pow(x, 4) - Math.Pow(x, 3) + 5 * Math.Pow(x, 2);

        // Print the result to the console
        Console.WriteLine($"The result of the expression for x = {x} is {result}");
    }
}
