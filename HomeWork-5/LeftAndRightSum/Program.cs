﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
                var sumLeft = 0;
                var sumRight = 0;

            for (int i = 0; i < n; i++)
                {
                    var Number = int.Parse(Console.ReadLine());
                    sumLeft = sumLeft + Number;
                }

            for (int i = 0; i < n; i++)
                {
                    var Number = int.Parse(Console.ReadLine());
                    sumRight = sumRight + Number;
                }

            if (sumLeft == sumRight)
                {
                    Console.WriteLine("Yes, sum = {0}", sumRight);
                }
            else
                {
                    var result = Math.Abs(sumLeft - sumRight);
                    Console.WriteLine("No diff = {0}", result);
                }

        }


     }
    
}