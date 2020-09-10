using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class Program
    {
        public static int Mult (int a)
        {
            int result = 0;
            int prod=1;
            while (a > 0)
            {
                result = a % 10;
                a /= 10;
                if (result%2==0 && result<7)
                {
                    prod *= result;
                }
            }
                return prod;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a numeric value");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(Mult(input));
            Console.ReadKey();
        }
    }
}
