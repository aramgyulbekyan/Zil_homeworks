using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 4 digits number");
            int num = int.Parse(Console.ReadLine());
            int result = 0;
            int sum = 0;
            while (num > 0)
            {
                result = num % 10;
                num /= 10;
                if (result % 2 != 0 && result > 4)
                {
                    sum += result;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
