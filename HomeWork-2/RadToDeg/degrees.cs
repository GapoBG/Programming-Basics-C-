using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadToDeg
{
    class degrees
    {
        static void Main(string[] args)
        {
            Console.Write("Enter RADIANS: ");
            var rad = double.Parse(Console.ReadLine());
            var deg = rad * 180 / Math.PI;
            Console.Write("Degrees = ");
            Console.WriteLine(Math.Round(deg));
        }
    }
}
