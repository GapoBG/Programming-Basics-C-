using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTable
{
    class numberTable
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var br = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    br = row + col + 1;

                    if (br < n)
                    {
                        Console.Write(br + " ");
                    }
                    else
                    {
                        br = (2 * n) - col - row - 1;
                        Console.Write(br + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
