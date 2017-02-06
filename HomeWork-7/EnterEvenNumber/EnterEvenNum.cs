using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterEvenNumber
{
    class EnterEvenNum
    {
        static void Main(string[] args)
        {
            int number = 0;

            while (true)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());

                    try
                    {
                        if (number % 2 == 0)
                        {
                            break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("The number is not even.");
                    }
                }

                catch 
                {
                    Console.WriteLine("Invalid number!");
                }
            }

                Console.WriteLine("Even number entered: {0}", number);
        }
    }
}