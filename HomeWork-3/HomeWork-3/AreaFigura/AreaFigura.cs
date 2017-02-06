using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFigura
{
    class AreaFigura
    {
        static void Main(string[] args)
        {
            var nameFig = Console.ReadLine().ToLower();

            if (nameFig == "square")
            { 
                var enterSize = double.Parse(Console.ReadLine());
                var area = enterSize * enterSize;
                Console.WriteLine(Math.Round(area,3));
            }
            else if (nameFig == "reactangle")
            {
                var enterSizeA = double.Parse(Console.ReadLine());
                var enterSizeB = double.Parse(Console.ReadLine());
                var area = enterSizeA * enterSizeB;
                Console.WriteLine(Math.Round(area,3));
            }
            else if (nameFig == "circle")
            {
                var enterRadios = double.Parse(Console.ReadLine());
                var area = Math.PI*(enterRadios*enterRadios);
                Console.WriteLine(Math.Round(area,3));
            }
            else if (nameFig == "triangle")
            {
                var enterSizeA = double.Parse(Console.ReadLine());
                var enterSizeH = double.Parse(Console.ReadLine());
                var area = enterSizeA*enterSizeH/2;
                Console.WriteLine(Math.Round(area,3));
            }
        }
    }
}
