using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var sec1 = int.Parse(Console.ReadLine());
            var sec2 = int.Parse(Console.ReadLine());
            var sec3 = int.Parse(Console.ReadLine());
            var secs = sec1 + sec2 + sec3;
            var minute = 0;

            if (secs > 119)
            {
                minute = minute + 2;
                secs = secs - 120;
            }
            if (secs > 59)
            {
                minute++;
                secs = secs - 60;
            }
            if (secs < 10)
            {
                Console.WriteLine(minute + ":" + "0" + secs);
            }
            else
            {
                Console.WriteLine(minute + ":" + secs);
            }
        }
    }
}
