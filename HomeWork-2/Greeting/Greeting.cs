﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    class Greeting
    {
        static void Main(string[] args)
        {
 //           Console.WriteLine("Enter your name: "); 
            var name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);

        }
    }
}
