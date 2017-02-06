using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class tree
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int space = n - 1;
            int star = 1;

            Console.WriteLine(new string(' ', n)  + "|");

            for (int i = 1; i < n; i++)
            {
                for (int row = 1; row < space; row++)
                {
                    Console.Write(" ");
                }
                for (int cow = 1; cow <= star; cow++)
                {
                    Console.Write("*");
                }
                space--;
                star++;
                Console.WriteLine(" | " + new string ('*',star-1));
            }

           
        }
    }
}
