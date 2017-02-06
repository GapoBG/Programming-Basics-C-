using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturiel
{
    class facturiel
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var fakt = 1;

            do
            {
                fakt = fakt * n;
                n--;
            }
            while (n > 1);
            Console.WriteLine(fakt);

        }
    }
}
