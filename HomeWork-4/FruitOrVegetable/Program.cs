using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameProduct = Console.ReadLine() ;

            if (nameProduct.Equals("banana") || nameProduct.Equals("apple") || nameProduct.Equals("kiwi") 
                || (nameProduct.Equals("cherry") || nameProduct.Equals("lemon") || nameProduct.Equals("grapes")))
            {
                Console.WriteLine("fruit");
            }
            else if (nameProduct.Equals("tomato") || nameProduct.Equals("cucumber") 
                || (nameProduct.Equals("pepper") || nameProduct.Equals("carrot")))
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }

        }
    }
}
