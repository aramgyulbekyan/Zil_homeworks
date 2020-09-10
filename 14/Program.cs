using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a 2 or more digit number");
            int n = 0;
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("error");
            }
            else
            {
                n = int.Parse(input);
            }

            if (n < 10)
            {
                Console.WriteLine("Please enter a 2 or more digit number");
            }
            else
            {
                int a = n;
                int sum = 0;

                for (int i = 0; i != 0; i++)
                {
                    sum += n % 10;
                    n /= 10;

                }
                if (sum * 2 == a)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}
