using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoida_Area
{
    class trapezoida
    {
        static void Main(string[] args)
        {
            var sideB1 = double.Parse(Console.ReadLine());
            var sideB2 = double.Parse(Console.ReadLine());
            var sideH = double.Parse(Console.ReadLine());

            var Result = (sideB1 + sideB2) * sideH/2;

            Console.WriteLine("Trapezoida Area is: {0}", Result);

        }
    }
}
