using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
    class calc
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size: ");
            var sideA = int.Parse(Console.ReadLine());
            var Result = sideA * sideA;

            Console.Write("Result is: ");
            Console.WriteLine(Result);
        }
    }
}
