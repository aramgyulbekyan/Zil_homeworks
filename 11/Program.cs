using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 11;
            double result = 1;

            for (double i = 1; i <= N; i++)
            {
                result *= (i / 10 + 1);
            }
            Console.WriteLine(result); // result does not match 
            Console.ReadKey();
        }
    }
}
