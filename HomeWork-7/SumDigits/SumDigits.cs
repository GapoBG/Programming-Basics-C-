using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSum
{
    class SumDig
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int num;
            int sum = 0;

            while (n != 0)
            {
                num = n % 10;
                n = n / 10;
                sum = sum + num;
            }

            Console.WriteLine(sum);
        }
    }
}
