using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Kirsi Kernel";
            person.Profession = "Teacher";
            person.Salary = 1200;
            Console.WriteLine(person.ToString());

            Boss boss = new Boss();
            boss.Name = "Jussi Jurkka";
            boss.Profession = "Head of Institute";
            boss.Salary = 9000;
            boss.Car = "Audi";
            boss.Bonus = 5000;
            Console.WriteLine(boss.ToString());

            person.Salary = 2200;
            Console.WriteLine(person.ToString());


        }
    }
}
