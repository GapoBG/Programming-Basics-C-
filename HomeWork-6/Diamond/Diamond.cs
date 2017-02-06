using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());



            if (n % 2 != 0)
            {
                var dash = (n - 1) / 2;
                var dash2 = 1;
                var dashDown = 1;
                var dashDown2 = n - 4;

                Console.WriteLine(new string('-', dash) + "*" + new string('-', dash));
                for (int i = 0; i < (n - 1) / 2; i++)
                {
                    Console.WriteLine(new string('-', dash - 1) + "*" + new string('-', dash2) + "*" + new string('-', dash - 1));
                    dash--;
                    dash2 += 2;
                }
                for (int i = 1; i < (n - 1) / 2; i++)
                {

                    Console.WriteLine(new string('-', dashDown) + "*" + new string('-', dashDown2) + "*" + new string('-', dashDown));
                    dashDown++;
                    dashDown2 -= 2;
                }
                dash = (n - 1) / 2;
                dash2 = 1;
                if (n == 1)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(new string('-', dash) + "*" + new string('-', dash));
                }
            }
            else
            {
                var dash = (n / 2) - 2;
                var dash2 = 1;
                var dashDown = 1;
                var dashDown2 = n - 4;

                Console.WriteLine(new string('-', (n - 2) / 2) + "**" + new string('-', (n - 2) / 2));
                for (int i = 0; i <= (n / 2) - 2; i++)
                {
                    Console.WriteLine(new string('-', dash) + "*" + new string('-', dash2 + 1) + "*" + new string('-', dash));
                    dash--;
                    dash2 += 2;
                }
                for (int i = 1; i < (n / 2) - 1; i++)
                {
                    Console.WriteLine(new string('-', dashDown) + "*" + new string('-', dashDown2) + "*" + new string('-', dashDown));
                    dashDown++;
                    dashDown2 -= 2;
                }
                if (n == 2)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(new string('-', (n - 2) / 2) + "**" + new string('-', (n - 2) / 2));
                }
            }

        }
    }
}
