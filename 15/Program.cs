using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int a = 0;
            //    Console.WriteLine("Enter 3 digit number");
            //    string input = Console.ReadLine();
            //    if (string.IsNullOrEmpty(input))
            //    {
            //        Console.WriteLine("error");
            //    }
            //    else
            //    {
            //        a = int.Parse(input);
            //    }

            //    int b = a % 100;
            int i = 100;
            while (true)
            {

                if ((i % 100) * 7 == i)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}
