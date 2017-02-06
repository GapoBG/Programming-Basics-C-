using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HalfSumElement
{
    class HalfSumElement
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0.0;
            var maxNum = -100000000;

            for (int i = 0; i < n; i++)
            {
                var y = int.Parse(Console.ReadLine());
                sum += y;

                if (y > maxNum)
                {
                    maxNum = y;
                }

            }

            var sumSmaller = (sum - maxNum);

            if ((sumSmaller) == maxNum)
            {
                Console.WriteLine("Yes sum " + maxNum);
            }
            else
            {
                Console.WriteLine("No diff " + Math.Abs(maxNum - sumSmaller));
            }

        }
    }
}