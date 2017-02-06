using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class triangleArea
    {
        static void Main(string[] args)
        {

            var sideA = double.Parse(Console.ReadLine());
            var sideH = double.Parse(Console.ReadLine());
            var ResultArea = sideA * sideH / 2;

            Console.Write("Triangle area =  ");
            Console.WriteLine(Math.Round(ResultArea, 2));

        }
    }
}
