using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeOrNot
{
    class PrimeOrNot
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var prime = 0;

            while (number < 2)
            {
                Console.WriteLine("Not Prime");
                number = int.Parse(Console.ReadLine());
            }

            for ( int i=1; i<=number; i++)
            {
                if (number % i == 0)
                {
                    prime++;
                }
            }

            if (prime == 2)
            {
                Console.WriteLine("Prime {0}", number);
            }
            else
            {
                Console.WriteLine("Not Prime {0}", number);
            }
            
        }
    }
}
