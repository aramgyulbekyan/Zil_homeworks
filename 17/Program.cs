using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please input number more than 2 digit");
            int a = int.Parse(Console.ReadLine());
            int len = 0;
            int temp = a;
            while (temp > 0)
            {
                temp /= 10;
                len++;
            }
            int[] array = new int[len];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] += a % 10;
                a /= 10;
                //Console.WriteLine(array[i]);
            }
            int min = 10;
            for (int i = 0; i < (array.Length); i++)
            {
                if (array[i] % 2 != 0 && array[i] < min)
                {
                    min = array[i];
                }
            }

            Console.WriteLine("$Minimum od value is {0} ", min);
        }
    }
}
