﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachy
{
    class Fibonachy
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var f0 = 1;
            var f1 = 1;

            for (var i = 0; i < number-1; i++)
            {
                var fResult = f0 + f1;
                f0 = f1;
                f1 = fResult;
            }

            Console.WriteLine(f1);
        }
    }
}
