using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Hr : Employee
    {
        public string Floor { get; set; }
        public Hr (string Name, string floor) : base(Name)
        {
            Floor = floor;
        }
        public void HrStuff()
        {
            Console.WriteLine("Doind something HR related");
        }
        public override void Print()
        {
            Console.WriteLine($"{Name} Takes interview on {Floor}");
        }
    }
}
