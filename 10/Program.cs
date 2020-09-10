using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static int Task(int N)

        {
            int result = 0;
            for (int i = 1; i <N; i++)
            {
                result += (N + i) * 2;
            }
            result = (N * 2) + result + (2 * N) * 2;
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a numeric value");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(Task(a));
            Console.ReadKey();
        }
    }
}
