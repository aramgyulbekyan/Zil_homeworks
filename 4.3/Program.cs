using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please inut first float number");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Please inut second float number");
            float b = Convert.ToSingle(Console.ReadLine());

            bool result = false;

            Console.WriteLine("a<b");
            result = a < b;
            Console.WriteLine(result);

            Console.WriteLine("a<=b");
            result = a <= b;
            Console.WriteLine(result);

            Console.WriteLine("a==b");
            result = a == b;
            Console.WriteLine(result);

            Console.WriteLine("a>=b");
            result = a >= b;
            Console.WriteLine(result);

            Console.WriteLine("a>b");
            result = a > b;
            Console.WriteLine(result);

            Console.WriteLine("a!=b");
            result = a != b;
            Console.WriteLine(result);

        }
    }
}
