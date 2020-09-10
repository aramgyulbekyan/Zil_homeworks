using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Please inpunt number for A ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please inpunt number for B ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A={0} B={1}", a, b);

            c = a;
            a = b;
            b = c;

            Console.WriteLine("after swap A={0} B={1}", a, b);

            a += b;
            b = a - b;
            a -= b;

            Console.WriteLine("after second swap A={0} B={1}", a, b);

        }
    }
}

