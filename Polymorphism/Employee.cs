﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Employee
    {
        public string Name { get; set; }
        public Employee(string name)
        {
            this.Name=Name;
        }
        public virtual void Print()
        {
            Console.WriteLine(Name);
        }

    }
}
