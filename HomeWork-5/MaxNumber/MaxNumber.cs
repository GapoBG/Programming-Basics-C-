﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var max = -10000000000;

            for (var i = 1; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number > max)
                    max = number;
            }
            Console.WriteLine(max);
        }
    }
}
