using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter one digit number");
            int n = int.Parse(Console.ReadLine());
            int k = 0;
            do
            {
                Console.WriteLine(k);
                k++;
            } while (k < n);
        }
    }
}
