using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace After15min
{
    class after15min
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());

            var totalMin = min + 15;
            var totalHour = hour + totalMin/60;
            var minuteAfterHour = totalMin % 60;

            if (totalHour == 24)
            {
                Console.WriteLine("0:{0:00}", minuteAfterHour);
            }
            else
            {
                Console.WriteLine("{0:0}:{1:00}", totalHour, minuteAfterHour);
            }
        }
 
    }
}
