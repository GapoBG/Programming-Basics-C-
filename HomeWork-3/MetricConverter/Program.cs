using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = double.Parse(Console.ReadLine());
            var codeA = Console.ReadLine().ToLower();
            var codeB = Console.ReadLine().ToLower();

            if (codeA == "km")
            {
                size /= 0.001;
            }
            else if (codeA == "ft")
            {
                size /= 3.2808399;
            }
            else if (codeA == "yd")
            {
                size /= 1.0936133;
            }
            else if (codeA == "in")
            {
                size /= 39.3700787;
            }
            else if (codeA == "mi")
            {
                size /= 0.000621371192;
            }
            else if (codeA == "cm")
            {
                size /= 100;
            }
            else if (codeA == "mm")
            {
                size /= 1000;
            }
            else if (codeA == "m")
            {
                size /= 1;
            }

            if (codeB == "km")
            {
                size *= 0.001;
            }
            else if (codeB == "ft")
            {
                size *= 3.2808399;
            }
            else if (codeB == "yd")
            {
                size *= 1.0936133;
            }
            else if (codeB == "in")
            {
                size *= 39.3700787;
            }
            else if (codeB == "mi")
            {
                size *= 0.000621371192;
            }
            else if (codeB == "cm")
            {
                size *= 100;
            }
            else if (codeB == "mm")
            {
                size *= 1000;
            }
            else if (codeB == "m")
            {
                size = size * 1;
            }

           
            Console.WriteLine(size);

        }
    }
}
