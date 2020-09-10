using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 4 digit number");
            int a = int.Parse(Console.ReadLine());
            int s = 0;
            while (a > 0)
            {
                s = s + a % 10; //find last digit
                a = a / 10;// remove last digit
            }


            Console.WriteLine(s);
            Console.ReadKey();

        }
    }
}
