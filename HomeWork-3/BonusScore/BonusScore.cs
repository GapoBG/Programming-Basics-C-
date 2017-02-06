using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var bonusScore = 0.0;
            if (number <= 100)
            {
                bonusScore = 5;
            }
            else if (number > 1000)
            {
                bonusScore = 0.1 * number;
            }
            else if (number > 100)
            {
                bonusScore = 0.2 * number;
            }

            if (number %2 == 0)
            {
                bonusScore = bonusScore + 1;
            }
            else if (number %10 == 5)
            {
                bonusScore = bonusScore +2;
            }
            Console.WriteLine("Bonus Score is {0}", bonusScore);
            Console.WriteLine("Total Score is {0}", number + bonusScore );
        }
    }
}
