using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var inputX = double.Parse(Console.ReadLine());
            var inputY = double.Parse(Console.ReadLine());

            if (x1 < x2 && y1 < y2)
            {
                if (inputX >= x1 && inputX <= x2 && inputY >= y1 && inputY <= y2)
                {
                    Console.WriteLine("Inside");
                }
                else
                {
                    Console.WriteLine("Outside");
                }

            }
            else
            {
                Console.WriteLine("Try Agein!");
            }

        }
    }
}
