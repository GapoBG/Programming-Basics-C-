using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_of_Stars
{
    class SquareStars
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string ('*',n));

            for (var i = 0; i < n-1; i++)
            {
               Console.WriteLine(new string('*', 1) + new string (' ', n -2) + new string ('*', 1)) ;

            }
            Console.WriteLine(new string ('*', n));
        }
    }
}


/*

            int numOfRaws = int.Parse(Console.ReadLine());
 
            for (int a = 1; a <= numOfRaws; a++)
                Console.Write("*");
                Console.WriteLine();
            for (int row =  1; row <= numOfRaws - 2; row++)
            {
                Console.Write("*");
                for (int b = 1; b <= numOfRaws - 2; b++)
                    Console.Write(" ");
                Console.Write("*");
                Console.WriteLine();
            }
            for (int a = 1; a <= numOfRaws; a++)
                Console.Write("*");
            Console.WriteLine();

 *  това решение дава 100/100
 * по-горното работи но дава 0/100
