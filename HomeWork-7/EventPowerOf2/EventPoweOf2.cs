using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPowerOf2
{
    class EventPoweOf2
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var num = 1;

            for (int i = 0; i <= number; i += 2)
            {
                Console.WriteLine(num);
                num = num * 2 * 2;
            }
        }
    }
}
