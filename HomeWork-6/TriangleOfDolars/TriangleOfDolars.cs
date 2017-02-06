using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOfDolars
{
    class TriangleOfDolars
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var rows = number;
            var columns = 1;

            for (var row = 0; row < rows; row++)
            {

                for (var col = 0; col < columns; col++)
                {
                    Console.Write("$ ");
                }

                columns++;
            Console.WriteLine();
            }
        }
    }
}
