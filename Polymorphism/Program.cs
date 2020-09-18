using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Ann");
            e1.Print();
            
            Hr h1 = new Hr("Samvel", "13");
            h1.Print();
            
            Admin a1 = new Admin("Alex", "1000$");
            a1.Print();//ovveride method call

            //own methods call
            h1.HrStuff();
            a1.Planning();
            Console.ReadLine();
        
        }
    }
}
