using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidWithForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sets the hight of the pyramid
            MakeNicePyramid(15);
        }

        static void MakeNicePyramid(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = i; j <= size; j++)
                {
                    // Makes the "stone" in the top centered
                    Console.Write("   ");
                }
                // Calculates the required number of "stones" on each row
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("[]" + " ");
                }
                // Moves down to the next row
                Console.WriteLine();
            }
        }
    }
}
