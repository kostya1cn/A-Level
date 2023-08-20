using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PartSixC
{
    public static void PartSix()
    {
        Console.Write("Enter the lower bound for random numbers: ");
        int lowerBound = int.Parse(Console.ReadLine());

        Console.Write("Enter the upper bound for random numbers: ");
        int upperBound = int.Parse(Console.ReadLine());

        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());

        int[] array = GenerateRandomArray(size, lowerBound, upperBound);

        int evenCount = CountEvenNumbers(array);
        int oddCount = size - evenCount;

        int min = FindMinValue(array);
        int max = FindMaxValue(array);

        Console.WriteLine($"Even numbers count: {evenCount}");
        Console.WriteLine($"Odd numbers count: {oddCount}");
        Console.WriteLine($"Minimum value: {min}");
        Console.WriteLine($"Maximum value: {max}");
    }

    static int[] GenerateRandomArray(int size, int lowerBound, int upperBound)
    {
        int[] array = new int[size];
        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(lowerBound, upperBound + 1);
        }

        return array;
    }

    static int CountEvenNumbers(int[] array)
    {
        int count = 0;
        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }

    static int FindMinValue(int[] array)
    {
        int min = array[0];
        foreach (int number in array)
        {
            if (number < min)
            {
                min = number;
            }
        }
        return min;
    }

    static int FindMaxValue(int[] array)
    {
        int max = array[0];
        foreach (int number in array)
        {
            if (number > max)
            {
                max = number;
            }
        }
        return max;
    }
}
