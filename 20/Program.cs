using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    class Program
    {
        public static int[] StringConvertToIntArray(string str)
        {
            int[] result = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                result[i] = int.Parse(str[i].ToString());
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number");
            string input = Console.ReadLine();
            int[] arr = StringConvertToIntArray(input);
            int max = (arr.Max(element => Math.Abs(element)));
            int min = (arr.Min(element => element));
            
            int output = max - min;
            output = (int)Math.Pow(output,2);
            Console.WriteLine($"The result is {output}");
            Console.ReadKey();

        }
    }
}
