using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCommision
{
    class Commision
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine().ToLower();
            var trade = double.Parse(Console.ReadLine());

            if (town == "sofia")
            {
                if (trade >= 0 && trade <= 500)
                {
                    Console.WriteLine(trade*0.05);
                }
                else if (trade > 500 && trade <= 1000)
                {
                    Console.WriteLine(trade*0.07);
                }
                else if (trade > 1000 && trade <= 10000)
                {
                    Console.WriteLine(trade*0.08);
                }
                else if (trade > 10000)
                {
                    Console.WriteLine(trade * 0.12);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            if (town == "varna")
            {
                if (trade >= 0 && trade <= 500)
                {
                    Console.WriteLine(trade * 0.045);
                }
                else if (trade > 500 && trade <= 1000)
                {
                    Console.WriteLine(trade * 0.075);
                }
                else if (trade > 1000 && trade <= 10000)
                {
                    Console.WriteLine(trade * 0.1);
                }
                else if (trade > 10000)
                {
                    Console.WriteLine(trade * 0.13);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            if (town == "plovdiv")
            {
                if (trade >= 0 && trade <= 500)
                {
                    Console.WriteLine(trade * 0.055);
                }
                else if (trade > 500 && trade <= 1000)
                {
                    Console.WriteLine(trade * 0.08);
                }
                else if (trade > 1000 && trade <= 10000)
                {
                    Console.WriteLine(trade * 0.12);
                }
                else if (trade > 10000)
                {
                    Console.WriteLine(trade * 0.145);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
