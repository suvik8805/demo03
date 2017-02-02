using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht05_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            Students student1 = new Students();
            student1.Name = "Oskari";
            student1.Year = 2014;
            student1.Average = 3.6;
            student1.Points = 135;

            Students student2 = new Students();
            student2.Name = "Katja";
            student2.Year = 2016;
            student2.Average = 3.2;
            student2.Points = 25;

            Students student3 = new Students();
            student3.Name = "Seppo";
            student3.Year = 2015;
            student3.Average = 4.1;
            student3.Points = 70;

            Students student4 = new Students();
            student4.Name = "Ninni";
            student4.Year = 2015;
            student4.Average = 3.2;
            student4.Points = 66;
            Students student5 = new Students();
            student5.Name = "Topi";
            student5.Year = 2012;
            student5.Average = 4.7;
            student5.Points = 190;

            student1.PrintData();
            student2.PrintData();
            student3.PrintData();
            student4.PrintData();
            student5.PrintData();

            student2.AddCourse();
            student3.AddCourse();

            student3.AddGrade(4);
            student5.AddGrade(2);
            

        }



    }
}
