using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var OddSum = 0;
            var EvenSum = 0;

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    EvenSum = EvenSum + number;
                }
                else
                {
                    OddSum = OddSum + number;
                }
            }

            if (EvenSum == OddSum)
            {
                Console.WriteLine("Yes Sum = {0}", EvenSum);
            }

            else
            {
                var result = Math.Abs(EvenSum - OddSum);
                Console.WriteLine("No Diff = {0}", result);
            }
        }
    }
}
