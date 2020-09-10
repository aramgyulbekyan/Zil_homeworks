using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");

            double x = Convert.ToDouble(Console.ReadLine());

            if (x < 0 || x % 1 != 0)
                Console.WriteLine("Value is not natural number");

            else if (x % 1 == 0 && x % 2 == 1)
                Console.WriteLine("The value is natural and odd number");

            else if (x % 1 == 0 && x % 2 == 0)
                Console.WriteLine("The valu is naturel but not odd");

            Console.ReadKey();
        }
    }
}
