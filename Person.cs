using System;
using System.Collections.Generic;
using System.Text;

namespace Izpitvane_29._09._2023
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;

        public Person()
        {
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Sleep()
        {
            return $"{this.Name} is sleeping {this.Age}";
        }

    }
}
