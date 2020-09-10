using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a text ");
            string text1 = Console.ReadLine();
            Console.WriteLine(text1);

            Console.WriteLine("Please enter a character ");
            char letter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(letter);

            Console.WriteLine("Please enter a integer number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);

            Console.WriteLine("Please enter a byte number ");
            byte b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine(b);

            Console.WriteLine("Please enter a double number ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(c);

            Console.WriteLine("Please enter a float number ");
            float d = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(d);

            Console.WriteLine("Please enter a decimal number ");
            decimal dec = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(dec);

            Console.WriteLine("Please enter a character ");
            char letter2 = char.Parse(Console.ReadLine());
            Console.WriteLine(letter2);

            Console.WriteLine("Please enter a integer number");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine(e);

            Console.WriteLine("Please enter a byte number ");
            byte f = byte.Parse(Console.ReadLine());
            Console.WriteLine(f);

            Console.WriteLine("Please enter a double number ");
            double g = double.Parse(Console.ReadLine());
            Console.WriteLine(g);

            Console.WriteLine("Please enter a float number ");
            float h = float.Parse(Console.ReadLine());
            Console.WriteLine(h);

            Console.WriteLine("Please enter a decimal number ");
            decimal dec2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine(dec2);

        }
    }
}
