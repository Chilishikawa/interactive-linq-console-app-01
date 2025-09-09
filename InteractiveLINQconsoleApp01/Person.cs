using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InteractiveLINQconsoleApp01
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public Person(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Salary: {Salary}";
        }
    }
}
