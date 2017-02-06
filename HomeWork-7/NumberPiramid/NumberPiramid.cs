using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPiramid
{
    class NumberPiramid
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var count = 0;

            for (int row = 0; row < number; row++)
            {
                for (int col = 0; row < number; col++)
                {
                    count = row + col + 1;
                    if (count < number)
                    {
                        Console.Write(count + " ");
                    }
                    else
                    {
                        count = (2 * number) - col - row - 1;
                        Console.Write(count + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
