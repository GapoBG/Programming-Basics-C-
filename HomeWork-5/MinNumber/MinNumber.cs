using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinNumber
{
    class MinNumber
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var min = 10000000;

            for (var i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number < min)
                    min = number;
            }
            Console.WriteLine(min);
        }
    }
}
