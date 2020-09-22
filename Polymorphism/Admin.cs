using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Admin:Employee
    {
       public string Sallary { get; set; }
       public Admin(string Name, string sallary) : base(Name)
        {
            this.Sallary=Sallary;
        }
        public  void Planning()
        {
            Console.WriteLine("Planning Companys future");
        }
        public override void Print()
        {
            Console.WriteLine($"{Name} Sallary is {Sallary}");
        }
    }
}
