using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // за тази задача използвам System.Globalization
 
            Console.Write("Enter DATE (dd-MM-yyyy): ");
            string dateString = Console.ReadLine();
            string format = "dd-MM-yyyy";
            DateTime result = DateTime.ParseExact(dateString, format, CultureInfo.InvariantCulture);
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime output = Convert.ToDateTime(result).AddDays(999);
            Console.WriteLine(output.ToString("dd-MM-yyyy"));
        }
    }
}
