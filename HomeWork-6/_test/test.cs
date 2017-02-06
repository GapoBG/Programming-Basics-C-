using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _test
{
    class test
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine("*");
            }
            else if (n > 1)
            {
                Console.WriteLine(new string(' ',n-1) + "*");
                for (int i = 1; i < n; i++)
                {
                    Console.WriteLine("*" + new string(' ', n-1) + "*");
                }
            }

            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
