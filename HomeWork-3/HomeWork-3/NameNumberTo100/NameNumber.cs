using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameNumberTo100
{
    class NameNumber
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());


            if (number >= 0 && number <= 100)
            {
                if (number == 0)
                {
                    Console.WriteLine("zero");
                }

                if (number == 100)
                {
                    Console.WriteLine("one hundred");
                }

                if (number >= 1 && number <= 19)
                {
                    if (number == 1)
                    {
                        Console.WriteLine("one");
                    }
                    else if (number == 2)
                    {
                        Console.WriteLine("two");
                    }
                    else if (number == 3)
                    {
                        Console.WriteLine("three");
                    }
                    else if (number == 4)
                    {
                        Console.WriteLine("four");
                    }
                    else if (number == 5)
                    {
                        Console.WriteLine("five");
                    }
                    else if (number == 6)
                    {
                        Console.WriteLine("six");
                    }
                    else if (number == 7)
                    {
                        Console.WriteLine("seven");
                    }
                    else if (number == 8)
                    {
                        Console.WriteLine("eight");
                    }
                    else if (number == 9)
                    {
                        Console.WriteLine("nine");
                    }
                    else if (number == 10)
                    {
                        Console.WriteLine("ten");
                    }
                    else if (number == 11)
                    {
                        Console.WriteLine("eleven");
                    }
                    else if (number == 12)
                    {
                        Console.WriteLine("twelve");
                    }
                    else if (number == 13)
                    {
                        Console.WriteLine("thirteen");
                    }
                    else if (number == 14)
                    {
                        Console.WriteLine("fourteen");
                    }
                    else if (number == 15)
                    {
                        Console.WriteLine("fifteen");
                    }
                    else if (number == 16)
                    {
                        Console.WriteLine("sixteen");
                    }
                    else if (number == 17)
                    {
                        Console.WriteLine("seventeen");
                    }
                    else if (number == 18)
                    {
                        Console.WriteLine("eighteen");
                    }
                    else if (number == 19)

                        Console.WriteLine("nineteen");
                }



                if (number >= 20 && number <= 99)
                {
                    var firstDigit = number / 10;
                    var secondDigit = number % 10;
                    var numberName = "";

                    if (firstDigit == 2)
                    {
                        numberName += "twenty";
                    }
                    else if (firstDigit == 3)
                    {
                        numberName += "thirty";
                    }
                    else if (firstDigit == 4)
                    {
                        numberName += "fourty";
                    }
                    else if (firstDigit == 5)
                    {
                        numberName += "fifty";
                    }
                    else if (firstDigit == 6)
                    {
                        numberName += "sixty";
                    }
                    else if (firstDigit == 7)
                    {
                        numberName += "seventy";
                    }
                    else if (firstDigit == 8)
                    {
                        numberName += "eighty";
                    }
                    else if (firstDigit == 9)
                    {
                        numberName += "ninety";
                    }




                    if (secondDigit == 1)
                    {
                        numberName += " one";
                    }
                    else if (secondDigit == 2)
                    {
                        numberName += " two";
                    }
                    else if (secondDigit == 3)
                    {
                        numberName += " three";
                    }
                    else if (secondDigit == 4)
                    {
                        numberName += " four";
                    }
                    else if (secondDigit == 5)
                    {
                        numberName += " five";
                    }
                    else if (secondDigit == 6)
                    {
                        numberName += " six";
                    }
                    else if (secondDigit == 7)
                    {
                        numberName += " seven";
                    }
                    else if (secondDigit == 8)
                    {
                        numberName += " eight";
                    }
                    else if (secondDigit == 9)
                    {
                        numberName += " nine";
                    }




                    Console.WriteLine(numberName);
                }
            }

            else
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}
