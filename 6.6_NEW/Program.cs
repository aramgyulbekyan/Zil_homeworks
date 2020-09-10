using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._6_NEW
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eter A Number");

            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter B bigger than A");
            int B = int.Parse(Console.ReadLine());
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
                    Console.WriteLine(array[i]);

                }
                Console.WriteLine("$Total number of elements is {0}", l);


                Console.ReadKey();
            }

        }
    }
}
