﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USDtoBGN
{
    class usdTObgn
    {
        static void Main(string[] args)
        {

            var USD = double.Parse(Console.ReadLine());
            var BGN = USD * 1.79549;
            Console.Write("BGN = ");
            Console.WriteLine(Math.Round(BGN,2));

        }
    }
}
