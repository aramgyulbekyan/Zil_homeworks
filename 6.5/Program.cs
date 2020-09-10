using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            int result = 0;

            for (int i = 0; i < a;)
            {
                result = result + i;
                i += 2;
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
