using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentigradeToFahrenheit
{
    class convertTemp
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Centigrade: ");
            var Centigrade = double.Parse(Console.ReadLine());
            var Fahrenheit = Centigrade * 9 / 5 + 32;

            Console.Write("Convert to Fahrenheit is: ");
            Console.WriteLine(Math.Round(Fahrenheit, 2));
        
        }
    }
}
