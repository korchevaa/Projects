using System;
using System.Collections.Generic;
using System.Text;

namespace Izpitvane_29._09._2023
{
    class Employee:Person
    {
        private string organization;

        public Employee()
        {
        }

        public Employee(string name, int age) : base(name, age)
        {
            Name = name;
            Age = age;
        }

        public string Organization
        {
            get { return organization; }
            set { organization = value; }
        }
        public override string ToString()
        {
            return $"{Name} is working in {Organization}.\n I am {Age} years old. I work for {Organization}.\n {Name} is sleeping {Age}.";
        }

    }
}
