using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.WriteLine("Enter Numeric Value ");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("error");
            }
            else
            {
                a = int.Parse(input);
            }
            //Console.WriteLine(a);
            int sum = 0;
            int result = 1;
            int digits = 0;
            for (int i = 1; a > 0; i++)
            {
                sum += a % 10;
                result *= a % 10;
                a /= 10;
                digits = i;
            }
            Console.WriteLine("$The sum of digits is {0}, The multiplication result is {1}, Number of digits {2}", sum, result, digits);

        }
    }
}
