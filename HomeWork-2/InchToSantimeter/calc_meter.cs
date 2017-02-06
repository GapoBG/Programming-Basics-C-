using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchToSantimeter
{
    class calc_meter
    {
        static void Main(string[] args)
        {
            Console.Write("Enter, Inch = ");
            var enter = double.Parse(Console.ReadLine());
            var constant = 2.54;
            var inch = enter * constant;

            Console.Write("Santimeter is: ");
            Console.WriteLine(inch);

        }
    }
}
