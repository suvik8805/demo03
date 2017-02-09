using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Person
    {

        public string Name { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }

        public Person()
        {
        }

        public Person(string name, string profession, int salary)
        {
            Name = name;
            Profession = profession;
            Salary = salary;
        }

        public override string ToString()
        {
            return "Name: " + Name + " Profession: " + Profession + " Salary: " + Salary;
        }
    }
}
