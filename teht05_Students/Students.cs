using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht05_Students
{
    class Students
    {

        //properties
        public string Name { get; set; }
        public int Year { get; set; }
        public double Average { get; set; }
        public int Points { get; set; }


        //methods
        public void AddCourse()
        {
            Points = Points + 4;
            Console.WriteLine();
            Console.WriteLine("Name of the student: " + Name);
            Console.WriteLine("Completed course credits: " + Points);
        }

        public void AddGrade(int value)
        {
            Average = (Average + value) / 2;
            Console.WriteLine();
            Console.WriteLine("Name of the student: " + Name);
            Console.WriteLine("New Average is: " + Average);
        }
    
        public void PrintData()
        {
            Console.WriteLine("Name of the student: " + Name);
            Console.WriteLine("Starting year of the studies: " + Year);
            Console.WriteLine("The average of the grades is: " + Average);
            Console.WriteLine("Completed course credits: " + Points);
        }


    }
}
