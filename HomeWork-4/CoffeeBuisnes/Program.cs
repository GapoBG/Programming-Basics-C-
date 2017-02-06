using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeBuisnes
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().ToLower();
            var town = Console.ReadLine().ToLower();
            var counts = double.Parse(Console.ReadLine());

            if (town == "sofia")
            {
                if (product == "coffee")
                {
                    var price = counts * 0.50;
                    Console.WriteLine(price);
                }
                else if (product == "water")
                {
                    var price = counts * 0.80;
                    Console.WriteLine(price);
                }
                else if (product == "beer")
                {
                    var price = counts * 1.20;
                    Console.WriteLine(price);
                }
                else if (product == "sweet")
                {
                    var price = counts * 1.45;
                    Console.WriteLine(price);
                }
                else if (product == "peanuts")
                {
                    var price = counts * 1.60;
                    Console.WriteLine(price);
                }
            }

            if (town == "plovdiv")
            {
                if (product == "coffee")
                {
                    var price = counts * 0.40;
                    Console.WriteLine(price);
                }
                else if (product == "water")
                {
                    var price = counts * 0.70;
                    Console.WriteLine(price);
                }
                else if (product == "beer")
                {
                    var price = counts * 1.15;
                    Console.WriteLine(price);
                }
                else if (product == "sweet")
                {
                    var price = counts * 1.30;
                    Console.WriteLine(price);
                }
                else if (product == "peanuts")
                {
                    var price = counts * 1.50;
                    Console.WriteLine(price);
                }
            }

            if (town == "varna")
            {
                if (product == "coffee")
                {
                    var price = counts * 0.45;
                    Console.WriteLine(price);
                }
                else if (product == "water")
                {
                    var price = counts * 0.70;
                    Console.WriteLine(price);
                }
                else if (product == "beer")
                {
                    var price = counts * 1.10;
                    Console.WriteLine(price);
                }
                else if (product == "sweet")
                {
                    var price = counts * 1.35;
                    Console.WriteLine(price);
                }
                else if (product == "peanuts")
                {
                    var price = counts * 1.55;
                    Console.WriteLine(price);
                }
            }



        }
    }
}
