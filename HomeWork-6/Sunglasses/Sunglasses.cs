﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunGlasses
{
    class SunGlasses
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));

            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write("*" + new string('/', 2 * n - 2) + "*");
                if (i == (n - 1) / 2)
                {
                    Console.Write(new string('|', n));
                }
                else
                {
                    Console.Write(new string(' ', n));
                }
                Console.Write("*" + new string('/', 2 * n - 2) + "*");
                Console.WriteLine();

            }

            Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));


        }
    }
}
