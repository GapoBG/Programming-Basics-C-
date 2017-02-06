using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsSum
{
    class Vowels
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            var sumA = 0;
            var sumE = 0;
            var sumI = 0;
            var sumO = 0;
            var sumU = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a')
                { sumA++; }
                else if (text[i] == 'e')
                { sumE+= 2; }
                else if (text[i] == 'i')
                { sumI+= 3; }
                else if (text[i] == 'o')
                { sumO+= 4; }
                else if (text[i] == 'u')
                { sumU+= 5; }
            }
            int ResulSum = sumA + sumE + sumI + sumO + sumU;
            Console.WriteLine(ResulSum);

        }
    }
}
