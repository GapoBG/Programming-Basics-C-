﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number100_200
{
    class Program
    {
        static void Main(string[] args)
        {
            var enterNum = int.Parse(Console.ReadLine());

            if (enterNum < 100)
            {
                Console.WriteLine("Less than 100");
            }

            else if (enterNum > 100 && enterNum < 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else if (enterNum > 200)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
