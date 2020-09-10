using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < 9; i++)
            {
                double a = Math.Pow(n, i);
                Console.WriteLine(a);
            }
        }
    }
}
