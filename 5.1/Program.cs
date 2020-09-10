using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a value");
            int a = Convert.ToInt32(Console.ReadLine());

            //if else 
            if (a % 2 == 0 || a % 3 == 0)

                Console.WriteLine("Value devides to 2 or 3");
            else
                Console.WriteLine("value cannot be devided");

            // ternar operator
            Console.WriteLine(a % 2 == 0 ? "Value devides to 2 or 3" : "Value devides to 2 or 3");

        }
    }
}
