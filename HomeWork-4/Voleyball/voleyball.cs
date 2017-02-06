using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voleyball
{
    class voleyball
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine();
            var holiday = double.Parse(Console.ReadLine());
            var weekendTravel = double.Parse(Console.ReadLine());

            switch (year)
            {

                case "normal":
                    {
                        var result = (48 - weekendTravel) * 3 / 4 + weekendTravel + holiday * 2 / 3;
                        Console.WriteLine(Math.Floor(result));
                        break;
                    }

                case "leap":
                    {
                        var result = (48 - weekendTravel) * 3 / 4 + weekendTravel + holiday * 2 / 3;
                        var finalResult = result * 0.15;
                        var allreult = result + finalResult;
                        Console.WriteLine(Math.Floor(allreult));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("unknow");
                        break;
                    }
            }
        }
    }
}
