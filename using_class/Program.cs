using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace using_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number");
            string input = Console.ReadLine();
            StringToIntArray array = new StringToIntArray(input);
            int []result = array.ToIntArray(input);
           
            int length = result.Length;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(result[i]);
            }
            int maxvalue = array.max(array.ToIntArray(input));
            Console.WriteLine(maxvalue);
            Console.ReadLine();
        }
    }
}
