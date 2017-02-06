using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            var project = Console.ReadLine().ToLower();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());

                if (project == "premiere")
                {
                    var price = 12.00;
                    var result = row * column * price;
                    Console.WriteLine("{0:f2}", result);
                }
                else if (project == "discount")
                {
                    var price = 5.00;
                    var result = row * column * price;
                    Console.WriteLine("{0:f2}", result);
                }
                else if (project == "normal")
                {
                    var price = 7.50;
                    var result = row * column * price;
                    Console.WriteLine("{0:f2}", result);
                }


            }

    }
}
