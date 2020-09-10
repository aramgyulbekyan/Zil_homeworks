using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
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
                Console.WriteLine("B is not biger than A");

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
                bool result = false;
                int index = 0;
                for (int a = 0; result == false; a++)
                {

                    result = array[a] % 3 == 0;
                    index = a;
                }
                Console.WriteLine("$index of value is {0}", index);
            }
        }
    }
}
