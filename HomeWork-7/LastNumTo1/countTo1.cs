using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastNumTo1
{
    class countTo1
    {
        static void Main(string[] args)
        {
            var num = 1;
            var number = int.Parse(Console.ReadLine());

            for (int i=0; i<= number; i++)
            {
                Console.WriteLine(num);
                num = num *2;
            }

        }
    }
}
