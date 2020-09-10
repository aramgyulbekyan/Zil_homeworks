using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {

            int A = 0;
            int B = 0;

            Console.WriteLine("Enter Numeric Value for A");
            string input1 = Console.ReadLine();
            if (string.IsNullOrEmpty(input1))
            {
                Console.WriteLine("error");
            }
            else
            {
                A = int.Parse(input1);
            }

            Console.WriteLine("Enter Numeric Value for B");
            string input2 = Console.ReadLine();

            if (string.IsNullOrEmpty(input2))
            {
                Console.WriteLine("error");
            }
            else
            {
                B = int.Parse(input2);
            }

            if (A >= B)
            {
                Console.WriteLine("A is not biger than B");

            }
            else
            {
                int l = B - A + 1; // find array length
                int[] array = new int[l];

                //create array and enter values from interval
                for (int i = 0; i < l; i++)
                {
                    array[i] = A++;
                }
                int result = 0;
                for (int a = 0; a < array.Length; a++)
                {
                    result += array[a];
                }
                Console.WriteLine("$ Elements SUM ={0}", result);
                // Console.WriteLine("$Total number of elements is {0}",l);


                Console.ReadKey();
            }
        }
    }
}
