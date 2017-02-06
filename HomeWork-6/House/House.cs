using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hause
{
    class house
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var br = 1;

            if (n % 2 == 0)
            {
                br++;
            }
            for (int i = 0; i < (n + 1) / 2; i++)
            {
                int dash = (n - br) / 2;
                Console.WriteLine(new string('-', dash) + new string('*', br) + new string('-', dash));
                br += 2;
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("|" + new string('*', n - 2) + "|");
            }



        }
    }
}

