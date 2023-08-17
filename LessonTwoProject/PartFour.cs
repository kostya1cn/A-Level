using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PartFourC
{
    public static void PartFour()
    {

        for (int A = 0; A <= 1; A++)
        {
            for (int B = 0; B <= 1; B++)
            {
                bool AND = A == 1 && B == 1;
                bool OR = A == 1 || B == 1;
                bool AND_NOT = A == 1 && B != 1;
                bool OR_NOT = A == 1 || B != 1;
                bool XOR = A != B;

                Console.WriteLine($"A = {A}, B = {B}");
                Console.WriteLine($"AND: {AND}");
                Console.WriteLine($"OR: {OR}");
                Console.WriteLine($"AND-NOT: {AND_NOT}");
                Console.WriteLine($"OR-NOT: {OR_NOT}");
                Console.WriteLine($"XOR: {XOR}");
                Console.WriteLine();
            }
        }
    }
}
