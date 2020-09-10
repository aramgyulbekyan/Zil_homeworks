using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {

            double N = 0;
            string input1 = Console.ReadLine();
            if (string.IsNullOrEmpty(input1))
            {
                Console.WriteLine("error");
            }
            else
            {
                N = double.Parse(input1);
            }
            double result = 1;
            for (double i = 1; i < N; i++)
            {
                result += 1 / i;
            }
            Console.WriteLine(result);
        }
    }
}
