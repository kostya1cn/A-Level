using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PartOneC
{
    public static void PartOne()
    {
        int N = 20;
        int[] A = new int[N];
        int[] B;

        Random random = new Random();

        // Generate array A with random integers between -1000 and 1000
        for (int i = 0; i < N; i++)
        {
            A[i] = random.Next(-1000, 1001);
        }

        // Count elements in range -100 to +100
        int countInRange = 0;
        foreach (int num in A)
        {
            if (num >= -100 && num <= 100)
            {
                countInRange++;
            }
        }

        Console.WriteLine("Number of elements in the range -100 to +100: " + countInRange);

        // Create array B with elements <= 888 from array A
        int countB = 0;
        for (int i = 0; i < N; i++)
        {
            if (A[i] <= 888)
            {
                countB++;
            }
        }

        B = new int[countB];
        int indexB = 0;
        for (int i = 0; i < N; i++)
        {
            if (A[i] <= 888)
            {
                B[indexB] = A[i];
                indexB++;
            }
        }

        // Sort array B in descending order
        Array.Sort(B, (a, b) => b.CompareTo(a));

        // Print array B
        Console.WriteLine("Array B (sorted in descending order):");
        foreach (int num in B)
        {
            Console.Write(num + " ");
        }
    }
}
