using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PartSevenC
{
    public static void PartSeven()
    {
        Console.Write("Enter your full name: ");
        string fullName = Console.ReadLine();

        bool exitRequested = false;

        while (!exitRequested)
        {
            Console.WriteLine("Available commands: get-data, get-time, get-temperature, exit");
            Console.Write("Enter a command: ");
            string command = Console.ReadLine().ToLower();

            switch (command)
            {
                case "get-data":
                    DateTime currentDate = DateTime.Now.Date;
                    Console.WriteLine($"Current date: {currentDate.ToShortDateString()}");
                    break;

                case "get-time":
                    DateTime currentTime = DateTime.Now;
                    Console.WriteLine($"Current time: {currentTime.ToShortTimeString()}");
                    break;

                case "get-temperature":
                    DateTime currentDateTime = DateTime.Now;
                    Random random = new Random();
                    double temperature = random.NextDouble() * 30; // Generating a random temperature between 0 and 30
                    Console.WriteLine($"Current date and time: {currentDateTime}");
                    Console.WriteLine($"Random temperature: {temperature:F2}°C");
                    break;

                case "exit":
                    exitRequested = true;
                    Console.WriteLine($"Goodbye, {fullName}!");
                    break;

                default:
                    Console.WriteLine("Invalid command. Exiting...");
                    exitRequested = true;
                    break;
            }
        }
    }
}
