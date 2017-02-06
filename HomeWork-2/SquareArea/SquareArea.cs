using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareArea
{
    class SquareArea
    {
        static void Main(string[] args)
        {
            Console.Write("A = ");
            var a = int.Parse(Console.ReadLine());

            Console.WriteLine("Result = {0}", a*a);
        }
    }
}
