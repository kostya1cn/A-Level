using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PartFiveC
{
    public static void PartFive()
    {
        {
            PrintFizzBuzz(1, 100);
        }

        static void PrintFizzBuzz(int start, int end)
        {
            for (int number = start; number <= end; number++)
            {
                string output = GetFizzBuzzOutput(number);
                Console.WriteLine(output);
            }
        }

        static string GetFizzBuzzOutput(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                return "Fizz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return number.ToString();
            }
        }
    }
}
