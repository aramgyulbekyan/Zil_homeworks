using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3

{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 41, b = 22;
            int result;

            result = a + b;
            Console.WriteLine("a+b= " + result);

            result = a - b;
            Console.WriteLine("a-b= " + result);

            result = a * b;
            Console.WriteLine("a*b= " + result);

            result = a / b;
            Console.WriteLine("a/b= " + result);

            result = a % b;
            Console.WriteLine("a%b= " + result);



            float c = 29.5f;
            float d = 14.5f;

            float res;

            res = c - d;
            Console.WriteLine("c-d=" + res);

            res = c + d;
            Console.WriteLine("c+d=" + res);

            res = c * d;
            Console.WriteLine("c*d=" + res);

            res = c / d;
            Console.WriteLine("c/d=" + res);


            int e = 260;
            checked
            {
                byte f = (byte)e; //System.OverflowException

            }

            unchecked
            {
                byte f = (byte)e;
            }

            Console.ReadKey();
        }
    }
}
